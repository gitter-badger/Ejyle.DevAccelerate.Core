﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Ejyle.DevAccelerate.Core.Caching;
using Ejyle.DevAccelerate.Core.Exceptions;
using Ejyle.DevAccelerate.Core.Logging;
using Ejyle.DevAccelerate.Core.Configuration;

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// Represents the APIs to bootstrap a DevAccelerate application. This class cannot be inherited.
    /// </summary>
    public sealed class DaApplicationContext
    {
        private static Dictionary<string, DaConfigurationSection> _Settings = new Dictionary<string, DaConfigurationSection>();

        /// <summary>
        /// Sets up configuration from a configuration source.
        /// </summary>
        /// <typeparam name="TConfigurationSection">The type of the configuration section.</typeparam>
        /// <param name="configurationName">The name of the configuration section.</param>
        /// <param name="configurationSource">The source of the configuration section.</param>
        public static void SetupConfiguration<TConfigurationSection>(string configurationName, IDaConfigurationSource configurationSource)
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
        /// <typeparam name="TConfigurationSection">The type of the configuration source.</typeparam>
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
        /// <returns>Returns an instance of the TCacheManager type that implements the <see cref="IDaCacheManager"/> interface.</returns>
        public static TCacheManager CreateCacheManager<TCacheManager>()
            where TCacheManager : IDaCacheManager
        {
            var cachingConfiguration = GetConfiguration<DaCachingConfigurationSection>("daCachingConfiguration");

            if (cachingConfiguration == null)
            {
                throw new InvalidOperationException("Caching configuration has not been set up and therefore cache manager cannot be created.");
            }

            var providerConfig = cachingConfiguration.Providers.GetByName(cachingConfiguration.DefaultProvider);

            Type type = Type.GetType(providerConfig.Type);
            var cacheManager = (TCacheManager)Activator.CreateInstance(type);

            return cacheManager;
        }

        /// <summary>
        /// Creates an intance of a cache manager.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="IDaCacheManager"/> type.</returns>
        public static IDaCacheManager CreateCacheManager()
        {
            var cachingConfiguration = GetConfiguration<DaCachingConfigurationSection>("daCachingConfiguration");

            if (cachingConfiguration == null)
            {
                throw new InvalidOperationException("Caching configuration has not been set up and therefore cache manager cannot be created.");
            }

            var providerConfig = cachingConfiguration.Providers.GetByName(cachingConfiguration.DefaultProvider);

            Type type = Type.GetType(providerConfig.Type);
            var cacheManager = (IDaCacheManager)Activator.CreateInstance(type);

            return cacheManager;
        }

        /// <summary>
        /// Creates an instance of a log manager.
        /// </summary>
        /// <typeparam name="TLogManager">The type of the log manager.</typeparam>
        /// <returns>Returns an instance of the TLogManager that implements the <see cref="IDaLogManager"/> interface.</returns>
        public static TLogManager CreateLogManager<TLogManager>()
            where TLogManager : IDaLogManager
        {
            var loggingConfiguration = GetConfiguration<DaLoggingConfigurationSection>("daLoggingConfiguration");

            if (loggingConfiguration == null)
            {
                throw new InvalidOperationException("Logging configuration has not been set up and therefore log manager cannot be created.");
            }

            var providerConfig = loggingConfiguration.Providers.GetByName(loggingConfiguration.DefaultProvider);

            Type type = Type.GetType(providerConfig.Type);
            var logManager = (TLogManager)Activator.CreateInstance(type);

            return logManager;
        }

        /// <summary>
        /// Creates an instance of a log manager.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="IDaLogManager"/> type.</returns>
        public static IDaLogManager CreateLogManager()
        {
            var loggingConfiguration = GetConfiguration<DaLoggingConfigurationSection>("daLoggingConfiguration");

            if (loggingConfiguration == null)
            {
                throw new InvalidOperationException("Logging configuration has not been set up and therefore log manager cannot be created.");
            }

            var providerConfig = loggingConfiguration.Providers.GetByName(loggingConfiguration.DefaultProvider);

            Type type = Type.GetType(providerConfig.Type);
            var logManager = (IDaLogManager)Activator.CreateInstance(type);

            return logManager;
        }

        /// <summary>
        /// Creates an instance of a exception manager.
        /// </summary>
        /// <typeparam name="TExceptionManager">The type of the exception manager.</typeparam>
        /// <returns>Returns an instance of the TExceptionManager type that implements the <see cref="IDaExceptionManager"/> interface.</returns>
        public static TExceptionManager CreateExceptionManager<TExceptionManager>()
            where TExceptionManager : IDaExceptionManager
        {
            var exceptionHandlingConfiguration = GetConfiguration<DaExceptionHandlingConfigurationSection>("daExceptionHandlingConfiguration");

            if (exceptionHandlingConfiguration == null)
            {
                throw new InvalidOperationException("Exception handling configuration has not been set up and therefore exception manager cannot be created.");
            }

            var providerConfig = exceptionHandlingConfiguration.Providers.GetByName(exceptionHandlingConfiguration.DefaultProvider);

            Type type = Type.GetType(providerConfig.Type);
            var exceptionManager = (TExceptionManager)Activator.CreateInstance(type);

            return exceptionManager;
        }

        /// <summary>
        /// Creates an instance of a exception manager.
        /// </summary>
        /// <returns>Returns an instance of the <see cref="IDaExceptionManager"/> interface.</returns>
        public static IDaExceptionManager CreateExceptionManager()
        {
            var exceptionHandlingConfiguration = GetConfiguration<DaExceptionHandlingConfigurationSection>("daExceptionHandlingConfiguration");

            if (exceptionHandlingConfiguration == null)
            {
                throw new InvalidOperationException("Exception handling configuration has not been set up and therefore exception manager cannot be created.");
            }

            var providerConfig = exceptionHandlingConfiguration.Providers.GetByName(exceptionHandlingConfiguration.DefaultProvider);

            Type type = Type.GetType(providerConfig.Type);
            var exceptionManager = (IDaExceptionManager)Activator.CreateInstance(type);

            return exceptionManager;
        }
    }
}
