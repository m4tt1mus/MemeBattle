using MemeBattle.Controllers;
using MemeBattle.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeBattle.Tests
{
    [TestFixture]
    public class MemeApiControllerTests
    {
        [Test]
        public void Add_AddNewMeme_NoException()
        {
            MemeApiController memeApi = new MemeApiController();
            Meme meme = new Meme()
            {
                Name = "TestMeme",
                PhotoName = "TestMeme.jpg"
            };

            memeApi.Add(meme);
        }

        [Test]
        public void GetAll_WantAllMemes_ReturnsAllMemes()
        {
            MemeApiController memeApi = new MemeApiController();

            List<Meme> memes = memeApi.GetAll();
        }
    }
}
