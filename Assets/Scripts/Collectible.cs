using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int value = 1;
    public AudioClip pickupSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (audioSource != null && pickupSound != null)
                audioSource.PlayOneShot(pickupSound);

            ScoreManager.Instance.AddScore(value);

            Destroy(gameObject, 0.1f); // Delay destroy to play sound
        }
    }
}
