using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using PasswordSecurity;

namespace PHPConnection
{
    public class PHPInteraction
    {
       private protected const string Alteration = "86632198";
        public static string SendAndRetrieveAction(string Action, string[] Data)
        {
            var UnixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            string DataString = string.Join("/", Data);
            WWW DataWWW = new WWW("http://jemx.nl/itapi/" + SHA256Encryption.Encrypt(UnixTime + Alteration + "/" + Action + "/" + DataString + "/"));
            while (!DataWWW.isDone)
            {
                
            }
            return DataWWW.text;
        }
        //public static IEnumerator RetrieveAction(string Action, string[] Data)
        //{
        //    var UnixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        //    string DataString = string.Join("/", Data);        
        //    string URI = "http://jemx.nl/itapi/" + SHA256Encryption.Encrypt(UnixTime + Alteration + "/" + Action + "/" + DataString + "/");
        //    using (UnityWebRequest webRequest = UnityWebRequest.Get(URI))
        //    {
        //        yield return webRequest.SendWebRequest();              
        //        if (webRequest.isNetworkError)
        //        {
        //            TestScript.Debugging("Error: " + webRequest.error);
        //        }
        //        else
        //        {
        //            TestScript.Debugging("\nReceived: " + webRequest.downloadHandler.text);
        //        }
        //    }

        //}
    }
}
