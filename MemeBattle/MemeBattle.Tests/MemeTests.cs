using System.Web.Mvc;
using MemeBattle.Controllers;
using MemeBattle.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raven.Client;

namespace MemeBattle.Tests
{
    [TestFixture]
    public class MemeTests
    {
        /*
         * Select your meme, start at lvl 1, experience is 0, need 100 to level, each battle gives 10
         * Go into the arena, another meme will show up for you to battle
         * You choose your attack - you always attack first - and attack
         *  Your attack 
         * Meme takes damage and retaliates
         */
        // Add Meme to DB
        // Get Memes
        // Meme attack / Reduce meme defense

        [Test]
        public void Index_Always_RedirectsToChooseMeme()
        {
            HomeController c = new HomeController(new Mock<IDocumentSession>().Object);

            RedirectToRouteResult result = c.Index();

            Assert.AreEqual("ChooseMeme", result.RouteValues["action"]);
        }

        [Test]
        public void ChooseMeme_UserHasntSelectedAMeme_ReturnsListOfMemesToChoose()
        {
            HomeController c = new HomeController(new Mock<IDocumentSession>().Object);

            
        }


        // 1) no meme in session, make them choose one
        [Test]
        public void Index_NoMemeInSession_SendUserToSelectAMeme()
        {
            throw new NotImplementedException();
        }

    }
}
