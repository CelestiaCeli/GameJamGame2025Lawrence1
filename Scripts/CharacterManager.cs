using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterManager : MonoBehaviour
{
    private Rigidbody2D PlayerRigidBody;
    public GameObject Perspective;
    public const float SPEED = 20;
    public bool IsSelected = false;
    //0 = Child, 1 = Young Adult, 2 = Elder.
    public int Character = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (IsSelected)
        {
            float PositionX = Input.GetAxis("Horizontal");
            float PositionY = Input.GetAxis("Vertical");


            PlayerRigidBody.linearVelocity = new Vector2(PositionX * SPEED, PositionY * SPEED);

        }
    }

    public void SetInspirited(bool value)
    {
        IsSelected = value;
        PlayerRigidBody.linearVelocity = new Vector2(0, 0);
        
        if (IsSelected)
        {
            Perspective.SetActive(true);
        }
        else
        {
            Perspective.SetActive(false);
        }
    }
}
