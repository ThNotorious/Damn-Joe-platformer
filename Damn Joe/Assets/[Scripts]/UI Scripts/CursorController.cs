using UnityEngine;

public class CursorController : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTextureLevel;

    private void Start()
    {
        Cursor.SetCursor(cursorTextureLevel, Vector2.zero, CursorMode.Auto);
    }
}
