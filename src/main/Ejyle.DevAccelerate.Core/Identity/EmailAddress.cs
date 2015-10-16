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

namespace Ejyle.DevAccelerate.Core.Identity
{
    public class EmailAddress<TUser> : EmailAddress<string, string, TUser>
        where TUser : IUser<string, string>
    { }

    public class EmailAddress<TKey, TOptionalKey, TUser> : EntityBase<TKey, TOptionalKey>, IEmailAddress<TKey, TOptionalKey>
        where TUser : IUser<TKey, TOptionalKey>
    {
        public TKey UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        public bool IsConfirmed { get; set; }
        public TUser User { get; set; }
    }
}
