using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PasswordSecurity;

namespace PHPConnection
{
    public class PHPInteraction
    {
       private protected const string Alteration = "86632198";

        //insert
        public void InsertAcc()
        {
           
        }
        //select
        public void SelectAcc()
        {

        }
        //update
        public void UpdatePass()
        {

        }
        //delete
        public void DeleteAcc()
        {

        }

        private void SendAction(string Action, string Data, string Data2,string Data3)
        {
            string URL = "http://jemx.nl/itapi/";
            var UnixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            string SendingString = URL + SHA256Encryption.Encrypt(UnixTime + Alteration + "/" + Action + "/" + Data + "/" + Data2 + "/" + Data3);

            WWWForm form = new WWWForm();
            WWW www = new WWW(SendingString, form);
        }
    }
}
