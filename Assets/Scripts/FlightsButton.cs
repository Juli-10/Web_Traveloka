using UnityEngine;
using UnityEngine.UI;

public class FlightsButton : MonoBehaviour
{
    public GameObject dropdownPanel;
    private bool isOpen = false;
    private CanvasGroup canvasGroup;

    void Start()
    {
        canvasGroup = dropdownPanel.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = dropdownPanel.AddComponent<CanvasGroup>();
        }
        SetDropdownState(false);
    }

    public void ToggleDropdown()
    {
        isOpen = !isOpen;
        SetDropdownState(isOpen);
    }

    private void SetDropdownState(bool state)
    {
        dropdownPanel.SetActive(state);
        canvasGroup.blocksRaycasts = state; // Mencegah tombol di bawahnya kena klik saat dropdown aktif
        canvasGroup.interactable = state;   // Hanya aktif saat terbuka
    }
}
