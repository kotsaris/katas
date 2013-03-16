using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpKatas.SolitaireKata;
using Xunit;

namespace CSharpKatas.Tests.SolitaireKata
{
    public class SolitaireEncryptorTests
    {
        public void ShouldEncryptAMessageCorrectly()
        {
            var encryptor = new SolitaireEncryptor();
            var message = "Code in Ruby, live longer!";
            var expectedEncryptedMessage = "CODEI NRUBY LIVEL ONGER";

            var actualEncryptedMessage = encryptor.Encrypt(message);

            Assert.Equal(expectedEncryptedMessage, actualEncryptedMessage);
        }
    }

}
