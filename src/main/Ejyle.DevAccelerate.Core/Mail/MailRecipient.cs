// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public class MailRecipient : MailRecipient<MailMessage>
    {
    }

    public class MailRecipient<TMailMessage> : MailRecipient<string, string, TMailMessage>
        where TMailMessage : IMailMessage<string, string>
    {
    }

    public class MailRecipient<TKey, TOptionalKey, TMailMessage> : EntityBase<TKey, TOptionalKey>, IMailRecipient<TKey, TOptionalKey>
        where TMailMessage : IMailMessage<TKey, TOptionalKey>
    {
        [StringLength(100)]
        public string Name { get; set; }
        public TKey UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string EmailAddress { get; set; }
        public MailRecipientType RecipientType { get; set; }
        public TKey MailMessageId { get; set; }
        public MailStatus Status { get; set; }
        public virtual TMailMessage Message { get; set; }
    }
}
