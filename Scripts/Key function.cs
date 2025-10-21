using UnityEngine;

public class Keyfunction : MonoBehaviour
{
    public bool keyCollected = false;
    public GameObject itemToToggle;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Players")) 
        {
            keyCollected = true;
            gameObject.SetActive(false);
            Debug.Log("Key collected!");
        }
    }
}