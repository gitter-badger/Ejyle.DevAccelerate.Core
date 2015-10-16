// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public interface IMailMessage<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        TKey MailTemplateId { get; set; }
        string Subject { get; set; }
        string Message { get; set; }
        bool IsHtml { get; set; }
        string SenderName { get; set; }
        string SenderEmail { get; set; }
        MailStatus Status { get; set; }
        MailPriority Priority { get; set; }
        bool HasMessageParams { get; set; }
        bool HasSubjectParams { get; set; }
        bool HasRecipientMessageParams { get; set; }
        bool HasRecipientSubjectParams { get; set; }
        Nullable<System.DateTime> DueData { get; set; }
        Nullable<System.DateTime> SentDate { get; set; }
    }
}
