﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MemeBattle.Models;
using Raven.Client;

namespace MemeBattle.Controllers
{
    public class MemeApiController : ApiController
    {
        private IDocumentSession session;
        public MemeApiController(IDocumentSession session)
        {
            this.session = session;
        }

        public List<Meme> GetTwoRandom()
        {
            List<Meme> memes = session.Query<Meme>()
                .Customize(x => x.RandomOrdering())
                .Take(2).ToList();
            return memes;
        }

        public List<Meme> GetAll()
        {
            List<Meme> memes = new List<Meme>();
            memes = session.Query<Meme>().ToList();
            return memes;
        }

        public bool Vote(string memeDisplayName)
        {
            // RavenDB no need to prevent SQLi
            Meme meme = session.Query<Meme>().SingleOrDefault(x => x.DisplayName.Equals(memeDisplayName));
            meme.Votes++;
            session.SaveChanges();
            return true;
        }

        public List<Tweet> TwitterFake(string q)
        {
            var tweets = new List<Tweet>();

            tweets.Add(new Tweet
                {
                    results = new Results
                        {
                            from_user  = "User1",
                            text = "Tweet Text"
                        }
                });

            tweets.Add(new Tweet
            {
                results = new Results
                {
                    from_user = "User2",
                    text = "Tweet Text"
                }
            });

            return tweets;
        }
    }
}