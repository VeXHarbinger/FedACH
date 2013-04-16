using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace FedACH
{
    public class Processor
    {
        string Filepath = "http://www.fededirectory.frb.org/fpddir.txt";
        string QueryPath = "";
        WebClient client = new WebClient();
        Stream data;

        public Processor() { 
        
        }

        public void LoadAll()
        {
             data = client.OpenRead("http://www.fededirectory.frb.org/fpddir.txt");
             Read();
        }

        public void Load(DateTime StartDate, DateTime EndDate)
        {
        }

        public void Read()
        {
            try
            {
               
                StreamReader reader = new StreamReader(data);
                string str = "";
                str = reader.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    Write(str);
                    str = reader.ReadLine();
                }
                data.Close();
            }
            catch (WebException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        public void Write(String Line) {
            try {

               SqlParameter[] parameter = {
                    new SqlParameter("@RoutingNumber", Line.Substring(0,9)), 
                    new SqlParameter("@OfficeCode", Line.Substring(10,1))
                };
            }
            catch (WebException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}

//SqlParameter parameter = new SqlParameter("@RoutingNumber", Line.Substring(0, 9));