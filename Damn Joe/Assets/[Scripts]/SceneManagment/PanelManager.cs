using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private GameObject _openPanel;

    /// <summary>
    /// Открытие окна 
    /// </summary>
    public void OpenPanel()
    {
        _openPanel.SetActive(true);
    }
    /// <summary>
    /// Закрытие окна 
    /// </summary>
    public void ClosedPanel()
    {
        _openPanel.SetActive(false);
    }
}
