using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I am ");
            MyInfo Jim = new MyInfo();
            Jim.MyBirthDay = DateTime.Parse("01/29/1951");
            Console.WriteLine(Jim.MyAge);
        }
    }

    class MyInfo
    {
        public int MyAge
        {
            get 
            { DateTime RightNowNoTime = DateTime.Now.Date;
              int MyYears = RightNowNoTime.Year - MyBirthDay.Year;
              return MyYears;
      //        int months = RightNowNoTime.Month - MyBirthDay.Month;
       //       int dayOfYearIWasBorn = MyBirthDay.DayOfYear;
      //        int currentDayOfYear = RightNowNoTime.DayOfYear;
      //        int DaysPastMyBirthDay = currentDayOfYear - dayOfYearIWasBorn;
      //        bool haveIHadMyBirthday = (DaysPastMyBirthDay < 0);
              

            }
        }

        public DateTime MyBirthDay
        {
            get; set;
        }


    }
}
