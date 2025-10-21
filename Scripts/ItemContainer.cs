using UnityEngine;

public class ItemContainer : MonoBehaviour
{
    public float X = 0f;
    public float Y = 0f;
    public GameObject Item;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ItemOutput()
    {
        Instantiate(Item, new Vector2(X, Y), Quaternion.identity);
    }
}
