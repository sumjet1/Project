using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileToDB
{
    public class FormatContact
    {
        public List<Format> getFile()

        {

            ReadFile red = new ReadFile();

            List<SubscriberContact> contactFormat = red.ReturnFiles();

            List<Format> newList = new List<Format>();

            TextInfo str = new CultureInfo("en-US", false).TextInfo;
            //SubscriberContact contactFormat = new SubscriberContact();
            // List<SubscriberContact> files1 = contactFormat.ReturnFiles();
            //Format change = new Format();

            //string test = String.Format("{0:(###) ###-####}", 8005551212);

            var states = States.GetStatesKeyValues();

            foreach (var z in contactFormat)
            {
                Format format1 = new Format();

                format1.LastNameFormat = str.ToTitleCase(z.LastName);
                format1.FirstNameFormat = str.ToTitleCase(z.FirstName);
                format1.Add1Format = str.ToTitleCase(z.Address1);
                format1.Add2Format = str.ToTitleCase(z.Address2);
                format1.CityFormat = str.ToTitleCase(z.City);
                format1.StateFormat = str.ToUpper(z.State);
                var phone = z.PhoneNumber;
                format1.PhoneNumberFormat = new string((from c in phone
                                                        where char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)
                                                        select c).ToArray());
                //String.Format("{0:(###) ###-####}", 8005551212)
                //format1.PhoneNumberFormat =string.Format("{0:##########)",z.PhoneNumber);
                //if (format1.PhoneNumberFormat.Length >= 9 & format1.PhoneNumberFormat.Contains("-"))
                //{
                //    var dash = format1.PhoneNumberFormat.Split('-');
                //    format1.PhoneNumberFormat = string.Format("{0}" + "{1}" + "{2}", dash[0], dash[1], dash[2]);

                //    long padding1 = long.Parse(format1.PhoneNumberFormat); //not working because value coming in is string with '-' in it.Need to fix.
                //    string formattedNumber = string.Format("{0:(###)-###-####}", padding1);
                //}

                if (format1.PhoneNumberFormat.Length >= 9)
                {
                    long padding1 = long.Parse(format1.PhoneNumberFormat); //not working because value coming in is string with '-' in it.Need to fix.
                    string formattedNumber = string.Format("{0:(###)-###-####}", padding1);
                    format1.PhoneNumberFormat = formattedNumber;
                }



                if (format1.PhoneNumberFormat.Length <= 8)
                {
                    int padding = Int32.Parse(z.PhoneNumber);
                    string formattedNumber = string.Format("{0:(000)-###-####}", padding);
                    format1.PhoneNumberFormat = formattedNumber;

                    //Int32.Parse(z.PhoneNumber.ToString().PadLeft(10, '0');
                }

                if (!string.IsNullOrEmpty(z.State))
                {
                    if (states.ContainsKey(z.State))
                    {

                        format1.StateFormat = states.Where(obj => obj.Key == z.State).FirstOrDefault().Key;
                    }
                    else
                    {
                        if (states.ContainsValue(z.State))
                        {

                            format1.StateFormat = states.Where(obj => obj.Value == z.State).FirstOrDefault().Key;
                        }
                    }
                }




                //Dictionary<string, string> newList = new Dictionary<string, string>();

                //if (format1.StateFormat != "" || format1.StateFormat != null)
                //{
                //    StateValidator check1 = new StateValidator();
                //    List<Format> run = check1.stateAbbreviationExpand();
                //    // string v = check1.stateAbbreviationExpand.

                ////foreach(var b in run)
                ////    {
                ////        format1.StateFormat = b.stat
                ////    }



                //}
                newList.Add(format1);

            }
            return newList;


        }

    }
}
