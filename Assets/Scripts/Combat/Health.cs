using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;

    [SerializeField] private GameObject hitEffect, deathEffect;

    [SerializeField] private HealthBar healthbar;

    private int health;

    private void Start()
    {
        health = maxHealth;

        healthbar.UpdateHealthBar(maxHealth, health);
    }

    public void DealDamage(int damage)
    {
        if (health == 0)
        {
            Die();
        }

        health = Mathf.Max(health - damage, 0);

        Debug.Log(health);
        healthbar.UpdateHealthBar(maxHealth, health);

        Instantiate(hitEffect, transform.position, Quaternion.identity);
    }

    private void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
