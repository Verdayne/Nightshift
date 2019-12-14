using System;
using UnityEngine;
using UnityEngine.Events;

public class HealthState : MonoBehaviour
{
    [System.Serializable]
    public class DestroyEvent : UnityEvent<float>
    {
    }

    [SerializeField]
    private float maxHealth;

    private float health;

    public DestroyEvent destroyEvent;

    private void Start()
    {
        health = maxHealth;
    }

    public void SetMaxHealth(float maxHealth)
    {
        this.maxHealth = maxHealth;
        health = maxHealth;
    }

    public void ApplyDamage(float damage)
    {
        health -= damage;

        if (health <= 0.01f)
        {

        }   
    }
}
