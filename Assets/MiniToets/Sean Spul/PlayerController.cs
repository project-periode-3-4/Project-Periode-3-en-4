using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;
    private PlayerMotor motor;

    //public GameObject[] myTexts;

    public Text GoedAntwoordText;
    public Text FoutAntwoordText;
    public GameObject Vraag2Text;
    public GameObject Vraag1;
    public GameObject vraag3;
    public GameObject vraag4;
    public GameObject vraag5;
    public GameObject vraag6;
    public GameObject vraag7;
    public GameObject vraag8;
    public GameObject vraag9;
    public GameObject vraag10;
    public GameObject GoedAntwoordGameobject;
    public GameObject FoutAntwoordGameobject;
    public Text Scoretext;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        motor = GetComponent<PlayerMotor>();
        Vraag2Text.SetActive(false);
        Vraag1.SetActive(true);
        vraag3.SetActive(false);
        vraag4.SetActive(false);
        vraag5.SetActive(false);
        vraag6.SetActive(false);
        vraag7.SetActive(false);
        vraag8.SetActive(false);
        vraag9.SetActive(false);
        vraag10.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        Vector3 _movHorizontal = transform.right * _xMov;
        Vector3 _movVertical = transform.forward * _zMov;

        Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed;

        motor.Move(_velocity);

        float _yRot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;

        motor.Rotate(_rotation);

        float _xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 _cameraRotation = new Vector3(_xRot, 0f, 0f) * lookSensitivity;

        motor.RotateCamera(_cameraRotation);

        Scoretext.text = ("Score: " + score);
    }

    void AntwoordGoed()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        //GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
        // GoedAntwoordGameobject.SetActive(true);
        Vraag2Text.SetActive(true);
        Vraag1.SetActive(false);
    }

    void AntwoordFout()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        //FoutAntwoordText.text = ("Fout geantwoord! Je krijgt geen punten.");
        //FoutAntwoordGameobject.SetActive(true);
    }

    void Vraag3()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        Vraag2Text.SetActive(false);
        //GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
        vraag3.SetActive(true);
    }

    void Vraag4()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        vraag3.SetActive(false);
        //GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
        vraag4.SetActive(true);
    }

    void Vraag5()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        vraag4.SetActive(false);
        //GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
        vraag5.SetActive(true);
    }

    void Vraag6()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        vraag5.SetActive(false);
        //GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
        vraag6.SetActive(true);
    }

    void Vraag7()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        vraag6.SetActive(false);
        //GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
        vraag7.SetActive(true);
    }

    void Vraag8()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        vraag7.SetActive(false);
        //GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
        vraag8.SetActive(true);
    }

    void Vraag9()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        vraag8.SetActive(false);
        //GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
        vraag9.SetActive(true);
    }

    void Vraag10()
    {
        transform.position = new Vector3(-21.68f, 1.12f, 18.13f);
        vraag9.SetActive(false);
        //GoedAntwoordText.text = ("Goed geantwoord! +1 punt.");
        vraag10.SetActive(true);
    }

    void Einde()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "GoedAntwoord")
        {
            AntwoordGoed();
            score++;
        }

        if(other.gameObject.tag == "FoutAntwoord")
        {
            AntwoordFout();
            score--;
        }

        if(other.gameObject.name == "d")
        {
            Vraag3();
            score++;
        }

        if (other.gameObject.name == "e")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "f")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "g")
        {
            Vraag4();
            score++;
        }

        if (other.gameObject.name == "h")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "i")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "j")
        {
            Vraag5();
            score++;
        }

        if (other.gameObject.name == "k")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "l")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "m")
        {
            Vraag6();
            score++;
        }

        if (other.gameObject.name == "n")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "o")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "p")
        {
            Vraag7();
            score++;
        }

        if (other.gameObject.name == "q")
        {
            Vraag7();
            score++;
        }

        if (other.gameObject.name == "r")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "s")
        {
            Vraag8();
            score++;
        }

        if (other.gameObject.name == "t")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "u")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "v")
        {
            Vraag9();
            score++;
        }

        if (other.gameObject.name == "w")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "x")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "y")
        {
            Vraag10();
            score++;
        }

        if (other.gameObject.name == "z")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "1")
        {
            AntwoordFout();
            score--;
        }

        if (other.gameObject.name == "2")
        {
            AntwoordFout();
            score++;
        }

        if (other.gameObject.name == "3")
        {
            Einde();
            score--;
        }

        if (other.gameObject.name == "4")
        {
            AntwoordFout();
            score--;
        }
    }
}
