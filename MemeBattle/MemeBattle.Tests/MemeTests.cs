using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Unit_Scenario_ExpectedBehavior()
        {
            // GetAvailablePlayableMeme
            var memeRepositoryMock = new Mock<IMemeRepository>();
            var memeRepository = memeRepositoryMock.Object;

            List<Meme> memes = memeRepository.GetPlayableMemes();



        }
    }

    public class Meme
    {
        public string Name;
        public string PhotoName;
        public List<IAttackBehavior> Attacks;

    }

    public interface IMemeRepository
    {

        List<Meme> GetPlayableMemes();
    }

    public interface IAttackBehavior
    {
        public void Attack(Meme target);
    }
}
