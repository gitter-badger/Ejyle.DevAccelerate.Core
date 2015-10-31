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
    public class SystemAccount : SystemAccount<SystemAccountMember>
    {
        public SystemAccount()
            : base()
        { }
    }

    public class SystemAccount<TSystemAccountMember> : SystemAccount<string, string, TSystemAccountMember>
        where TSystemAccountMember : ISystemAccountMember<string, string>
    {
        public SystemAccount()
            : base()
        {
            Id = Guid.NewGuid().ToString();
            CreatedBy = null;
            CreatedDateUtc = DateTime.Now;
            LastUpdatedBy = null;
            LastUpdatedDateUtc = DateTime.Now;
        }
    }

    public class SystemAccount<TKey, TOptionalKey, TSystemAccountMember> : EntityBase<TKey, TOptionalKey>, ISystemAccount<TKey, TOptionalKey>
        where TSystemAccountMember : ISystemAccountMember<TKey, TOptionalKey>
    {
        public SystemAccount()
            : base()
        {
            SystemAccountMembers = new HashSet<TSystemAccountMember>();
        }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }        
        public SystemAccountType SystemAccountType { get; set; }
        public TOptionalKey TimeZoneId { get; set; }
        public AccountStatus Status { get; set; }
        public TKey OwnerUserId { get; set; }
        public bool IsArchived { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public virtual ICollection<TSystemAccountMember> SystemAccountMembers
        {
            get;
            set;
        }
    }
}
