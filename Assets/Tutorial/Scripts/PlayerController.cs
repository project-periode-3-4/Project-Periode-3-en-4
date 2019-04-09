using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;
    private PlayerMotor motor;

    public GameObject ObjectText;
    public GameObject Object1Text;
    public GameObject Object2Text;
    public GameObject DoorClosedText;
    public GameObject DoorOpenText;
    public GameObject Door;

    bool textActive;
    bool Doorclosed;
    
    void Start()
    {
        motor = GetComponent<PlayerMotor>();
        textActive = false;
        ObjectText.SetActive(false);
        Object1Text.SetActive(false);
        Object2Text.SetActive(false);
        DoorClosedText.SetActive(false);
        DoorOpenText.SetActive(false);
        Doorclosed = true;
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
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Object")
        {
            ObjectText.SetActive(true);
            textActive = true;
            Debug.Log("gang gang");
        }

        if (other.gameObject.tag == "Object1")
        {
            Object1Text.SetActive(true);
            textActive = true;
            Debug.Log("gang gang");
        }

        if (other.gameObject.tag == "Object2")
        {
            Object2Text.SetActive(true);
            textActive = true;
            Debug.Log("gang gang");
        }       
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Door")
        {
            DoorClosedText.SetActive(true);
            textActive = true;
            //Debug.Log("Sjaan blijf van me deur af");
            Dooropen();
            DoorClosed();
        }
    }

    void Dooropen()
    {
        if (Doorclosed == true)
        {
            DoorClosedText.SetActive(true);
            DoorOpenText.SetActive(false);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Door.transform.position = new Vector3(-0.368f, 0f, 3.67f);
                Door.transform.eulerAngles = new Vector3(0f, 90f, 0f);
                Debug.Log("Yeet");
                DoorClosed();
                Doorclosed = false;
            }
        }
    }

    void DoorClosed()
    {
        if(Doorclosed == false)
        {
            DoorClosedText.SetActive(false);
            DoorOpenText.SetActive(true);


            if (Input.GetKeyDown(KeyCode.C))
            {
                Door.transform.position = new Vector3(-0.018f, 0f, 3.279f);
                Door.transform.eulerAngles = new Vector3(0f, 180f, 0f);
                Debug.Log("Yordi");
                Doorclosed = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        ObjectText.SetActive(false);
        Object1Text.SetActive(false);
        Object2Text.SetActive(false);
        DoorClosedText.SetActive(false);
        DoorOpenText.SetActive(false);
        textActive = false;
    }
}
