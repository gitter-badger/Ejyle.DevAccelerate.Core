// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using Ejyle.DevAccelerate.Core.Configuration;
namespace Ejyle.DevAccelerate.Core.Logging
{
    public interface ILogManager
    {
        void Write(ILogEntry logEntry);
    }
}
