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

namespace Ejyle.DevAccelerate.Core
{
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

        public static void SetApplicationSettings(IConfigurationSource configurationSource)
        {
            _ApplicationSettings = configurationSource.GetConfigurationSection<DaApplicationConfigurationSection>("daApplicationConfiguration");
        }

        public static void SetIdentitySettings(IConfigurationSource configurationSource)
        {
            _IdentitySettings = configurationSource.GetConfigurationSection<IdentityConfigurationSection>("daIdentityConfiguration");
        }

        public static void SetMailServiceSettings(IConfigurationSource configurationSource)
        {
            _MailServiceSettings = configurationSource.GetConfigurationSection<MailServiceConfigurationSection>("daMailServiceConfiguration");
        }

        public static void SetCachingSettings(IConfigurationSource configurationSource)
        {
            _CachingSettings = configurationSource.GetConfigurationSection<CachingConfigurationSection>("daCachingConfiguration");
        }

        public static void SetLoggingSettings(IConfigurationSource configurationSource)
        {
            _LoggingSettings = configurationSource.GetConfigurationSection<LoggingConfigurationSection>("daLoggingConfiguration");
        }

        public static void SetExceptionHandlingSettings(IConfigurationSource configurationSource)
        {
            _ExceptionHandlingSettings = configurationSource.GetConfigurationSection<ExceptionHandlingConfigurationSection>("daExceptionHandlingConfiguration");
        }

        public static void SetDatabaseSettings(IConfigurationSource configurationSource)
        {
            _DatabaseSettings = configurationSource.GetConfigurationSection<DatabaseConfigurationSection>("daDatabaseConfiguration");
        }

        public static void SetFileStorageSettings(IConfigurationSource configurationSource)
        {
            _FileStorageServiceSettings = configurationSource.GetConfigurationSection<FileStorageConfigurationSection>("daFileStorageConfiguration");
        }

        public static IdentityConfigurationSection GetApplicationSettings()
        {
            return _IdentitySettings;
        }

        public static IdentityConfigurationSection GetIdentitySettings()
        {
            return _IdentitySettings;
        }

        public static MailServiceConfigurationSection GetMailSettings()
        {
            if(_MailServiceSettings == null)
            {
                throw new InvalidOperationException("Mail settings have not been set.");
            }

            return _MailServiceSettings;
        }

        public static ExceptionHandlingConfigurationSection GetExceptionHandlingSettings()
        {
            return _ExceptionHandlingSettings;
        }

        public static FileStorageConfigurationSection GetFileStorageSettings()
        {

            if(_FileStorageServiceSettings == null)
            {
                throw new InvalidOperationException("File storage settings have not been set.");
            }

            return _FileStorageServiceSettings;
        }

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

        public static TDatabaseContext CreateDatabaseContext<TDatabaseContext>()
            where TDatabaseContext : IDatebaseContext
        {
            if(_DatabaseSettings == null)
            {
                throw new InvalidOperationException("Database settings have not been set and therefore database context cannot be created.");
            }

            Type type = Type.GetType(_DatabaseSettings.Databases[_DatabaseSettings.DefaultDatabase].DatabaseContextType);
            var context = (TDatabaseContext)Activator.CreateInstance(type);
            context.ConnectionString = _DatabaseSettings.GetDefaultDatabaseConfiguration().ConnectionString;
            
            return context;
        }

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

        public static DaApplicationContextExtensions Extensions
        {
            get
            {
                return _Extensions;
            }
        }
    }
}
