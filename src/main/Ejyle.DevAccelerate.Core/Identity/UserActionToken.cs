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
    public class UserActionToken : UserActionToken<string, string>
    {
        public UserActionToken()
            : base()
        { }
    }

    public class UserActionToken<TKey, TOptionalKey> : EntityBase<TKey, TOptionalKey>, IUserActionToken<TKey, TOptionalKey>
    {
        public UserActionToken()
            : base()
        { }

        [Required]
        public TKey UserId
        {
            get;
            set;
        }

        [Required]
        [StringLength(500)]
        public string Token
        {
            get;
            set;
        }

        [StringLength(30)]
        public string IPAddress
        {
            get;
            set;
        }

        public UserActionTokenType TokenType
        {
            get;
            set;
        }

        public Nullable<DateTime> ExpiryDate
        {
            get;
            set;
        }
    }
}
