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
    public class MailSenderManager<TRepository> : EntityManagerBase<string, string, MailSender, IMailSenderRepository<string, string, MailSender>>
        where TRepository : IMailSenderRepository<string, string, MailSender>
    {
        public MailSenderManager(TRepository repository)
            : base(repository)
        { }
 
        public Task<List<MailSender>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }
    }
}
