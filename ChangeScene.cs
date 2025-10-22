using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public int ChangedScene;

    public void ChangeSceneFunction()
    {
        SceneManager.LoadScene(ChangedScene);
    }
}
