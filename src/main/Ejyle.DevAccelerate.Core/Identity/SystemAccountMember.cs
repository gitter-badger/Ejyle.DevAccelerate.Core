// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Identity
{
    public class SystemAccountMember : SystemAccountMember<SystemAccount>
    {
    }

    public class SystemAccountMember<TSystemAccount> : SystemAccountMember<string, string, TSystemAccount>
        where TSystemAccount : ISystemAccount<string, string>
    { 
    }

    public class SystemAccountMember<TKey, TOptionalKey, TSystemAccount> : EntityBase<TKey, TOptionalKey>, ISystemAccountMember<TKey, TOptionalKey>
        where TSystemAccount : ISystemAccount<TKey, TOptionalKey>
    {
        public TKey UserId
        {
            get;
            set;
        }

        public TKey SystemAccountId
        {
            get;
            set;
        }

       public AccountStatus Status
        {
            get;
            set;
        }

       public TSystemAccount SystemAccount
       {
           get;
           set;
       }
    }
}
