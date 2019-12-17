#pragma warning disable 0649

using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [System.Serializable]
    public struct WeaponAttribute
    {
        public int damage;
        public float fireRate;
        public float distance;
    }

    [SerializeField]
    private Camera fpsCamera = null;

    [SerializeField]
    private WeaponAttribute weaponAttribute;

    private bool fireKeyPressed = false;
    private float timeToFire = 0f;

    private void Update()
    {
        if (fireKeyPressed && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1f / weaponAttribute.fireRate;
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, weaponAttribute.distance))
        {
            HealthState target = hit.transform.GetComponent<HealthState>();
            if(target != null)
            {
                target.ApplyDamage(weaponAttribute.damage);
            }
        }
    }

    public void FetchFireKey(InputAction.CallbackContext context)
    {
        fireKeyPressed = context.ReadValue<float>() == 1;    
    } 
}

#pragma warning restore 0649