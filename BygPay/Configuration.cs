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

        public Configuration()
        {
            DepositMobilePath = "/deposits/mobile";
            DepositStatusOveridePath = "/deposits/status-overide";
            DepositStatusPath = "/deposits";

            WithdrawMobilePath = "/withdrawals/mobile";
            WithdrawStatusOveridePath = "/withdrawals/status-overide";
            WithdrawStatusPath = "/withdrawals";
        }
    }
}
