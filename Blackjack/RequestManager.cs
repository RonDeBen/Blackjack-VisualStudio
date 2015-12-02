using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace Blackjack
{
    public class Card
    {
        public string rank { get; set; }
        public string suit { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string name { get; set;  }
        public int funds { get; set; }
    }

    public class Room
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class RootObject{
        public Card card { get; set; }
        public User user { get; set; }
        public List<Room> rooms { get; set; }
    }

    public static class RequestManager
    {
        private static string url = "http://blackjack-csc-660.herokuapp.com";

        public static RootObject SignIn(string email, string password)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                try
                {
                    string HtmlResult = wc.UploadString(url + "/users/sign_in.json",
                        "email=" + email + "&" +
                        "password=" + password + "&");
                    return JsonConvert.DeserializeObject<RootObject>(HtmlResult);
                }
                catch
                {
                    return null;//I should display a message box saying 
                }
            }
        }

        public static RootObject RegisterUser(string email, string name, string password, string funds)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(url + "/users.json",
                    "email=" + email + "&" +
                    "name=" + name + "&" +
                    "password=" + password + "&" +
                    "funds=" + funds);
                return JsonConvert.DeserializeObject<RootObject>(HtmlResult); 
            }
        }

        public static RootObject GetRooms()
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(url + "/rooms.json");
                return JsonConvert.DeserializeObject<RootObject>(json);
            }
        }

        public static Card GetCard(int room_id)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(url + "/room/" + room_id + "/top_card.json");
                return JsonConvert.DeserializeObject<RootObject>(json).card;
            }
        }

        public static User UpdateFunds(int user_id, int bet_result)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(url + "/users/" + user_id + "/update_funds.json",
                    "bet_result=" + bet_result);
                return JsonConvert.DeserializeObject<RootObject>(HtmlResult).user;
            }
        }

    }
}
