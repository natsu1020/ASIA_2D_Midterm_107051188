using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
