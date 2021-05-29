using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Open(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
