using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 0f;
    public event Action DiedEvent;
    public float MaxHealth => maxHealth;
    private float currentHealth;
    public float CurrentHealth => currentHealth;
    private void Awake()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0f)
        {
            currentHealth = 0f;
            DiedEvent.Invoke();
        }
    }
    public void Heal(float heal)
    {
        currentHealth += heal;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
