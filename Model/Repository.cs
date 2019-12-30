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

        private static string ws1 = "https://localhost:44311/api/";

        public static contacte GetContacteTot(int id)
        {
            contacte c = (contacte)MakeRequest(string.Concat(ws1, "contacteTot/", id), null, "GET", "application/json", typeof(contacte));
            return c;
        }
        public static List<telefon> GetContactePhones(int id)
        {
            contacte c = (contacte)MakeRequest(string.Concat(ws1, "contacteTot/", id), null, "GET", "application/json", typeof(contacte));

            List<telefon> tels = new List<telefon>();

            if(c != null)
            {
                tels.AddRange(c.telefons);
            }
            
            return tels;
        }

        public static List<email> GetContacteEmails(int id)
        {
            contacte c = (contacte)MakeRequest(string.Concat(ws1, "contacteTot/", id), null, "GET", "application/json", typeof(contacte));

            List<email> emails = new List<email>();

            if (c != null)
            {
                emails.AddRange(c.emails);
            }
            
            return emails;
        }


        public static List<contacte> GetContactesTot()
        {
            
            List<contacte> cs = (List<contacte>)MakeRequest(string.Concat(ws1, "contactesTot"), null, "GET", "application/json", typeof(List<contacte>));

            return cs;
        }
        public static List<contacte> GetContactesTotByName(string nom)
        {
            
            List<contacte> cs = (List<contacte>)MakeRequest(string.Concat(ws1, "contactesTot/", nom), null, "GET", "application/json", typeof(List<contacte>));

            return cs;
        }

        public static List<contacte> GetContactesByName(string name)
        {
            List<contacte> c = (List<contacte>)MakeRequest(string.Concat(ws1, "contactes/", name), null, "GET", "application/json", typeof(List<contacte>));
            return c;
        }

        public static List<contacte> GetContactesByPhone(string tlf)
        {
            List<contacte> c = new List<contacte>();

            List<telefon> t = (List<telefon>)MakeRequest(string.Concat(ws1, "telefonC/", tlf), null, "GET", "application/json", typeof(List<telefon>));

            if(t != null)
            {
                foreach (telefon tel in t)
                {
                    c.Add(tel.contacte);
                }
            }

            return c;
        }
        public static List<telefon> GetPhonesByPhone(string tlf)
        {
            List<telefon> t = (List<telefon>)MakeRequest(string.Concat(ws1, "telefonC/", tlf), null, "GET", "application/json", typeof(List<telefon>));

            return t;
        }

        public static List<contacte> GetContactesByEmail(string email)
        {
            List<contacte> c = new List<contacte>();

            List<email> e = (List<email>)MakeRequest(string.Concat(ws1, "emailC/", email), null, "GET", "application/json", typeof(List<email>));

            if (e != null)
            {
                foreach (email em in e)
                {
                    c.Add(em.contacte);
                }
            }

            return c;
        }
        public static List<email> GetEmailsByEmail(string email)
        {
            List<email> e = (List<email>)MakeRequest(string.Concat(ws1, "emailC/", email), null, "GET", "application/json", typeof(List<email>));

            return e;
        }


        public static List<telefon> GetTelefons()
        {
            List<telefon> telefons = new List<telefon>();

            List<contacte> cs = GetContactesTot();

            foreach (contacte c in cs)
            {
                telefons.AddRange(c.telefons);
            }

            return telefons;
        }
        public static List<email> GetEmails()
        {
            List<email> emails = new List<email>();
            
            List<contacte> cs = GetContactesTot();

            foreach (contacte c in cs)
            {
                emails.AddRange(c.emails);
            }

            return emails;
        }
        public static void DeleteContacte(int id)
        {
            MakeRequest(string.Concat(ws1, "contacteTot/", id), null, "DELETE", "application/json", typeof(contacte));
        }
        public static void DeleteEmail(int id)
        {
            MakeRequest(string.Concat(ws1, "email/", id), null, "DELETE", "application/json", typeof(email));
        }
        public static void DeleteTelefon(int id)
        {
            MakeRequest(string.Concat(ws1, "telefon/", id), null, "DELETE", "application/json", typeof(telefon));
        }
        public static void ModifyContacte(int id, String nom, String cognoms)
        {
            JObject jsonObject = new JObject
            {
                ["nom"] = nom,
                ["cognoms"] = cognoms,
            };

            MakeRequest(string.Concat(ws1, "contacte/", id), jsonObject, "PUT", "application/json", typeof(contacte));
        }
        public static void ModifyTelefon(int id, String tel, String tipus)
        {
            JObject jsonObject = new JObject
            {
                ["telefon1"] = tel,
                ["tipus"] = tipus,
            };

            MakeRequest(string.Concat(ws1, "telefon/", id), jsonObject, "PUT", "application/json", typeof(telefon));
        }
        public static void ModifyEmail(int id, String email, String tipus)
        {
            JObject jsonObject = new JObject
            {
                ["telefon1"] = email,
                ["tipus"] = tipus,
            };

            MakeRequest(string.Concat(ws1, "email/", id), jsonObject, "PUT", "application/json", typeof(email));
        }

        public static void InsertContacte(string name, string surname)
        {
            JObject jsonObject = new JObject
            {
                ["nom"] = name,
                ["cognoms"] = surname,
            };

            MakeRequest(string.Concat(ws1, "contacte"), jsonObject, "POST", "application/json", typeof(contacte));
        }
        public static void InsertEmail(int cId, string email, string type)
        {
            JObject jsonObject = new JObject
            {
                ["contacteId"] = cId,
                ["email1"] = email,
                ["tipus"] = type,
            };

            MakeRequest(string.Concat(ws1, "email"), jsonObject, "POST", "application/json", typeof(email));
        }
        public static void InsertTelefon(int cId, string tlf, string type)
        {
            JObject jsonObject = new JObject
            {
                ["contacteId"] = cId,
                ["telefon1"] = tlf,
                ["tipus"] = type,
            };

            MakeRequest(string.Concat(ws1, "telefon"), jsonObject, "POST", "application/json", typeof(telefon));
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
