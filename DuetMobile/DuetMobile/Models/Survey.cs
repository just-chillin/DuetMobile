using System;
using Xamarin.Essentials;
using Newtonsoft.Json;
namespace DuetMobile.Models
{
    public class Survey
    {
        public String music;
        public String MoviesAndTV;
        public String Games;
        public String Books;

        public string JsonSeralize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
