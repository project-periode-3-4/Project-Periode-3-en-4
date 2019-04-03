using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PasswordSecurity;
using DBConnection;
using System.Text;
using System.Security.Cryptography;
using System.IO;

public class TestScript : MonoBehaviour
{
    string CreateUserURL = "";

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



        DBInteraction.SendDataLogin("Reeee", passwordHass, "itu_accounts");

        //Test.text = passwordHass;
        SHA256 mySHA256 = SHA256Managed.Create();
        byte[] iv = new byte[16] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
        byte[] key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes("geheim"));
        Debug.Log(AESEncryption.EncryptString("test", key, iv));
    }

    public void InsertData(string Password)
    {
        WWWForm form = new WWWForm();     
        form.AddField("PasswordPost", Password);
        WWW www = new WWW(CreateUserURL, form);
    }
}
