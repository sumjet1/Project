using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileToDB
{
    public class ReadFile
    {
        public List<SubscriberContact> ReturnFiles()
        {
            var path = @"C:\C#\SDS\Read\";
            string[] dirs = Directory.GetFiles(path, "*.csv");

            //   List<string> output = new List<string>();
            List<SubscriberContact> contact = new List<SubscriberContact>();

            foreach (var dir in dirs)
            {
                StreamReader myReader = new StreamReader(File.OpenRead(dir));
                int k = 0;


                while (!myReader.EndOfStream)
                {
                    if (k == 0)
                    {
                        k++;
                        myReader.ReadLine();
                        continue;

                    }



                    var lineReader = myReader.ReadLine();

                    if (lineReader != "")
                    {

                        var read = lineReader.Split(',');
                        if (read != null)
                        {
                            SubscriberContact con = new SubscriberContact
                            {
                                LastName = read[0],
                                FirstName = read[1],
                                Address1 = read[2],
                                Address2 = read[3],
                                City = read[4],
                                State = read[5],
                                ZipCode = read[6],
                                PhoneNumber = read[7],
                            };
                            contact.Add(con);
                        }
                    }




                    // var newline = lineReader.Split('\n');

                    //   for (int i = 0; i < newline.LongLength; i++)
                    //    {

                    //     for (int j = 0; j < read.LongLength; j++)
                    //    {
                    //Console.WriteLine("{0}", read[j]);


                    //      output.Add(read[j]);



                    // }
                }

                k++;
            }

            return contact;


        }
    }
}
