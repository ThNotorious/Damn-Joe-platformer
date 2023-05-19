using UnityEngine;

public class WindowManager : MonoBehaviour
{
    [SerializeField] private GameObject _openPanel;
    [SerializeField] private GameObject _closedPanel;

    /// <summary>
    /// ��������/�������� ���� ��� ������� �� ������
    /// </summary>
    public void ButtonPress()
    {
        _openPanel.SetActive(true);
        _closedPanel.SetActive(false);
    }
}
