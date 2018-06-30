// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Sms
{
    public interface ISmsProvider
    {
        void Send(string to, string body);
        Task SendAsync(string to, string body);
    }
}
