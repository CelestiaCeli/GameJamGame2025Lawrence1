using UnityEngine;

public class Lamp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool isOn;
    public GameObject item;

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
        item.SetActive(isOn);
    }
}
