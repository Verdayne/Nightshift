using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] 
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;

    private PlayerMovement movement;
    private Vector2 moveInput;
    private Vector2 lookInput;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        movement.Velocity = CalculatePlayerVelocity();
        movement.Rotation = CalculatePlayerRotation();
        movement.LookUp = lookInput.y * lookSensitivity;
    }

    private Vector3 CalculatePlayerVelocity()
    {
        float xMovement = moveInput.x;
        float zMovement = moveInput.y;

        Vector3 horizontalMovement = transform.right * xMovement;
        Vector3 verticalMovement = transform.forward * zMovement;

        return (horizontalMovement + verticalMovement).normalized * speed; 
    }

    private Vector3 CalculatePlayerRotation()
    {
        float yRotation = lookInput.x;
        return Vector3.up * yRotation * lookSensitivity;
    }

    public void FetchMoveInput(InputAction.CallbackContext context) => moveInput = context.ReadValue<Vector2>();

    public void FetchLookInput(InputAction.CallbackContext context) => lookInput = context.ReadValue<Vector2>();

}
