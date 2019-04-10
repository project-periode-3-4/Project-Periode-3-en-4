using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PasswordSecurity;
using PHPConnection;
using DBConnection;

public class TestScript : MonoBehaviour
{
   
    
    string Key = "m03gszfNiC1nh7QtL9PgQldoONOtrOmS";

    [SerializeField]
    public Text Test;
    [SerializeField]
    private bool Succes = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(DateTimeOffset.UtcNow.ToUnixTimeSeconds());
    }

    public static void Debugging(string ex)
    {
        Debug.Log(ex);      
    }

    public void Onclick()
    {
        //DBReciever.ReceiveDataLogin("FirstInsert","itu_accounts");
        string passwordHass = PasswordHasherAndSalt.PasswordHasher(Test.text);
        Succes = PasswordHasherAndSalt.PasswordCompare(passwordHass, Test.text);
        //DBInteraction.SendDataLogin("Reeee", passwordHass, "itu_accounts");
        //Test.text = passwordHass;
        InsertData("Geheim");
    }

    public void InsertData(string Password)
    {

        string CreateURL = "http://jemx.nl/itapi/";
        
        //string testingSHit = SHA256Encryption.Encrypt(DateTimeOffset.UtcNow.ToUnixTimeSeconds() + Alteration + "/insert_account/" + "316378" + "/"+ Password);
        
       // CreateURL += testingSHit;
        Debug.Log(CreateURL);
       // WWWForm form = new WWWForm();
       //// form.AddField("PasswordPost", Password);
       //
    }
}
