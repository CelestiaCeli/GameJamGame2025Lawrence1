using UnityEngine;

public class GoalContainer : MonoBehaviour
{
    bool TeddyBearCollected = false;
    bool LettersCollected = false;
    bool VHSCollected = false;

    public GameObject Door;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
     void CheckUp()
    {
        if(TeddyBearCollected && LettersCollected && VHSCollected)
        {
            Door.SetActive(false);
        }
    }
   
}
