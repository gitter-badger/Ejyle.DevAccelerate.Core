// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Logging
{
    public interface ILogEntry
    {
        string Title
        {
            get;
            set;
        }

        string Message
        {
            get;
            set;
        }

        int Priority
        {
            get;
            set;
        }

        DateTime Date
        {
            get;
            set;
        }

        ICollection<string> Categories
        {
            get;
            set;
        }
    }
}
