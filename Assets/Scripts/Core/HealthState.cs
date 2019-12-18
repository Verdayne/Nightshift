using UnityEngine;
using TMPro;

public class HealthState : MonoBehaviour
{
    [SerializeField]
    private int maxHealth = 100;

    [SerializeField]
    private TextMeshProUGUI healthText = null;
    private int health;

    private void Start()
    {
        health = maxHealth;
    }

    public void Heal(int healAmount)
    {
        health = Mathf.Min(health + healAmount, maxHealth);
        if(healthText)
            healthText.text = health.ToString();
    }

    public void ApplyDamage(int damage)
    {
        health -= damage;
        if(healthText)
        {
            healthText.text = health.ToString();
        }
        
        if (health <= 0)
        {
            Destroy(gameObject);
        }   
    }
}
