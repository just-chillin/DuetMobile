using System;
using Xamarin.Essentials;
using Newtonsoft.Json;
namespace DuetMobile.Models
{
    public class AccountData
    {
        public Survey Survey;
        public string YearOfBirth;
        public string Gender;
        public string FirstName;
        public string LastName;
        public static AccountData AccountDataThatExistsAllTheTime = new AccountData();
        private AccountData() { }

        const string LOCAL_STORAGE_KEY = "AccountData";

        public static AccountData RetreiveLocalData()
        {
            var json = Preferences.Get(LOCAL_STORAGE_KEY, null);
            return JsonConvert.DeserializeObject<AccountData>(json);
        }

        public static bool Exists()
        {
            return RetreiveLocalData() != null;
        }

        public void SignUp()
        {
            var jsonAccountData = JsonSeralize();
        }

        public void SaveLocally()
        {
            var json = JsonSeralize();
            Preferences.Set(LOCAL_STORAGE_KEY, json);
        }

        public string JsonSeralize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
