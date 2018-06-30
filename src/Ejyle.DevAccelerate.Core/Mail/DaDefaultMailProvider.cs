﻿// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System.Net.Mail;
using System.Threading.Tasks;

namespace Ejyle.DevAccelerate.Core.Mail
{
    /// <summary>
    /// Represents the default mail provider implementation for sending mails.
    /// </summary>
    public class DaDefaultMailProvider : DaMailProviderBase
    {
        /// <summary>
        /// Creates an instance of the <see cref="DaDefaultMailProvider"/> class.
        /// </summary>
        public DaDefaultMailProvider() : base()
        { }

        /// <summary>
        /// Sends a mail.
        /// </summary>
        /// <param name="message">The mail message object.</param>
        public override void Send(MailMessage mail)
        {
            var smtpClient = new SmtpClient(this.SmtpServer.Host);

            smtpClient.Port = (int)SmtpServer.Port;
            smtpClient.Credentials = new System.Net.NetworkCredential(SmtpServer.UserId, SmtpServer.Password);
            smtpClient.EnableSsl = SmtpServer.UseSsl;

            smtpClient.Send(mail);
        }

        /// <summary>
        /// Sends a mail.
        /// </summary>
        /// <param name="to">The recipient of the mail.</param>
        /// <param name="from">The sender of the mail.</param>
        /// <param name="subject">The subject of the mail</param>
        /// <param name="body">The body of the mail message.</param>
        public override void Send(string to, string from, string subject, string body)
        {
            var message = new MailMessage()
            {
                From = new MailAddress(from),
                Subject = subject,
                Body = body
            };

            Send(message);
        }

        /// <summary>
        /// Asynchronously sends a mail.
        /// </summary>
        /// <param name="message">The mail message object.</param>
        /// <returns>A task that represents the asynchronous save operation.</returns>
        public override Task SendAsync(MailMessage message)
        {
            var smtpClient = new SmtpClient(SmtpServer.Host);

            smtpClient.Port = (int)SmtpServer.Port;
            smtpClient.Credentials = new System.Net.NetworkCredential(SmtpServer.UserId, SmtpServer.Password);
            smtpClient.EnableSsl = SmtpServer.UseSsl;

            return smtpClient.SendMailAsync(message);
        }

        /// <summary>
        /// Asynchronously sends a mail.
        /// </summary>
        /// <param name="to">The recipient of the mail.</param>
        /// <param name="from">The sender of the mail.</param>
        /// <param name="subject">The subject of the mail</param>
        /// <param name="body">The body of the mail message.</param>
        /// <returns>A task that represents the asynchronous save operation.</returns>
        public override Task SendAsync(string to, string from, string subject, string body)
        {
            var message = new MailMessage()
            {
                From = new MailAddress(from),
                Subject = subject,
                Body = body
            };

            return SendAsync(message);
        }
    }
}
