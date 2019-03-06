using UnityEngine;


public class PlayerScript_Mouse : MonoBehaviour
{
    public bool enter;
    public AudioClip Laser_Shoot52;
    private AudioSource source;


    Vector2 _mouseAbsolute;
    Vector2 _smoothMouse;
    [Space(20)]
    [Header("Mouse Look Settings :")]
    public Vector2
            clampInDegrees = new Vector2(360, 180);
    public bool lockCursor;
    public Vector2 sensitivity = new Vector2(2, 2);
    public Vector2 smoothing = new Vector2(3, 3);
    public Vector2 targetDirection;
    public Vector2 targetCharacterDirection;

    public GameObject characterBody;

    [Space(20)]
    [Header("Camera Move Settings :")]

    public float speed = 5.0f;

    void Start()
    {
        targetDirection = transform.localRotation.eulerAngles;

        if (characterBody)
            targetCharacterDirection = characterBody.transform.localRotation.eulerAngles;
        enter = false;
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        Screen.lockCursor = lockCursor;

        var targetOrientation = Quaternion.Euler(targetDirection);
        var targetCharacterOrientation = Quaternion.Euler(targetCharacterDirection);

        var mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity.x * smoothing.x, sensitivity.y * smoothing.y));

        _smoothMouse.x = Mathf.Lerp(_smoothMouse.x, mouseDelta.x, 1f / smoothing.x);
        _smoothMouse.y = Mathf.Lerp(_smoothMouse.y, mouseDelta.y, 1f / smoothing.y);

        _mouseAbsolute += _smoothMouse;

        if (clampInDegrees.x < 360)
            _mouseAbsolute.x = Mathf.Clamp(_mouseAbsolute.x, -clampInDegrees.x * 0.5f, clampInDegrees.x * 0.5f);

        var xRotation = Quaternion.AngleAxis(-_mouseAbsolute.y, targetOrientation * Vector3.right);
        transform.localRotation = xRotation;

        if (clampInDegrees.y < 360)
            _mouseAbsolute.y = Mathf.Clamp(_mouseAbsolute.y, -clampInDegrees.y * 0.5f, clampInDegrees.y * 0.5f);

        transform.localRotation *= targetOrientation;

        if (characterBody)
        {
            var yRotation = Quaternion.AngleAxis(_mouseAbsolute.x, characterBody.transform.up);
            characterBody.transform.localRotation = yRotation;
            characterBody.transform.localRotation *= targetCharacterOrientation;
        }
        else
        {
            var yRotation = Quaternion.AngleAxis(_mouseAbsolute.x, transform.InverseTransformDirection(Vector3.up));
            transform.localRotation *= yRotation;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Zone1")
        {
            enter = true;
            source.PlayOneShot(Laser_Shoot52);
            Debug.Log("Entered");
        }

        if (other.gameObject.tag == "Zone2")
        {
            enter = true;
            source.PlayOneShot(Laser_Shoot52);
            Debug.Log("Entered");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Zone1")
        {
            enter = false;
            Debug.Log("Exited");
        }

        if (other.gameObject.tag == "Zone2")
        {
            enter = false;
            Debug.Log("Exited");
        }
    }
}
