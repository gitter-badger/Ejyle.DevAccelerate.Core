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
    public class Address : Address<UserAddress>
    {
        public Address()
            : base()
        { }
    }

    public class Address<TUserAddress> : Address<string, string, TUserAddress>
        where TUserAddress : IUserAddress<string, string>
    {
        public Address()
            : base()
        { }
    }

    public class Address<TKey, TOptionalKey, TUserAddress> : EntityBase<TKey, TOptionalKey>, IAddress<TKey, TOptionalKey>
        where TUserAddress : IUserAddress<TKey, TOptionalKey>
    {
        public Address()
        {
            UserAddresses = new HashSet<TUserAddress>();
        }

        [StringLength(255)]
        public string Address1 { get; set; }

        [StringLength(255)]
        public string Address2 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }

        [StringLength(100)]
        public string State { get; set; }
        public TKey CountryId { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Fax { get; set; }
        public virtual ICollection<TUserAddress> UserAddresses { get; set; }
    }
}
