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

namespace Ejyle.DevAccelerate.Core.Lists
{
    public class Timezone : Timezone<string, string>
    { }

    public class Timezone<TKey, TOptionalKey> : EntityBase<TKey, TOptionalKey>, ITimezone<TKey, TOptionalKey>
    {
        [Required]
        [StringLength(255)]
        public string Name
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }
    }
}
