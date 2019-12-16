using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public Vector3 Velocity {get; set;}
    public Vector3 Rotation {get; set;}

    public float LookUp {get; set;}

    [SerializeField]
    private Camera cam = null;

    [SerializeField]
    private bool InvertY = false;
    private Rigidbody rb;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Start()
    {
        Velocity = Vector3.zero;
        Rotation = Vector3.zero;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        if (Velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + Velocity * Time.fixedDeltaTime);
        }
    }

    private void Rotate()
    {
        if(Rotation != Vector3.zero)
        {
            rb.MoveRotation(rb.rotation * Quaternion.Euler(Rotation));
        }

        if(cam != null)
        {
            float inverse = InvertY ? 1f : -1f;
            float xRotation = cam.transform.localRotation.eulerAngles.x;
            xRotation -= LookUp;
            var newCameraRotation = Quaternion.Euler(xRotation, 0f, 0f);
            cam.transform.localRotation = newCameraRotation;
        } 
    }
}
