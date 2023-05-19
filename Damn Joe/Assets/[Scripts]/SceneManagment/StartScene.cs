using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    /// <summary>
    /// ������������ ���� � ����
    /// </summary>
    /// <param name="id"></param>
    public void SceneMngr(int id)
    {
        SceneManager.LoadScene(id);
    }
    /// <summary>
    /// ����� �� ����
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
