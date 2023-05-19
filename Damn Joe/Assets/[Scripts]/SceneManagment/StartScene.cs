using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    /// <summary>
    /// Переключение сцен в игре
    /// </summary>
    /// <param name="id"></param>
    public void SceneMngr(int id)
    {
        SceneManager.LoadScene(id);
    }
    /// <summary>
    /// Выход из игры
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
