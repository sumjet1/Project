using ReadFileToDB;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileToDB
{
    class Program
    {
        static void Main(string[] args)
        {
        //    ReadFile red = new ReadFile();

        //    List<SubscriberContact> files = red.ReturnFiles();

            FormatContact change = new FormatContact();

           List<Format> replace = change.getFile();


            foreach (var item in replace)
            {
                Console.WriteLine(item.FirstNameFormat + "/ "+ item.LastNameFormat+"/"+item.Add1Format+"/"+item.Add2Format+"/"+ item.CityFormat+"/"+item.StateFormat+"/"+item.ZipcodeFormat+"/"+item.PhoneNumberFormat);
            }
            Console.ReadLine();
        }

    }

    
       



        //return output;



    

        
    public static class States
    {
        public static Dictionary<string, string> GetStatesKeyValues()
        {

            Dictionary<string, string> states = new Dictionary<string, string>();
  
            states.Add("AL", "Alabama");states.Add("AK", "Alaska");states.Add("AZ", "Arizona");states.Add("AR", "Arkansas");states.Add("CA", "California");
            states.Add("CO", "Colorado");states.Add("CT", "Connecticut");states.Add("DE", "Delaware");states.Add("DC", "District of Columbia");states.Add("FL", "Florida");
            states.Add("GA", "Georgia");states.Add("HI", "Hawaii");states.Add("ID", "Idaho");states.Add("IL", "Illinois");states.Add("IN", "Indiana");states.Add("IA", "Iowa");
            states.Add("KS", "Kansas");states.Add("KY", "Kentucky");states.Add("LA", "Louisiana");states.Add("ME", "Maine");states.Add("MD", "Maryland");states.Add("MA", "Massachusetts");
            states.Add("MI", "Michigan");states.Add("MN", "Minnesota");states.Add("MS", "Mississippi");states.Add("MO", "Missouri");states.Add("MT", "Montana");states.Add("NE", "Nebraska");
            states.Add("NV", "Nevada");states.Add("NH", "New Hampshire");states.Add("NJ", "New Jersey");states.Add("NM", "New Mexico");states.Add("NY", "New York");states.Add("NC", "North Carolina");
            states.Add("ND", "North Dakota");states.Add("OH", "Ohio");states.Add("OK", "Oklahoma");states.Add("OR", "Oregon");states.Add("PA", "Pennsylvania");states.Add("RI", "Rhode Island");
            states.Add("SC", "South Carolina");states.Add("SD", "South Dakota");states.Add("TN", "Tennessee");states.Add("TX", "Texas");states.Add("UT", "Utah");states.Add("VT", "Vermont");
            states.Add("VA", "Virginia");states.Add("WA", "Washington");states.Add("WV", "West Virginia");states.Add("WI", "Wisconsin");states.Add("WY", "Wyoming");

            return states;

        }
    }




    public class SubscriberContact
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

    }

    public class Format
    {
        public string FirstNameFormat { get; set; }

        public string LastNameFormat { get; set; }

        public string Add1Format { get; set; }

        public string Add2Format { get; set; }

        public string CityFormat { get; set; }

        public string StateFormat { get; set; }

        public string ZipcodeFormat { get; set; }

        public string PhoneNumberFormat { get; set; }
    }
}

      
    

