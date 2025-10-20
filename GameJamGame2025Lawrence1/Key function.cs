using UnityEngine;

public class Keyfunction : MonoBehaviour

{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure your player has the "Player" tag
        {
            Destroy(gameObject); // Simulate picking up the key
        }
    }
}

