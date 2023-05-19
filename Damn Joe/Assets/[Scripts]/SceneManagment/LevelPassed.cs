using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPassed : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GlobalStringVars.PlayerTag))
        {
            SceneManager.LoadScene("WIN SCENE");
        }
    }
}
