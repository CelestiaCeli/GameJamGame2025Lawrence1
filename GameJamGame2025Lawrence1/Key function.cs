using UnityEngine;

public class Keyfunction : MonoBehaviour
{
    public static bool keyCollected = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            keyCollected = true;
            Destroy(gameObject);
            Debug.Log("Key collected!");
        }
    }
}


