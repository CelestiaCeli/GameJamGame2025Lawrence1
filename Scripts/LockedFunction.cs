using UnityEngine;
using UnityEngine.Events;

public class Doorfunction : MonoBehaviour
{

    public UnityEvent DoorUnlock;
    public GameObject Key; // Assign the key object in the Inspector
    private bool isLocked = true;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Key" && isLocked == false)
        {
            DoorUnlock.Invoke();
            Debug.Log("Door open");
        }
    }
}
