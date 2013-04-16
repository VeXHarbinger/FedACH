
namespace FedACH
{



    public class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor();
            processor.LoadAll();



        }
    }
}
            //try
            //{ 
            //    WebClient client = new WebClient();
            //    Stream data = client.OpenRead("http://www.fededirectory.frb.org/fpddir.txt");
            //    StreamReader reader = new StreamReader(data);
            //    string str = "";
            //    str = reader.ReadLine(); 
            //    while( str != null)
            //    {
            //        Console.WriteLine(str);
            //        str = reader.ReadLine();
            //    } 
            //    data.Close();
            //}
            //catch(WebException exp)
            //{
               
            //}




            //int yy;
            ////DownloadString(oPath, out yy);

            //string result = null;
            //int status = 0;
            //HttpWebResponse response = null;
            //try
            //{
            //    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://www.fededirectory.frb.org/FedACHdir.txt");
            //    // augment the request here: headers (Referrer, User-Agent, etc)
            //    //     CookieContainer, Accept, etc.
            //    response = (HttpWebResponse)request.GetResponse();
            //    Encoding responseEncoding = Encoding.GetEncoding(response.CharacterSet);
            //    using (StreamReader sr = new StreamReader(response.GetResponseStream(), responseEncoding))
            //    {
            //        result = sr.ReadToEnd();
            //    }
            //    status = (int)response.StatusCode;
            //}
            //catch (WebException wexc1)
            //{
            //    // any statusCode other than 200 gets caught here
            //    if (wexc1.Status == WebExceptionStatus.ProtocolError)
            //    {
            //        // can also get the description: 
            //        //  ((HttpWebResponse)wexc1.Response).StatusDescription;
            //        status = (int)((HttpWebResponse)wexc1.Response).StatusCode;
            //    }
            //}
            //finally
            //{
            //    if (response != null)
            //        response.Close();
            //}

//        }




     


//    }
//}


   //string oPath = "http://www.fededirectory.frb.org/fpddir.txt";
   //     public string DownloadString(string uri, out int status)
   //     {
   //         string result = null;
   //         status = 0;
   //         HttpWebResponse response = null;
   //         try
   //         {
   //             HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
   //             // augment the request here: headers (Referrer, User-Agent, etc)
   //             //     CookieContainer, Accept, etc.
   //             response = (HttpWebResponse)request.GetResponse();
   //             Encoding responseEncoding = Encoding.GetEncoding(response.CharacterSet);
   //             using (StreamReader sr = new StreamReader(response.GetResponseStream(), responseEncoding))
   //             {
   //                 result = sr.ReadToEnd();
   //             }
   //             status = (int)response.StatusCode;
   //         }
   //         catch (WebException wexc1)
   //         {
   //             // any statusCode other than 200 gets caught here
   //             if (wexc1.Status == WebExceptionStatus.ProtocolError)
   //             {
   //                 // can also get the description: 
   //                 //  ((HttpWebResponse)wexc1.Response).StatusDescription;
   //                 status = (int)((HttpWebResponse)wexc1.Response).StatusCode;
   //             }
   //         }
   //         finally
   //         {
   //             if (response != null)
   //                 response.Close();
   //         }
   //         return result;
   //     }

//class Program2
//{
//    string oPath = "http://www.fededirectory.frb.org/fpddir.txt";
//    static void Main(string[] args)
//    {

//        HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("http://www.fededirectory.frb.org/fpddir.txt");

//        httpRequest.Timeout = 10000;     // 10 secs
//        httpRequest.UserAgent = "Code Sample Web Client";

//        HttpWebResponse webResponse = (HttpWebResponse)httpRequest.GetResponse();
//        StreamReader responseStream = new StreamReader(webResponse.GetResponseStream());


//        string content = responseStream.ReadToEnd();



//    }
//}



//using (StreamReader sr = new StreamReader("http://www.fededirectory.frb.org/fpddir.txt"))
//{
//    while (sr.Peek() >= 0)
//    {
//        Console.WriteLine(sr.ReadLine());
//    }
//}


//int counter = 0;
//string line;

//// Read the file and display it line by line.
//System.IO.StreamReader file = new System.IO.StreamReader("http://www.fededirectory.frb.org/fpddir.txt");
//while ((line = file.ReadLine()) != null)
//{
//    Console.WriteLine(line);
//    counter++;
//}

//file.Close();

//// Suspend the screen.
//Console.ReadLine();