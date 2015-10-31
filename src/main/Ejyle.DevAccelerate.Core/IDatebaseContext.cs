﻿// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core
{
    /// <summary>
    /// Defines the properties and methods for database context management.
    /// </summary>
    public interface IDatebaseContext : IDisposable
    {
        /// <summary>
        /// Gets or sets the connection string of the database.
        /// </summary>
        string ConnectionString { get; set; }
    }
}
