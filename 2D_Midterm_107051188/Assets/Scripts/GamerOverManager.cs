using UnityEngine;
using UnityEngine.SceneManagement;
public class GamerOverManager : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
