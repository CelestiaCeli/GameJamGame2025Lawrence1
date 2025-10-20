using UnityEngine;

public class Doorfunction : MonoBehaviour
{
    public GameObject Key; // Assign the key object in the Inspector
    private bool isLocked = true;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Key" && isLocked)
        {
            OpenDoor();
            Debug.Log("Door open");
        }
    }
    private void OpenDoor()
    {
        transform.Translate(Vector2.up * 2f);
        isLocked = false;
    }
}
