using System;
using System.Collections.Generic;
using EfSamurai.Data;
using EfSamurai.Domain;
using Microsoft.EntityFrameworkCore;

namespace EfSamurai.App
{
    class Program
    {
        static void Main(string[] args)
        {
            AddOneSamurai();
            AddSomeSamurais();
            AddSomeBattles();
            AddOneSamuraiWithRelatedData();

        }

        private static void AddOneSamurai()
        {
            var samurai = new Samurai { Name = "Zelda" };

            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }

        }

        private static void AddSomeSamurais()
        {
            var samurailist = new List<Samurai>();

            samurailist.Add(new Samurai { Name = "Badoo" });
            samurailist.Add(new Samurai { Name = "Lola" });
            samurailist.Add(new Samurai { Name = "Olle" });
            samurailist.Add(new Samurai { Name = "Maloo" });

            using (var context = new SamuraiContext())
            {
                context.Samurais.AddRange(samurailist);
                context.SaveChanges();
            }

        }
        private static void AddSomeBattles()
        {

            var Waar = new List<Battle>();

            var battleA = new Battle()
            {
                Name = "WorldWar",
                Info = "Krig",
                Brutal = (true),
                StartDate = DateTime.Parse("01 / 01 / 1945"),
                EndDate = DateTime.Parse("01 / 01 / 1950"),
                Summary = "Vi vann",
                BattleLog = new BattleLog
                {
                    Name = "LoggA",
                    BattleEventList = new List<BattleEvents>
                    {
                            new BattleEvents {Description = "Tråkigt Krig", Summary = "Avslutades", Time = DateTime.Parse("01 / 01 / 1945")},
                    }

                }

            };

            var battleB = new Battle()
            {
                Name = "WarOne",
                Info = "Kort krig",
                Brutal = (false),
                StartDate = DateTime.Parse("01 / 01 / 1935"),
                EndDate = DateTime.Parse("01 / 07 / 1935"),
                Summary = "Avslutades fort",
                BattleLog = new BattleLog
                {
                    Name = "LoggB",
                    BattleEventList = new List<BattleEvents>
                    {
                        new BattleEvents {Description = "Kort krig", Summary = "Kort", Time = DateTime.Parse("01 / 01 / 1935")},
                    }
                }
            };

            var battleC = new Battle()
            {
                Name = "TimesTwo",
                Info = "Kriget",
                Brutal = (false),
                StartDate = DateTime.Parse("01 / 01 / 1940"),
                EndDate = DateTime.Parse("01 / 01 / 1942"),
                Summary = "Kort",
                BattleLog = new BattleLog
                {
                    Name = "LoggC",
                    BattleEventList = new List<BattleEvents>
                    {
                        new BattleEvents {Description = "Tråkigt och långt", Summary = "Så kan det gå", Time = DateTime.Parse("01 / 01 / 1940")}
                    }
                }
            };

            Waar.Add(battleA);
            Waar.Add(battleB);
            Waar.Add(battleC);

            var context = new SamuraiContext();
            context.AddRange(Waar);
            context.SaveChanges();

        }

        private static void AddOneSamuraiWithRelatedData()
        {
            Samurai Falcon = new Samurai()
            {
                Name = "Falcon",
                Age = 25,
                ListOfQuotes = new List<Quote>
                {
                    new Quote {Name = "Lovin it'", QuoteType = Domain.Type.Awesome }
                }


            };
        }
    }
}

