﻿using DansBlog.Services.Email;
using DansBlog.Services.Email.Model;
using Moq;
using NUnit.Framework;

namespace DansBlog.UnitTests.Services.Email
{
    [TestFixture]
    public class Emailer_Should
    {
        [Test]
        public void Message_SetSMTPClientWithTheCorrectSmtpServerValue()
        {
            var emailSettings = new EmailSettings("smtpServer", "targetEmail");

            

            //var sut = new Emailer(settings);
        }
    }
}
