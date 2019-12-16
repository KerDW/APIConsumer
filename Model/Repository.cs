using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using static Model.Model1;

namespace Model
{
    public class Repository
    {
        public Repository(){

        }

        private static string ws1 = "https://localhost:44330/api/";

        public static List<Magatzem> GetMagatzems()
        {
            List<Magatzem> m = (List<Magatzem>) MakeRequest(string.Concat(ws1, "magatzems/"), null, "GET", "application/json", typeof(List<Magatzem>));
            
            return m;
        }

        public static List<VProdMag> GetMagatzemStock(int idMagatzem)
        {
            List<VProdMag> vpm = (List<VProdMag>)MakeRequest(string.Concat(ws1, "stockMagatzem/" + idMagatzem), null, "GET", "application/json", typeof(List<VProdMag>));

            return vpm;
        }

        public static void moveStock(int receiver_id, int sender_id, int prod_id, int qty)
        {
            JObject jsonObject = new JObject
            {
                ["idProd"] = prod_id,
                ["idMag"] = receiver_id,
                ["qnt"] = qty
            };

            MakeRequest(string.Concat(ws1, "movestock/", sender_id), jsonObject, "PUT", "application/json", typeof(ProdMag));

        }



        public static object MakeRequest(string requestUrl, object JSONRequest, string JSONmethod, string JSONContentType, Type JSONResponseType)
        //  requestUrl: Url completa del Web Service, amb l'opció sol·licitada
        //  JSONrequest: objecte que se li passa en el body (només per a POST/PUT)
        //  JSONmethod: "GET"/"POST"/"PUT"/"DELETE"
        //  JSONContentType: "application/json" en els casos que el Web Service torni objectes
        //  JSONRensponseType:  tipus d'objecte que torna el Web Service (typeof(tipus))
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest; //WebRequest WR = WebRequest.Create(requestUrl);   
                string sb = JsonConvert.SerializeObject(JSONRequest);
                request.Method = JSONmethod;  // "GET"/"POST"/"PUT"/"DELETE";  

                if (JSONmethod != "GET")
                {
                    request.ContentType = JSONContentType; // "application/json";   
                    Byte[] bt = Encoding.UTF8.GetBytes(sb);
                    Stream st = request.GetRequestStream();
                    st.Write(bt, 0, bt.Length);
                    st.Close();
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));

                    Stream stream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream1);
                    string strsb = sr.ReadToEnd();
                    object objResponse = JsonConvert.DeserializeObject(strsb, JSONResponseType);
                    return objResponse;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
