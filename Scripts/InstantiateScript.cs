using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public GameObject Button;
    bool IsInArea = false;
    Ghost GhostScript;
    public GameObject GhostObject;
    

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
            Instantiate(Button, new Vector2(0f, 0f), Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if collision.
            IsInArea = false;
    }
}
