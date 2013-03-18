using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

            PutMemesInDb(session);
        }

        private static void PutMemesInDb(IDocumentSession session)
        {
            // TODO add hashtags
            if (!session.Query<Meme>().Any(x => x.Id.Equals("Crazy Girl")))
            {
                Meme crazyGirl = new Meme()
                    {
                        Id = "CrazyGirl",
                        DisplayName = "CrazyGirl",
                        PhotoName = "CrazyGirl.jpg",
                        HashTag = "#MemeBattlesCrazyGirl"
                    };
                session.Store(crazyGirl);
            }

            if (!session.Query<Meme>().Any(x => x.Id.Equals("Cyclist Cat")))
            {
                Meme cyclistCat = new Meme()
                    {
                        Id = "CyclistCat",
                        DisplayName = "Cyclist Cat",
                        PhotoName = "CyclistCat.jpg",
                        HashTag = "#MemeBattlesCyclistCat"
                    };
                session.Store(cyclistCat);
            }

            //session.Advanced.DocumentStore.DatabaseCommands.Delete("Memes/Elyse");
            if (!session.Query<Meme>().Any(x => x.Id.Equals("Elyse")))
            {
                Meme elyse = new Meme()
                    {
                        Id = "Elyse",
                        DisplayName = "Elyse",
                        PhotoName = "ElyseQuit.jpg",
                        HashTag = "#MemeBattlesElyse"
                    };
                session.Store(elyse);
            }

            if (!session.Query<Meme>().Any(x => x.Id.Equals("Hitler Cat")))
            {
                Meme hitlerCat = new Meme()
                    {
                        Id = "HitlerCat",
                        DisplayName = "Hilter Cat",
                        PhotoName = "HitlerCat.jpg",
                        HashTag = "#MemeBattlesHitlerCat"
                    };
                session.Store(hitlerCat);
            }

            if (!session.Query<Meme>().Any(x => x.Id.Equals("Honey Badger")))
            {
                Meme honeyBadger = new Meme()
                    {
                        Id = "HoneyBadger",
                        DisplayName = "Honey Badger",
                        PhotoName = "HoneyBadger.gif",
                        HashTag = "#MemeBattlesHoneyBadger"
                    };
                session.Store(honeyBadger);
            }

            if (!session.Query<Meme>().Any(x => x.Id.Equals("Lime Cat")))
            {
                Meme limeCat = new Meme()
                    {
                        Id = "LimeCat",
                        DisplayName = "Lime Cat",
                        PhotoName = "LimeCat.jpg",
                        HashTag = "#MemeBattlesLimeCat"
                    };
                session.Store(limeCat);
            }

            if (!session.Query<Meme>().Any(x => x.Id.Equals("Lulz Sec")))
            {
                Meme lulzSec = new Meme()
                    {
                        Id = "LulzSec",
                        DisplayName = "Lulz Sec",
                        PhotoName = "LulzSec.jpg",
                        HashTag = "#MemeBattlesLulzSec"
                    };
                session.Store(lulzSec);
            }

            session.SaveChanges();
        }
    }
}