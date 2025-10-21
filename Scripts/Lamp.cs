using UnityEngine;

public class Lamp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool isOn;
    public GameObject item;

    public Material LampOff;
    public Material LampOn;

    void Start()
    {
        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleLamp()
    {
        isOn = !isOn;
        Debug.Log(isOn);
        
        if (isOn)
        {
            gameObject.GetComponent<Renderer>().material = LampOn;
        }
        else 
        {
            gameObject.GetComponent<Renderer>().material = LampOff;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Players"))
        {
            ToggleLamp();
        }
    }
}
