namespace SevenH.MMCSB.Atm.Web
{
    public static class ATMHelper
    {
        public static bool MyKadValidation(string mykadno)
        {
            if (mykadno.Contains("-"))
            {
                // check validity of first 6 digit
            }
            else
            {
                if (mykadno.Length > 12)
                    return false;
                if (mykadno.Length < 12)
                    return false;
                if (mykadno.Length == 12)
                {
                    // check first 6 is valid date
                }
            }
            return false;
        }
    }
}