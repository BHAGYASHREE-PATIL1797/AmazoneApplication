using System;

namespace TesterApp
{
    internal class AccountHandler
    {
        private Action setIncomeTaxEnquiry;

        public AccountHandler(Action setIncomeTaxEnquiry)
        {
            this.setIncomeTaxEnquiry = setIncomeTaxEnquiry;
        }
    }
}