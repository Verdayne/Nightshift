using UnityEngine;

public class HealthState : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 100;
    private int health;

    private void Start()
    {
        health = maxHealth;
    }

    public void Heal(int healAmount) => health = Mathf.Min(health + healAmount, maxHealth);

    public void ApplyDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }   
    }
}
