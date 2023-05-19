using UnityEngine;
using UnityEngine.UI;

public class PortalPartsUI : MonoBehaviour
{
    [SerializeField] private PortalCreateZone _portalCreateZone;
    [SerializeField] private Text _partsText;

    #region Подписки на события
    private void OnEnable()
    {
        _portalCreateZone.AmountParts += PortalPartsStatTextOnCanvas;
    }

    private void OnDisable()
    {
        _portalCreateZone.AmountParts -= PortalPartsStatTextOnCanvas;
    }
    #endregion

    private void Start()
    {
        _partsText.text = $"0/{_portalCreateZone.MaxParts}";
    }

    /// <summary>
    /// Вывод количества частей портала на канвас
    /// </summary>
    private void PortalPartsStatTextOnCanvas(int amountParts)
    {
        _partsText.text = $"{amountParts}/{_portalCreateZone.MaxParts}";
    }
}
