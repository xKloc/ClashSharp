﻿using ClashSharp.Data;
using ClashSharp.Service;
using System;
using System.Threading.Tasks;

namespace ClashSharp.Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // uncomment a call to run the sample

            //CallGetClanInformation();
            //CallListClanMembers();
            //CallSearchClans();
            //CallListLocatio();
            //CallGetLocationInformation();
            //CallGetClanRankForLocation();
            //CallGetPlayerRankForLocation();
            //CallListLeagues();
            //CallGetPlayerInformation().Wait();
            CallRetreiveInformationAboutClansCurrentWar();

            Console.ReadLine();
        }

        private static async Task<bool> CallGetClanInformation()
        {
            var svc = new ClanService();
            var task = svc.GetClanInformation("#YP9U0J");

            await Task.WhenAll(task);

            var result = task.Result;

            Console.WriteLine(result.Name);
            Console.WriteLine(result.Description);

            Console.WriteLine("Done...");

            return true;
        }

        private static async Task<bool> CallListClanMembers()
        {
            var svc = new ClanService();
            var task = svc.ListClanMembers("#YP9U0J");

            await Task.WhenAll(task);

            Console.WriteLine("Done...");

            return true;
        }

        private static async Task<bool> CallSearchClans()
        {
            var svc = new ClanService();
            var task = svc.SearchClans(new ClanSearchCriteria
            {
                Name = "U.S.A"
            });

            await Task.WhenAll(task);

            Console.WriteLine("Done...");

            return true;
        }

        private static async Task<bool> CallListLocations()
        {
            var svc = new LocationService();
            var task = svc.ListLocations();

            await Task.WhenAll(task);

            Console.WriteLine("Done...");

            return true;
        }

        private static async Task<bool> CallGetLocationInformation()
        {
            var svc = new LocationService();
            var task = svc.GetLocationInformation(32000249);

            await Task.WhenAll(task);

            Console.WriteLine("Done...");

            return true;
        }

        private static async Task<bool> CallGetClanRankForLocation()
        {
            var svc = new LocationService();
            var task = svc.GetClanRankForLocation(32000249);

            await Task.WhenAll(task);

            Console.WriteLine("Done...");

            return true;
        }

        private static async Task<bool> CallGetPlayerRankForLocation()
        {
            var svc = new LocationService();
            var task = svc.GetPlayerRankForLocation(32000249);

            await Task.WhenAll(task);

            Console.WriteLine("Done...");

            return true;
        }

        private static async Task<bool> CallListLeagues()
        {
            var svc = new LeagueService();
            var task = svc.ListLeagues();

            await Task.WhenAll(task);

            Console.WriteLine("Done...");

            return true;
        }

        private static async Task<bool> CallGetPlayerInformation()
        {
            var svc = new PlayerService();
            var task = svc.GetPlayerInformation("#2YVJYPGQ9");

            await Task.WhenAll(task);

            var result = task.Result;

            Console.WriteLine(result.Name);
            Console.WriteLine(result.Clan.Name);

            Console.WriteLine("Done...");

            return true;
        }

        private static async Task<bool> CallRetreiveInformationAboutClansCurrentWar()
        {
            var svc = new ClanService();
            var task = svc.RetrieveInformationAboutClansCurrentWar("#88GYPPRQ");

            await Task.WhenAll(task);

            var result = task.Result;

            Console.WriteLine($"{result.Clan.Name} V. {result.Opponent.Name}");
            Console.WriteLine("Done...");

            return true;
        }
    }
}
