using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public GameObject Button;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Button, new Vector2(0f, 0f), Quaternion.identity);
        }
    }

}
