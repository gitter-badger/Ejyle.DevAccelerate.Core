// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Tasks
{
    public class TaskResult
    {
        public TaskResult()
        {
            IsSucceeded = true;
            Exceptions = null;
        }

        public TaskResult(Exception exception)
        {
            IsSucceeded = false;
            Exceptions = new List<Exception>();
            Exceptions.Add(exception);
        }

        public TaskResult(List<Exception> exceptions)
        {
            IsSucceeded = false;
            Exceptions = exceptions;
        }

        public bool IsSucceeded
        {
            get;
            private set;
        }

        public List<Exception> Exceptions
        {
            get;
            private set;
        }
    }
}
