using UnityEngine;


public class PlayerDeath : MonoBehaviour
{
    /// <summary>
    /// Вызывается в конце анимации смерти игрока
    /// </summary>
    public void Death()
    {
        DefeatScene.OpenDefeatScene();
    }
}

