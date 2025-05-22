using UnityEngine;

public class ZombieDamage : MonoBehaviour
{
    public int damage = 10;
    public float damageCooldown = 1f; // Time in seconds between each damage tick

    private float nextDamageTime = 0f;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Time.time >= nextDamageTime)
            {
                PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(damage);
                    nextDamageTime = Time.time + damageCooldown;
                }
            }
        }
    }
}
