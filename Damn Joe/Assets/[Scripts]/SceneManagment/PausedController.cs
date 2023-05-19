using UnityEngine;

public class PausedController : MonoBehaviour
{
    [SerializeField] private GameObject _pausedCanvas;
    [SerializeField] private GameObject _playerCanvas;

    [SerializeField] private Texture2D cursorTexturePaused;
    [SerializeField] private Texture2D cursorTextureGame;

    private bool _isPaused;

    #region Подписки на события

    private void OnEnable()
    {
        PlayerInput.PressEscButtonEvent += OnPaused;
    }

    private void OnDisable()
    {
        PlayerInput.PressEscButtonEvent -= OnPaused;
    }

    #endregion

    /// <summary>
    /// Пауза
    /// </summary>

    private void Start()
    {
        _isPaused = false;
        _pausedCanvas.SetActive(false);
        _playerCanvas.SetActive(true);
        Time.timeScale = 1f;
        Cursor.SetCursor(cursorTextureGame, Vector2.zero, CursorMode.Auto);
    }

    /// <summary>
    /// Управление паузой
    /// </summary>
    public void OnPaused()
    {
        _isPaused = !_isPaused;

        if (_isPaused == true)
        {
            _pausedCanvas.SetActive(true);
            _playerCanvas.SetActive(false);
            Time.timeScale = 0f;
            Cursor.SetCursor(cursorTexturePaused, Vector2.zero, CursorMode.Auto);
        }
        else if (_isPaused == false)
        {
            _playerCanvas.SetActive(true);
            _pausedCanvas.SetActive(false);
            Time.timeScale = 1f;
            Cursor.SetCursor(cursorTextureGame, Vector2.zero, CursorMode.Auto);
        }
    }
}
