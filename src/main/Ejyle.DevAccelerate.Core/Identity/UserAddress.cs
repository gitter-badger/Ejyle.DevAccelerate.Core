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
    public class UserAddress : UserAddress<Address>
    { }

    public class UserAddress<TAddress> : UserAddress<string, string, TAddress>
        where TAddress : IAddress<string, string>
    { }

    public class UserAddress<TKey, TOptionalKey, TAddress> : EntityBase<TKey, TOptionalKey>, IUserAddress<TKey, TOptionalKey>
        where TAddress : IAddress<TKey, TOptionalKey>
    {
        public TKey UserId { get; set; }
        public TKey AddressId { get; set; }
        public bool IsDelete { get; set; }
        public AddressType AddressType { get; set; }
        public virtual TAddress Address { get; set; }
    }
}
