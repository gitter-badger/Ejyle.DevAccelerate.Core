// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ejyle.DevAccelerate.Core.Mail
{
    public interface IMailSubjectParam<TKey, TOptionalKey> : IEntity<TKey, TOptionalKey>
    {
        string Name { get; set; }
        string Value { get; set; }
        TKey MailMessageId { get; set; }
    }
}
