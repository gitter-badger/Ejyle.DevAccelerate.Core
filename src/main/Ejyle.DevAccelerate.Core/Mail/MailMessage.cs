// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public class MailMessage : MailMessage<MailMessageParam, MailRecipient, MailSubjectParam>
    {
        public MailMessage()
            : base()
        { }
    }

    public class MailMessage<TMailMessageParam, TMailRecipient, TMailSubjectParam> : MailMessage<string, string, TMailMessageParam, TMailRecipient, TMailSubjectParam>
        where TMailMessageParam : IMailMessageParam<string, string>
        where TMailRecipient : IMailRecipient<string, string>
        where TMailSubjectParam : IMailSubjectParam<string, string>
    {
        public MailMessage()
            : base()
        { }
    }

    public class MailMessage<TKey, TOptionalKey, TMailMessageParam, TMailRecipient, TMailSubjectParam> : EntityBase<TKey, TOptionalKey>, IMailMessage<TKey, TOptionalKey>
        where TMailMessageParam : IMailMessageParam<TKey, TOptionalKey>
        where TMailRecipient : IMailRecipient<TKey, TOptionalKey>
        where TMailSubjectParam : IMailSubjectParam<TKey, TOptionalKey>
    {
        public MailMessage()
        {
            MessageParams = new HashSet<TMailMessageParam>();
            Recipients = new HashSet<TMailRecipient>();
            SubjectParams = new HashSet<TMailSubjectParam>();
        }

        public TKey MailTemplateId { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsHtml { get; set; }

        [StringLength(100)]
        public string SenderName { get; set; }

        [StringLength(255)]
        public string SenderEmail { get; set; }
        public MailStatus Status { get; set; }
        public MailPriority Priority { get; set; }
        public bool HasMessageParams { get; set; }
        public bool HasSubjectParams { get; set; }
        public bool HasRecipientMessageParams { get; set; }
        public bool HasRecipientSubjectParams { get; set; }
        public Nullable<DateTime> DueData { get; set; }
        public Nullable<DateTime> SentDate { get; set; }
        public virtual ICollection<TMailMessageParam> MessageParams { get; set; }
        public virtual ICollection<TMailRecipient> Recipients { get; set; }
        public virtual ICollection<TMailSubjectParam> SubjectParams { get; set; }
    }
}
