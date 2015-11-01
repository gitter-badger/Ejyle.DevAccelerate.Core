// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Web;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using Ejyle.DevAccelerate.Core.Caching;
using Ejyle.DevAccelerate.Core.Exceptions;
using Ejyle.DevAccelerate.Core.Logging;
using Ejyle.DevAccelerate.Core.Configuration;
using Ejyle.DevAccelerate.Core.Files;
using Ejyle.DevAccelerate.Core.Identity;
using Ejyle.DevAccelerate.Core.Data;
using Ejyle.DevAccelerate.Core.Mail;

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// Represents the APIs to bootstrap a DevAccelerate application. This class cannot be inherited.
    /// </summary>
    public sealed class DaApplicationContext
    {
        private static DaApplicationConfigurationSection _ApplicationSettings;
        private static MailServiceConfigurationSection _MailServiceSettings;
        private static CachingConfigurationSection _CachingSettings;
        private static LoggingConfigurationSection _LoggingSettings;
        private static ExceptionHandlingConfigurationSection _ExceptionHandlingSettings;
        private static DatabaseConfigurationSection _DatabaseSettings;
        private static FileStorageConfigurationSection _FileStorageServiceSettings;
        private static IdentityConfigurationSection _IdentitySettings;
        private static DaApplicationContextExtensions _Extensions;

        static DaApplicationContext()
        {
            _Extensions = new DaApplicationContextExtensions();
        }

        /// <summary>
        /// Sets the application configuration of <see cref="DaApplicationConfigurationSection"/> type within the context.
        /// </summary>
        /// <param name="configurationSource">The configuration source.</param>
        public static void SetApplicationSettings(IConfigurationSource configurationSource)
        {
            _ApplicationSettings = configurationSource.GetConfigurationSection<DaApplicationConfigurationSection>("daApplicationConfiguration");
        }

        /// <summary>
        /// Sets the identity configuration of <see cref="IdentityConfigurationSection"/> type within the context.
        /// </summary>
        /// <param name="configurationSource">The configuration source.</param>
        public static void SetIdentitySettings(IConfigurationSource configurationSource)
        {
            _IdentitySettings = configurationSource.GetConfigurationSection<IdentityConfigurationSection>("daIdentityConfiguration");
        }

        /// <summary>
        /// Sets the mail configuration of <see cref="MailServiceConfigurationSection"/> type within the context.
        /// </summary>
        /// <param name="configurationSource">The configuration source.</param>
        public static void SetMailServiceSettings(IConfigurationSource configurationSource)
        {
            _MailServiceSettings = configurationSource.GetConfigurationSection<MailServiceConfigurationSection>("daMailServiceConfiguration");
        }

        /// <summary>
        /// Sets the caching configuration of <see cref="CachingConfigurationSection"/> type within the context.
        /// </summary>
        /// <param name="configurationSource">The configuration source.</param>
        public static void SetCachingSettings(IConfigurationSource configurationSource)
        {
            _CachingSettings = configurationSource.GetConfigurationSection<CachingConfigurationSection>("daCachingConfiguration");
        }

        /// <summary>
        /// Sets the logging configuration of <see cref="LoggingConfigurationSection"/> type within the context.
        /// </summary>
        /// <param name="configurationSource">The configuration source.</param>
        public static void SetLoggingSettings(IConfigurationSource configurationSource)
        {
            _LoggingSettings = configurationSource.GetConfigurationSection<LoggingConfigurationSection>("daLoggingConfiguration");
        }

        /// <summary>
        /// Sets the exception handling configuration of <see cref="ExceptionHandlingConfigurationSection"/> type within the context.
        /// </summary>
        /// <param name="configurationSource">The configuration source.</param>
        public static void SetExceptionHandlingSettings(IConfigurationSource configurationSource)
        {
            _ExceptionHandlingSettings = configurationSource.GetConfigurationSection<ExceptionHandlingConfigurationSection>("daExceptionHandlingConfiguration");
        }

        /// <summary>
        /// Sets the database configuration of <see cref="DatabaseConfigurationSection"/> type within the context.
        /// </summary>
        /// <param name="configurationSource">The configuration source.</param>
        public static void SetDatabaseSettings(IConfigurationSource configurationSource)
        {
            _DatabaseSettings = configurationSource.GetConfigurationSection<DatabaseConfigurationSection>("daDatabaseConfiguration");
        }

        /// <summary>
        /// Sets the file storage configuration of <see cref="FileStorageConfigurationSection"/> type within the context.
        /// </summary>
        /// <param name="configurationSource">The configuration source.</param>
        public static void SetFileStorageSettings(IConfigurationSource configurationSource)
        {
            _FileStorageServiceSettings = configurationSource.GetConfigurationSection<FileStorageConfigurationSection>("daFileStorageConfiguration");
        }

        /// <summary>
        /// Gets the DevAccelerate application configuration.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="DaApplicationConfigurationSection"/> class.</returns>
        public static DaApplicationConfigurationSection GetApplicationSettings()
        {
            return _ApplicationSettings;
        }

        /// <summary>
        /// Gets the identity configuration.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="IdentityConfigurationSection"/> class.</returns>
        public static IdentityConfigurationSection GetIdentitySettings()
        {
            return _IdentitySettings;
        }

        /// <summary>
        /// Gets the mail configuration.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="MailServiceConfigurationSection"/> class.</returns>
        public static MailServiceConfigurationSection GetMailSettings()
        {
            return _MailServiceSettings;
        }

        /// <summary>
        /// Gets the exception handling configuration.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="ExceptionHandlingConfigurationSection"/> class.</returns>
        public static ExceptionHandlingConfigurationSection GetExceptionHandlingSettings()
        {
            return _ExceptionHandlingSettings;
        }

        /// <summary>
        /// Gets the file storage configuration.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="FileStorageConfigurationSection"/> class.</returns>
        public static FileStorageConfigurationSection GetFileStorageSettings()
        {
            return _FileStorageServiceSettings;
        }

        /// <summary>
        /// Creates an intance of a cache manager.
        /// </summary>
        /// <typeparam name="TCacheManager">The type of the cache manager.</typeparam>
        /// <returns>Returns an instance of the TCacheManager type that implements the <see cref="ICacheManager"/> interface.</returns>
        public static TCacheManager CreateCacheManager<TCacheManager>()
            where TCacheManager : ICacheManager
        {
            if (_CachingSettings == null)
            {
                throw new InvalidOperationException("Caching settings have not been set and therefore cache manager cannot be created.");
            }

            Type type = Type.GetType(_CachingSettings.Type);
            var cacheManager = (TCacheManager)Activator.CreateInstance(type);

            return cacheManager;
        }

        /// <summary>
        /// Creates an instance of a log manager.
        /// </summary>
        /// <typeparam name="TLogManager">The type of the log manager.</typeparam>
        /// <returns>Returns an instance of the TLogManager that implements the <see cref="ILogManager"/> interface.</returns>
        public static TLogManager CreateLogManager<TLogManager>()
            where TLogManager : ILogManager
        {
            if (_LoggingSettings == null)
            {
                throw new InvalidOperationException("Logging settings have not been set and therefore log manager cannot be created.");
            }

            Type type = Type.GetType(_LoggingSettings.Type);
            var logManager = (TLogManager)Activator.CreateInstance(type);

            return logManager;
        }

        /// <summary>
        /// Creates an instance of a exception manager.
        /// </summary>
        /// <typeparam name="TExceptionManager">The type of the exception manager.</typeparam>
        /// <returns>Returns an instance of the TExceptionManager type that implements the <see cref="IExceptionManager"/> interface.</returns>
        public static TExceptionManager CreateExceptionManager<TExceptionManager>()
            where TExceptionManager : IExceptionManager
        {
            if (_ExceptionHandlingSettings == null)
            {
                throw new InvalidOperationException("Exception handling settings have not been set and therefore exception manager cannot be created.");
            }

            Type type = Type.GetType(_ExceptionHandlingSettings.Type);
            var exceptionManager = (TExceptionManager)Activator.CreateInstance(type);

            return exceptionManager;
        }

        /// <summary>
        /// Creates an instance of a database context.
        /// </summary>
        /// <typeparam name="TDatabaseContext">The type of the database context.</typeparam>
        /// <returns>Returns an instance of the TDatabaseContext type that implements the <see cref="IDatebaseContext"/> interface.</returns>
        public static TDatabaseContext CreateDatabaseContext<TDatabaseContext>()
            where TDatabaseContext : IDatebaseContext
        {
            if(_DatabaseSettings == null)
            {
                throw new InvalidOperationException("Database settings have not been set and therefore database context cannot be created.");
            }

            Type type = Type.GetType(_DatabaseSettings.Databases.GetByName(_DatabaseSettings.DefaultDatabase).DatabaseContextType);
            var context = (TDatabaseContext)Activator.CreateInstance(type);
            context.ConnectionString = _DatabaseSettings.GetDefaultDatabaseConfiguration().ConnectionString;
            
            return context;
        }

        /// <summary>
        /// Creates an instace of a file storage manager.
        /// </summary>
        /// <returns>Returns an instance of a type that implements the <see cref="IFileStorageManager"/> interface.</returns>
        public static IFileStorageManager CreateFileStorageManager()
        {
            if (_FileStorageServiceSettings == null)
            {
                throw new InvalidOperationException("File storage settings have not been set and therefore file storage service manager cannot be created.");
            }

            Type type = Type.GetType(_FileStorageServiceSettings.Type);

            var fileStorageServiceManager = (IFileStorageManager)Activator.CreateInstance(type);

            foreach (var extendedProperty in _FileStorageServiceSettings.ExtendedProperties)
            {
                var ep = extendedProperty as ExtendedPropertyConfigurationElement;
                fileStorageServiceManager.ExtendedProperties.Add(ep.Name, ep.Value);
            }
            
            return fileStorageServiceManager;
        }

        /// <summary>
        /// Creates an instance of a user context manager
        /// </summary>
        /// <returns>Returns an instance of a type that implements the <see cref="IUserContextManager"/> interface.</returns>
        public static IUserContextManager GetUserContextManager()
        {
            if (_ApplicationSettings == null)
            {
                return null;
            }

            var ucmType = _ApplicationSettings.UserContextManager;

            if (string.IsNullOrEmpty(ucmType))
            {
                return null;
            }

            Type type = Type.GetType(ucmType);

            return (IUserContextManager)Activator.CreateInstance(type);
        }

        /// <summary>
        /// Gets an instance of the DaApplicationContextExtensions class. The purpose of the class is to let other developers to add extension methods to the <see cref="DaApplicationContext"/> class.
        /// </summary>
        public static DaApplicationContextExtensions Extensions
        {
            get
            {
                return _Extensions;
            }
        }
    }
}
