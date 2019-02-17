using System;
using Newtonsoft.Json;
namespace DuetMobile.Models
{
    public class AccountData
    {
        public string ApiKey;
        public Survey Survey;
        public static AccountData AccountDataThatExistsAllTheTime = new AccountData();
        private AccountData() { }
        public AccountData RetreiveLocalData()
        {
            throw new NotImplementedException();
        }

        public void UpdateServer()
        {

        }

        public void SaveLocally()
        {

        }

        public string JsonSeralize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
