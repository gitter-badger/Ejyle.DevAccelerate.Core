// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Identity
{
    public interface ISystemAccount<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string Name { get; set; }
        bool IsArchived { get; set; }
        DateTime? ArchivedDate { get; set; }

        SystemAccountType SystemAccountType { get; set; }
        AccountStatus Status { get; set; }
    }
}
