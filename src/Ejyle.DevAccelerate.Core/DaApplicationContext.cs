// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Ejyle.DevAccelerate.Core.Caching;
using Ejyle.DevAccelerate.Core.Exceptions;
using Ejyle.DevAccelerate.Core.Logging;
using Ejyle.DevAccelerate.Core.Configuration;
using Ejyle.DevAccelerate.Core.Data;

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// Represents the APIs to bootstrap a DevAccelerate application. This class cannot be inherited.
    /// </summary>
    public sealed class DaApplicationContext
    {
        private static Dictionary<string, DaConfigurationSection> _Settings = new Dictionary<string, DaConfigurationSection>();
        private static DaApplicationContextExtensions _Extensions;

        /// <summary>
        /// Sets up configuration from a configuration source.
        /// </summary>
        /// <typeparam name="TConfigurationSection">The type of the configuration section.</typeparam>
        /// <param name="configurationName">The name of the configuration section.</param>
        /// <param name="configurationSource">The source of the configuration section.</param>
        public static void SetupConfiguration<TConfigurationSection>(string configurationName, IConfigurationSource configurationSource)
            where TConfigurationSection: DaConfigurationSection
        {
            if(string.IsNullOrEmpty(configurationName))
            {
                throw new ArgumentNullException("configurationName");
            }

            if(configurationSource == null)
            {
                throw new ArgumentNullException("configurationSource");
            }

            var settings = configurationSource.GetConfigurationSection<TConfigurationSection>(configurationName);
            _Settings.Add(configurationName, settings);
        }

        /// <summary>
        /// Gets the configuration section by its name.
        /// </summary>
        /// <param name="configurationName">The name of the configuration section.</param>
        /// <returns>Returns an instance of the <see cref="DaConfigurationSection"/> type.</returns>
        public static TConfigurationSection GetConfiguration<TConfigurationSection>(string configurationName)
            where TConfigurationSection: DaConfigurationSection
        {
            return _Settings[configurationName] as TConfigurationSection;
        }
        
        /// <summary>
        /// Creates an intance of a cache manager.
        /// </summary>
        /// <typeparam name="TCacheManager">The type of the cache manager.</typeparam>
        /// <returns>Returns an instance of the TCacheManager type that implements the <see cref="ICacheManager"/> interface.</returns>
        public static TCacheManager CreateCacheManager<TCacheManager>()
            where TCacheManager : ICacheManager
        {
            var cachingConfiguration = GetConfiguration<CachingConfigurationSection>("daCachingConfiguration");

            if (cachingConfiguration == null)
            {
                throw new InvalidOperationException("Caching configuration has not been set up and therefore cache manager cannot be created.");
            }

            Type type = Type.GetType(cachingConfiguration.Type);
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
            var loggingConfiguration = GetConfiguration<LoggingConfigurationSection>("daLoggingConfiguration");

            if (loggingConfiguration == null)
            {
                throw new InvalidOperationException("Logging configuration has not been set up and therefore log manager cannot be created.");
            }

            Type type = Type.GetType(loggingConfiguration.Type);
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
            var exceptionHandlingConfiguration = GetConfiguration<ExceptionHandlingConfigurationSection>("daExceptionHandlingConfiguration");

            if (exceptionHandlingConfiguration == null)
            {
                throw new InvalidOperationException("Exception handling configuration has not been set up and therefore exception manager cannot be created.");
            }

            Type type = Type.GetType(exceptionHandlingConfiguration.Type);
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
            var databaseConfiguration = GetConfiguration<DatabaseConfigurationSection>("daDatabaseConfiguration");

            if(databaseConfiguration == null)
            {
                throw new InvalidOperationException("Database configuration has not been set up and therefore database context cannot be created.");
            }

            Type type = Type.GetType(databaseConfiguration.Databases.GetByName(databaseConfiguration.DefaultDatabase).DatabaseContextType);
            var context = (TDatabaseContext)Activator.CreateInstance(type);
            context.ConnectionString = databaseConfiguration.GetDefaultDatabaseConfiguration().ConnectionString;
            
            return context;
        }

        /// <summary>
        /// Gets an instance of the DaApplicationContextExtensions class. The purpose of the class is to let other developers to add extension methods to the <see cref="DaApplicationContext"/> class.
        /// </summary>
        public static DaApplicationContextExtensions Extensions
        {
            get
            {
                if(_Extensions == null)
                {
                    _Extensions = new DaApplicationContextExtensions();
                }

                return _Extensions;
            }
        }
    }
}
