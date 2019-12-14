using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private float damage;

    [SerializeField]
    private Camera fpsCamera = null;

    public void FetchFireKey(InputAction.CallbackContext context)
    {
        RaycastHit hit;
        if( Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, 100f))
        {
            Debug.Log(hit.transform.name);
        }
    } 
}
