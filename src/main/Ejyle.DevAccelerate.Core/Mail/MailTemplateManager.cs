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
    public class MailTemplateManager<TRepository> : EntityManagerBase<string, string, MailTemplate, IMailTemplateRepository<string, string, MailTemplate>>
        where TRepository : IMailTemplateRepository<string, string, MailTemplate>
    {
        public MailTemplateManager(TRepository repository)
            : base(repository)
        { }

        public Task<List<MailTemplate>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }
    }
}
