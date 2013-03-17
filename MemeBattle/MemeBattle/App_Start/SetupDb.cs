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

            // Setup default Memes
            Meme crazyGirl = new Meme()
                {
                    Name = "Crazy Girl",
                    PhotoName = "CrazyGirl.jpg"
                };
            session.Store(crazyGirl);

            Meme cyclistCat = new Meme()
                {
                    Name = "Cyclist Cat",
                    PhotoName = "CyclistCat.jpg"
                };
            session.Store(cyclistCat);

            Meme elyse = new Meme()
                {
                    Name = "Elyse",
                    PhotoName = "ElyseQuit.jpg"
                };
            session.Store(elyse);

            Meme hitlerCat = new Meme()
                {
                    Name = "Hitler Cat",
                    PhotoName = "HitlerCat.jpg"
                };
            session.Store(hitlerCat);

            Meme honeyBadger = new Meme()
                {
                    Name = "Honey Badger",
                    PhotoName = "HoneyBadger.gif"
                };
            session.Store(honeyBadger);

            Meme limeCat = new Meme()
                {
                    Name = "Lime Cat",
                    PhotoName = "LimeCat.jpg"
                };
            session.Store(limeCat);

            Meme lulzSec = new Meme()
                {
                    Name = "Lulz Sec",
                    PhotoName = "LulzSec"
                };
            session.Store(lulzSec);

            session.SaveChanges();
        }
    }
}