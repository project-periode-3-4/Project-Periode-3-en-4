using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PasswordSecurity;
using DBConnection;

public class LoginController : MonoBehaviour
{
    private string LoginName;
    private string Wachtwoord;

    public InputField InlogField;
    public InputField WWField;

    public bool Succes;

    public Text Meldingen;
    // Start is called before the first frame update
    void Start()
    {
        InlogField.onValueChanged.AddListener(delegate { InsertInlog(); });
        WWField.onValueChanged.AddListener(delegate { InsertWW(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoginCheck()
    {
       string DBPass = DBInteraction.ReceiveDataLogin(LoginName, "LOGIN");
        if (PasswordHasherAndSalt.PasswordCompare(DBPass, Wachtwoord))
        {
            Succes = true;
        }
        else
        {
            // meldingen fout WW
        }
    }

    private void InsertInlog()
    {
        LoginName = InlogField.text;
    }
    private void InsertWW()
    {
        Wachtwoord = WWField.text;
    }

}
