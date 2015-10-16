// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Exceptions
{
    public class DefaultExceptionManager : IExceptionManager
    {
        public void HandleExpcetion(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void HandleExpcetion(Exception ex, string exceptionPolicy)
        {
            throw new NotImplementedException();
        }
    }
}
