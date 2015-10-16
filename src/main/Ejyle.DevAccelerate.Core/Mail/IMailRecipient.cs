// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public interface IMailRecipient<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string Name { get; set; }
        TKey UserId { get; set; }
        string EmailAddress { get; set; }
        MailRecipientType RecipientType { get; set; }
        TKey MailMessageId { get; set; }
        MailStatus Status { get; set; }
    }
}
