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
    public class UserReport : UserReport<string, string>
    { }

    public class UserReport<TKey, TOptionalKey> : EntityBase<TKey, TOptionalKey>, IUserReport<TKey, TOptionalKey>
    {
        public TKey UserId
        {
            get;
            set;
        }

        [Required]
        public string ReportedUsedId
        {
            get;
            set;
        }

        public UserReportReason Reason
        {
            get;
            set;
        }
        public UserReportStatus Status
        {
            get;
            set;
        }
        public UserReportAction Action
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }
        public string Notes
        {
            get;
            set;
        }
    }
}
