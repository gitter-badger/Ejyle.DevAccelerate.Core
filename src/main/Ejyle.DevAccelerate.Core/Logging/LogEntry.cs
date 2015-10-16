// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Logging
{
    public class LogEntry : ILogEntry
    {
        public string Title
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public int Priority
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public ICollection<string> Categories
        {
            get;
            set;
        }
    }
}
