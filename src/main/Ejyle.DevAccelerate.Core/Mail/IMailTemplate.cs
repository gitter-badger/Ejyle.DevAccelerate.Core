// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public interface IMailTemplate<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string Name { get; set; }
        TKey MailSenderId { get; set; }
        string Subject { get; set; }
        string Message { get; set; }
        bool IsHtml { get; set; }
        MailPriority Priority { get; set; }
        string Sender { get; set; }
        bool HasMessageParams { get; set; }
        bool HasSubjectParams { get; set; }
        bool HasRecipientMessageParams { get; set; }
        bool HasRecipientSubjectParams { get; set; }
    }
}
