using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace League_of_Legends_Lookup.src
{
    class SummonerLookup
    {
        //SummonerNameGetter to get the ID of the summoner
        SummonerNameGetter sng;

        //API Key
        private const string APIKEY = "5801fdc4-315f-4435-abe8-c5ba62ff0993";

        //API url
        private string url = "";

        //ID used to lookup the sommoner
        string summonerID;

        //String values to pass to the api
        string region;
        string summonerName;

        //Default constructor
        public SummonerLookup()
        {
            //Give default values
            region = "";
            summonerName = "";
        }

        //Constructor to assign the values
        public SummonerLookup(string region, string summonerName)
        {
            //Assign values
            this.region = region;
            this.summonerName = summonerName;

            //Create SummonerNameGetter object so we can get the ID of the summoner
            sng = new SummonerNameGetter(region, summonerName);

            //Assign the summoner id
            summonerID = sng.getID();

            //Build the url
            url = "https://na.api.pvp.net/api/lol/" + region + "/v1.3/game/by-summoner/" + summonerID + "/recent?api_key=" + APIKEY;

            //Send the request
            string response = GET(url);
            Console.WriteLine(response);

            //ToDo Parse the response and write it to a window
        }



        //Get the response
        string GET(string url)
        {
            //Create web request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                //Try to get a response
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    string errorText = reader.ReadToEnd();
                    // log errorText
                }
                throw;
            }
        }
    }
}
