using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Ghost : MonoBehaviour
{
    private SpriteRenderer Graphics;
    private Rigidbody2D GhostRigidBody;
    private CharacterManager GhostPlayerScript;

    bool IsSelectable = false;
    bool Inspirited = false;

    GameObject GameObjectSelectable;
    CharacterManager SelectedCharacter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Graphics = this.GetComponent<SpriteRenderer>();
        GhostRigidBody = this.GetComponent<Rigidbody2D>();
        GhostPlayerScript = this.GetComponent<CharacterManager>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print(Inspirited);
            if (Inspirited)
            {
                Graphics.enabled = true;
                Inspirited = false;
                GameObjectSelectable.GetComponent<CharacterManager>().SetInspirited(false);
                GhostPlayerScript.SetInspirited(true);
                this.transform.position = GameObjectSelectable.transform.position; 
                print("You exited");
                IsSelectable = false;
            }
            if (!Inspirited && IsSelectable == true)
            {
                Graphics.enabled = false;
                Inspirited = true;
                GameObjectSelectable.GetComponent<CharacterManager>().SetInspirited(true);
                GhostPlayerScript.SetInspirited(false);
            }
            print("Inspirit");
        }
        if (Inspirited)
        {
            this.transform.position = GameObjectSelectable.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Please work");
        IsSelectable = true;
        GameObjectSelectable = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        print("Please work");
        GameObjectSelectable = null;
    }
}
