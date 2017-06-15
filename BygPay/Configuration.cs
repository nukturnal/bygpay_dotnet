using System;
namespace BygPay
{
    public class Configuration
    {
		public string BaseUrl { get; set; }
		public string ApiKey { get; set; }

		public string DepositMobilePath { get; set; }
		public string DepositStatusOveridePath { get; set; }
		public string DepositStatusPath { get; set; }

		public string WithdrawMobilePath { get; set; }
		public string WithdrawStatusOveridePath { get; set; }
		public string WithdrawStatusPath { get; set; }

        public const string SDK_VERSION = "0.0.1";

        public Configuration(string BaseUrl, string ApiKey)
        {
            this.BaseUrl = BaseUrl;
            this.ApiKey = ApiKey;

            DepositMobilePath = "/deposits/mobile";
            DepositStatusOveridePath = "/deposits/status-overide";
            DepositStatusPath = "/deposits";

            WithdrawMobilePath = "/withdrawals/mobile";
            WithdrawStatusOveridePath = "/withdrawals/status-overide";
            WithdrawStatusPath = "/withdrawals";
        }

        public string GetDepositMobilePath(){
            return BaseUrl + DepositMobilePath;
        }

		public string GetDepositStatusOveridePath()
		{
			return BaseUrl + DepositStatusOveridePath;
		}

		public string GetDepositStatusPath()
		{
			return BaseUrl + DepositStatusPath;
		}
    }
}
