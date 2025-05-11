using UnityEngine;

public class LobsterController : MonoBehaviour
{
    [SerializeField] Transform player;   // Player transform to follow
    private Rigidbody rb;                // Rigidbody to control movement
    public float rate = 3f;              // Movement speed rate

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Get the Rigidbody component attached to this lobster
    }

    void Update()
    {
        // Move towards the player at a constant speed
        Vector3 direction = (player.position - transform.position).normalized;
        Vector3 targetPosition = transform.position + direction * rate * Time.deltaTime;

        // Move the lobster using Rigidbody for physics-based movement
        rb.MovePosition(targetPosition);

        // Smoothly rotate towards the player
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rate); // You can adjust the speed of rotation here
    }
}
