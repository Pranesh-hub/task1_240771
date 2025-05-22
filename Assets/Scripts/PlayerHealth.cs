using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    private AudioSource audioSource;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();

        audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(int amount)
    {
        if (currentHealth <= 0) return;

        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthUI();

        if (audioSource != null && audioSource.clip != null)
            audioSource.Play();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void UpdateHealthUI()
    {
        if (healthSlider != null)
        {
            healthSlider.value = (float)currentHealth / maxHealth;
        }
    }

    void Die()
    {
        Debug.Log("Player died!");
        SceneManager.LoadScene("Level 1");
        // Your death handling code here
    }
}
