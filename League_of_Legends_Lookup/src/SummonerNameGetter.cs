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
    class SummonerNameGetter
    {
        //API key
        private const string APIKEY = "5801fdc4-315f-4435-abe8-c5ba62ff0993";

        //Lookup URL
        private string apiUrl = "";

        //String values to pass to the api
        string region;
        string summonerName;

        //String to hold the Summoner ID values
        string summonerID = "";

        //Default Constructor
        public SummonerNameGetter()
        {

        }

        //Constructor with parameters
        public SummonerNameGetter(string region, string summonerName)
        {
            //Assign values
            this.region = region;
            this.summonerName = summonerName;

            //Build the url
            apiUrl = "https://na.api.pvp.net/api/lol/" + region + "/v1.4/summoner/by-name/" + summonerName + "?api_key=" + APIKEY;

            //Make the call
            string response = GET(apiUrl);

            //Parse the call to get the ID
            summonerID = parseResponse(response);
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

        //Parse the response
        private string parseResponse(string response)
        {
            var obj = JObject.Parse(response);
            string id = (string)obj[summonerName.ToLower()]["id"];

            return id;
        }

        //Getter to return the id
        public string getID()
        {
            return summonerID;
        }
    }
}
