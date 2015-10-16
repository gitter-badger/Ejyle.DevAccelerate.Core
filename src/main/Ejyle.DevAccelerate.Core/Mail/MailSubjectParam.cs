// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public class MailSubjectParam : MailSubjectParam<MailMessage>
    { }

    public class MailSubjectParam<TMailMessage> : MailSubjectParam<string, string, TMailMessage>
        where TMailMessage : IMailMessage<string, string>
    { }

    public class MailSubjectParam<TKey, TOptionalKey, TMailMessage> : EntityBase<TKey, TOptionalKey>, IMailSubjectParam<TKey, TOptionalKey>
        where TMailMessage : IMailMessage<TKey, TOptionalKey>
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Value { get; set; }
        public TKey MailMessageId { get; set; }
        public virtual TMailMessage Message { get; set; }
    }
}
