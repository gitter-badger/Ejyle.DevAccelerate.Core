// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public enum MailStatus
    {
        New = 0,
        Draft = 1,
        PendingForDelivery = 2,
        DeliveryCompleted = 3,
        DeliveryFailed = 4
    }
}
