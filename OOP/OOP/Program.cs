using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IndividualPerson person = new IndividualPerson();
            //person.Id = 1;
            //person.CustomerNumber = "123";
            //person.FirtsName = "Engin";
            //person.LastName = "Demiroğ";

            //CorporatePerson person1 = new CorporatePerson();    
            //person1.Id = 2;
            //person1.CustomerNumber = "1234";
            //person1.CompanyName = "Kodlama.io";
            //person1.AssessmentNumber = "123456789";

            //Person person2 = new CorporatePerson();
            //Person person3 = new IndividualPerson();

            //PersonManager personManager = new PersonManager();
            //personManager.Add(person2);

            ICreditManager bdfManager = new BDFManager();
            ICreditManager vehicleManager = new VehicleManager();   
            ICreditManager mortgageManager = new MortgageManager();

            ApplicationManager appManager = new ApplicationManager();
            appManager.Application(bdfManager, new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>();
            credits.Add(bdfManager);    
            credits.Add(vehicleManager);    
            appManager.CreditPreInformation(credits);

            


        }
    }
}
