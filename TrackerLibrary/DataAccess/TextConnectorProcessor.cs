using Azure.Core.GeoJson;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //PrizeModels.csv
        {
            // C:\Projects\Tournament_Tracker_CET106\PrizeModels.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\ {fileName}";
        }

        public static List<string> LoadFile(this string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new List<string>();
            }

            return File.ReadAllLines(fileName).ToList();
        }

        //--------PRIZE------

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentange = double.Parse(cols[4]);

                output.Add(p);
            }

            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentange}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }



        //--------PERSON-----------------

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id= int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];

                output.Add(p);

            }

            return output;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        //--------TEAM----------------

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            //id,teamName,list of ids separated by the pipe
            //3,Tim's Team,1|3|5

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split("|");

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(t);

            }

            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = string.Empty;

            if (people.Count == 0)
            {
                return string.Empty;
            }

            //2|5|etc..
            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        //----------------TOURNAMENTS-------------------

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamFileName, string peopleFileName, string prizeFileName)
        {
            //id = 0
            //TournamentName = 1
            //EntryFee = 2
            //EnteredTeams = 3
            //Prizes = 4
            //Rounds = 5
            //id,TournamentName,EntryFee,(id|id|id -> Entered Teams),(id|id|id -> Prizes),(Rounds -> id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split("|");

                foreach (string id in teamIds)
                {
                    //t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }


                string[] prizeIds = cols[4].Split('|');

                foreach (string id in prizeIds)
                {
                    //t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }

                //TODO - Capture Rounds Info



                output.Add(tm);

            }

            return output;
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models, string fileName)
        {
            //id = 0
            //TournamentName = 1
            //EntryFee = 2
            //EnteredTeams = 3
            //Prizes = 4
            //Rounds = 5
            //id,TournamentName,EntryFee,(id|id|id -> Entered Teams),(id|id|id -> Prizes),(Rounds -> id^id^id|id^id^id|id^id^id)

            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($@"{tm.Id},{tm.TournamentName},{tm.EntryFee},{ConvertTeamListToString(tm.EnteredTeams)},
                             {ConvertPrizeListToString(tm.Prizes)},{ConvertRoundListToString(tm.Rounds)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = string.Empty;

            if (teams.Count == 0)
            {
                return string.Empty;
            }

            //2|5|etc..
            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = string.Empty;

            if (prizes.Count == 0)
            {
                return string.Empty;
            }

            //2|5|etc..
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = string.Empty;

            if (rounds.Count == 0)
            {
                return string.Empty;
            }

            //2|5|etc..
            foreach (<List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupsListToString(r)}|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = string.Empty;

            if (matchups.Count == 0)
            {
                return string.Empty;
            }

            //2|5|etc..
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

    }
}
