// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Identity
{
    public interface IAddress<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string ZipCode { get; set; }
        string State { get; set; }
        TKey CountryId { get; set; }
        string Phone { get; set; }
        string Fax { get; set; }
    }
}
