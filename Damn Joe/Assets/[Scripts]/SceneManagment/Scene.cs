using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    /// <summary>
    /// ������������ ���� � ����
    /// </summary>
    /// <param name="id"></param>
    public void SceneMngr(int id)
    {
        SceneManager.LoadScene(id);
        Time.timeScale = 1f;
    }
}
