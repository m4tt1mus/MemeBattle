using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemeBattle.Controllers;
using Raven.Client;
using MemeBattle.Models;

namespace MemeBattle.App_Start
{
    public static class SetupRavenDb
    {
        public static void Initialize()
        {
            // TODO this is an anti-pattern, fix it later
            IDocumentSession session = DependencyResolver.Current.GetService<IDocumentSession>();
            DeleteExistingMemes(session);
            PutMemesInDb(session);
        }

        private static void PutMemesInDb(IDocumentSession session)
        {
            // Add default memes
            session.Store(new Meme()
            {
                DisplayName = "Crazy Girl",
                PhotoName = "CrazyGirl.jpg",
                HashTag = "#MemeBattlesCrazyGirl"
            });


            session.Store(new Meme()
            {
                DisplayName = "Cyclist Cat",
                PhotoName = "CyclistCat.jpg",
                HashTag = "#MemeBattlesCyclistCat"
            });

            session.Store(new Meme()
            {
                DisplayName = "Elyse",
                PhotoName = "ElyseQuit.jpg",
                HashTag = "#MemeBattlesElyse"
            });

            session.Store(new Meme()
            {
                DisplayName = "Hilter Cat",
                PhotoName = "HitlerCat.jpg",
                HashTag = "#MemeBattlesHitlerCat"
            });

            session.Store(new Meme()
            {
                DisplayName = "Honey Badger",
                PhotoName = "HoneyBadger.gif",
                HashTag = "#MemeBattlesHoneyBadger"
            });

            session.Store(new Meme()
            {
                DisplayName = "Lime Cat",
                PhotoName = "LimeCat.jpg",
                HashTag = "#MemeBattlesLimeCat"
            });

            session.Store(new Meme()
            {
                DisplayName = "Lulz Sec",
                PhotoName = "LulzSec.jpg",
                HashTag = "#MemeBattlesLulzSec"
            });

            session.Store(new Meme()
            {
                DisplayName = "Nyan Cat",
                PhotoName = "NyanCat.jpg",
                HashTag = "#MemeBattlesNyanCat"
            });

            session.Store(new Meme()
            {
                DisplayName = "OMG Cat",
                PhotoName = "OmgCat.jpg",
                HashTag = "#MemeBattlesOmgCat"
            });

            session.Store(new Meme()
            {
                DisplayName = "Pancake Bunny",
                PhotoName = "PancakeBunny.jpg",
                HashTag = "#MemeBattlesPancakeBunny"
            });

            session.Store(new Meme()
            {
                DisplayName = "Sad Keano",
                PhotoName = "SadKeano.jpg",
                HashTag = "#MemeBattlesSadKeano"
            });

            session.Store(new Meme()
            {
                DisplayName = "Tard Cat",
                PhotoName = "TardCat.jpg",
                HashTag = "#MemeBattlesTardCat"
            });

            session.SaveChanges();
        }

        private static void DeleteExistingMemes(IDocumentSession session)
        {
            MemeApiController c = new MemeApiController(session);
            List<Meme> memes = c.GetAll();
            foreach (var meme in memes)
            {
                string id = session.Advanced.GetDocumentId(meme);
                session.Advanced.DocumentStore.DatabaseCommands.Delete(id, null);
            }
            session.SaveChanges();
        }
    }
}