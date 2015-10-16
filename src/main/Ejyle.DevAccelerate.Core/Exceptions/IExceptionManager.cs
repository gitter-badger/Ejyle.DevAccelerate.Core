// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
using System;

namespace Ejyle.DevAccelerate.Core.Exceptions
{
    public interface IExceptionManager
    {
        void HandleExpcetion(Exception ex);
        void HandleExpcetion(Exception ex, string exceptionPolicy);
    }
}
