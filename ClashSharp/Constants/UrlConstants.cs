﻿namespace ClashSharp.Constants
{
    public static class UrlConstants
    {
        // may need to have a better way to deal with versioning of URLs if supercell ever updates the API.

        public const string GetClanInformationUrlTemplate = @"https://api.clashofclans.com/v1/clans/{0}";
        public const string ListClanMembersUrlTemplate = @"https://api.clashofclans.com/v1/clans/{0}/members";
        public const string SearchClansUrlTemplate = @"https://api.clashofclans.com/v1/clans{0}";
        public const string RetrieveInformationAboutClansCurrentWarUrlTemplate = @"https://api.clashofclans.com/v1/clans/{0}/currentwar";

        public const string ListLocationsUrlTemplate = @"https://api.clashofclans.com/v1/locations";
        public const string GetLocationInformationUrlTemplate = @"https://api.clashofclans.com/v1/locations/{0}";
        public const string GetClanRankForLocationUrlTemplate = @"https://api.clashofclans.com/v1/locations/{0}/rankings/clans";
        public const string GetPlayerRankForLocationUrlTemplate = @"https://api.clashofclans.com/v1/locations/{0}/rankings/players";

        public const string ListLeagueUrlTemplate = @"https://api.clashofclans.com/v1/leagues";

        public const string GetPlayerInformationUrlTemplate = @"https://api.clashofclans.com/v1/players/{0}";
    }
}
