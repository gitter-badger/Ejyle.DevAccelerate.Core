// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejyle.DevAccelerate.Core.Lists
{
    public class GenericList : GenericList<GenericListItem>
    { }

    public class GenericList<TGenericListItem> : GenericList<string, string, TGenericListItem>
        where TGenericListItem : IGenericListItem<string, string>
    {
        public GenericList()
            : base()
        { }
    }

    public class GenericList<TKey, TOptionalKey, TGenericListItem> : EntityBase<TKey, TOptionalKey>, IGenericList<TKey, TOptionalKey>
        where TGenericListItem : IGenericListItem<TKey, TOptionalKey>
    {
        public GenericList()
            : base()
        {
            GenericListItems = new HashSet<TGenericListItem>();
        }

        public virtual ICollection<TGenericListItem> GenericListItems { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public TKey ParentId { get; set; }
        public string Description { get; set; }
    }
}
