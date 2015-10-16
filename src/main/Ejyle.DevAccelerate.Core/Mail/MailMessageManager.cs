// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejyle.DevAccelerate.Core.Mail;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public class MailMessageManager<TRepository> : EntityManagerBase<string, string, MailMessage, IMailMessageRepository<string, string, MailMessage>>
        where TRepository : IMailMessageRepository<string, string, MailMessage>
    {
        public MailMessageManager(TRepository repository)
            : base(repository)
        { }

        public Task<List<MailMessage>> FindByStatusAsync(MailStatus status)
        {
            return Repository.FindByStatusAsync(status);
        }
        public Task<List<MailMessage>> FindAllAsync()
        {
            return Repository.FindAllAsync();
        }
    }
}
