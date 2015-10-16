// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public class MailSender : MailSender<string, string>
    { }

    public class MailSender<TKey, TOptionalKey> : EntityBase<TKey, TOptionalKey>, IMailSender<TKey, TOptionalKey>
    {
        public TKey UserId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string EmailAddress { get; set; }
    }
}
