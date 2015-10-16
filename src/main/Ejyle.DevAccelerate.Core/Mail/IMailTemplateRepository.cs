// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public interface IMailTemplateRepository<TKey, TOptionalKey, TMailTemplate> : IEntityRepository<TKey, TOptionalKey, TMailTemplate>
        where TMailTemplate : IMailTemplate<TKey, TOptionalKey>
    {
        Task<List<TMailTemplate>> FindAllAsync();
    }
}
