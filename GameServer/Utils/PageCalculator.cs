﻿namespace GameServer.Utils
{
    public class PageCalculator
    {
        public static int GetPageEnd(int Page, int PerPage)
        {
            return Page * PerPage;
        }

        public static int GetPageStart(int Page, int PerPage)
        {
            return GetPageEnd(Page, PerPage) - PerPage;
        }

        public static int GetTotalPages(int PerPage, int AmountOfContent)
        {
            if (AmountOfContent <= 0) 
                return 0;
            int result = AmountOfContent / PerPage;
            if (result <= 0)
            {
                return 1;
            }
            return result;
        }
    }
}
