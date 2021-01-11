using UnityEngine.SceneManagement;
using UnityEngine;

public class ScenManagers : MonoBehaviour
{
    public void ScMang(int _nuber)
    {
        SceneManager.LoadScene(_nuber);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
