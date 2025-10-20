using UnityEngine;
using UnityEngine.UIElements;

public class CharacterManager : MonoBehaviour
{
    public const float SPEED = 20;
    public Rigidbody2D PlayerRigidBody;
    //0 = Child, 1 = Young Adult, 2 = Elder.
    public int Character = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
   }

    // Update is called once per frame
    void LateUpdate()
    {
        float PositionX = Input.GetAxis("Horizontal");
        float PositionY = Input.GetAxis("Vertical");


        PlayerRigidBody.linearVelocity = new Vector2(PositionX * SPEED, PositionY * SPEED);
    }
}
