using UnityEngine;
using UnityEngine.UI;

public class HorizontalDropdown : MonoBehaviour
{
    public GameObject dropdownContainer;
    private bool isOpen = false;

    void Start()
    {
        dropdownContainer.SetActive(false);
    }

    public void ToggleDropdown()
    {
        isOpen = !isOpen;
        dropdownContainer.SetActive(isOpen);
    }

    public void SelectOption(string option)
    {
        Debug.Log("Selected Option: " + option);
        ToggleDropdown();
    }
}
