using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LoadSceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadSceneLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadSceneLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LoadSceneLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void LoadSceneInformation()
    {
        SceneManager.LoadScene("Information");
    }
}
