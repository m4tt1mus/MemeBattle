using MemeBattle.Controllers;
using MemeBattle.Models;
using Moq;
using NUnit.Framework;
using Raven.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeBattle.Tests.Integration
{
    [TestFixture]
    public class MemeApiControllerTests
    {
        [Test]
        public void GetTwoRandom_INeedTwoRandomMemes_ReturnsTwoMemes()
        {
            //MemeApiController apiController = new MemeApiController();

            //List<Meme> memes = apiController.GetTwoRandom();

            //Assert.AreEqual(2, memes.Count());
        }
    }
}
