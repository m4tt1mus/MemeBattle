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
    public static class SetupDb
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
            Meme crazyGirl = new Meme()
                {
                    DisplayName = "CrazyGirl",
                    PhotoName = "CrazyGirl.jpg",
                    HashTag = "#MemeBattlesCrazyGirl"
                };
            session.Store(crazyGirl);

            Meme cyclistCat = new Meme()
                {
                    DisplayName = "Cyclist Cat",
                    PhotoName = "CyclistCat.jpg",
                    HashTag = "#MemeBattlesCyclistCat"
                };
            session.Store(cyclistCat);

            Meme elyse = new Meme()
            {
                DisplayName = "Elyse",
                PhotoName = "ElyseQuit.jpg",
                HashTag = "#MemeBattlesElyse"
            };
            session.Store(elyse);


            Meme hitlerCat = new Meme()
                {
                    DisplayName = "Hilter Cat",
                    PhotoName = "HitlerCat.jpg",
                    HashTag = "#MemeBattlesHitlerCat"
                };
            session.Store(hitlerCat);

            Meme honeyBadger = new Meme()
                {
                    DisplayName = "Honey Badger",
                    PhotoName = "HoneyBadger.gif",
                    HashTag = "#MemeBattlesHoneyBadger"
                };
            session.Store(honeyBadger);

            Meme limeCat = new Meme()
                {
                    DisplayName = "Lime Cat",
                    PhotoName = "LimeCat.jpg",
                    HashTag = "#MemeBattlesLimeCat"
                };
            session.Store(limeCat);

            Meme lulzSec = new Meme()
                {
                    DisplayName = "Lulz Sec",
                    PhotoName = "LulzSec.jpg",
                    HashTag = "#MemeBattlesLulzSec"
                };
            session.Store(lulzSec);

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