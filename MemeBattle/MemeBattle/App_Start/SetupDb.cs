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
            if (!session.Query<Meme>().Any(x => x.Name.Equals("Crazy Girl")))
            {
                Meme crazyGirl = new Meme()
                    {
                        Name = "Crazy Girl",
                        PhotoName = "CrazyGirl.jpg"
                    };
                session.Store(crazyGirl);
            }

            if (!session.Query<Meme>().Any(x => x.Name.Equals("Cyclist Cat")))
            {
                Meme cyclistCat = new Meme()
                    {
                        Name = "Cyclist Cat",
                        PhotoName = "CyclistCat.jpg"
                    };
                session.Store(cyclistCat);
            }

            if (!session.Query<Meme>().Any(x => x.Name.Equals("Elyse")))
            {
                Meme elyse = new Meme()
                    {
                        Name = "Elyse",
                        PhotoName = "ElyseQuit.jpg"
                    };
                session.Store(elyse);
            }

            if (!session.Query<Meme>().Any(x => x.Name.Equals("Hitler Cat")))
            {
                Meme hitlerCat = new Meme()
                    {
                        Name = "Hitler Cat",
                        PhotoName = "HitlerCat.jpg"
                    };
                session.Store(hitlerCat);
            }

            if (!session.Query<Meme>().Any(x => x.Name.Equals("Honey Badger")))
            {
                Meme honeyBadger = new Meme()
                    {
                        Name = "Honey Badger",
                        PhotoName = "HoneyBadger.gif"
                    };
                session.Store(honeyBadger);
            }

            if (!session.Query<Meme>().Any(x => x.Name.Equals("Lime Cat")))
            {
                Meme limeCat = new Meme()
                    {
                        Name = "Lime Cat",
                        PhotoName = "LimeCat.jpg"
                    };
                session.Store(limeCat);
            }

            if (!session.Query<Meme>().Any(x => x.Name.Equals("Lulz Sec")))
            {
                Meme lulzSec = new Meme()
                    {
                        Name = "Lulz Sec",
                        PhotoName = "LulzSec.jpg"
                    };
                session.Store(lulzSec);
            }

            session.SaveChanges();
        }
    }
}