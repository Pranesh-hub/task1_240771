using UnityEngine;

public class ZombieAvoidance : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float avoidRadius = 0.5f;
    public LayerMask zombieLayer; // Set to your "Zombie" layer in Inspector

    private Transform player;
    private Rigidbody2D rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (player == null) return;

        // Step 1: Direction to player
        Vector2 directionToPlayer = (player.position - transform.position).normalized;
        Vector2 avoidance = Vector2.zero;

        // Step 2: Avoid nearby zombies
        Collider2D[] nearbyZombies = Physics2D.OverlapCircleAll(transform.position, avoidRadius, zombieLayer);

        foreach (Collider2D zombie in nearbyZombies)
        {
            if (zombie.gameObject != this.gameObject)
            {
                Vector2 pushDir = (Vector2)(transform.position - zombie.transform.position);
                float dist = pushDir.magnitude;
                if (dist > 0)
                {
                    avoidance += pushDir.normalized / dist;
                }
            }
        }

        // Step 3: Combine movement
        Vector2 finalDir = (directionToPlayer + avoidance).normalized;
        Vector2 newPos = rb.position + finalDir * moveSpeed * Time.fixedDeltaTime;

        // Step 4: Move with physics so wall collisions work
        rb.MovePosition(newPos);
    }
}
