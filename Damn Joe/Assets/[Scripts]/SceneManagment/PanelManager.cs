using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private GameObject _openPanel;

    /// <summary>
    /// �������� ���� 
    /// </summary>
    public void OpenPanel()
    {
        _openPanel.SetActive(true);
    }
    /// <summary>
    /// �������� ���� 
    /// </summary>
    public void ClosedPanel()
    {
        _openPanel.SetActive(false);
    }
}
