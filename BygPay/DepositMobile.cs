using System;
using Newtonsoft.Json;

namespace BygPay
{
    public class DepositMobile : GatewayUtil
    {
        public DepositMobile(Configuration config) : base(config){}

		public bool Charge(float Amount, string WalletNo, string Provider, string PayToken = "")
		{
            MobilePayload payload = new MobilePayload(Amount, WalletNo, Provider, PayToken);

			return false;
		}
    }

    public class MobilePayload
    {
        public string walletno { get; set; }
        public float amount { get; set; }
        public string provider { get; set; }
        public string paytoken { get; set; }

        public MobilePayload(float amount, string walletno, string provider, string paytoken)
        {
            this.amount = amount;
            this.walletno = walletno;
            this.provider = provider;
            this.paytoken = paytoken;
        }
    }
}