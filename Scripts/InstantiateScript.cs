using System.Data;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{

    public GameObject Keypad;
    bool IsInArea = false;
    Ghost GhostScript;
    public GameObject GhostObject;
    GameObject KeypadObject;
    public GameObject KeypadBarrier;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GhostScript = GhostObject.GetComponent<Ghost>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsInArea)
        {
            print("Key tapped!");
            KeypadObject = Instantiate(Keypad, new Vector2(0f, 0f), Quaternion.identity);
            KeypadObject.GetComponent<Keypad>().Correct.AddListener(KeyPadUnlock);
        }
    }

   void KeyPadUnlock()
    {
        print("KeypadBarrierDeleted");
        Destroy(KeypadBarrier);
    }

    //This has a small bug, fix this later
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && GhostScript.Inspirited == true)
        {
            print("You are in the area.");
            IsInArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Ghost") || collision.CompareTag("Player"))
        {
            IsInArea = false;
        }
    }
}
