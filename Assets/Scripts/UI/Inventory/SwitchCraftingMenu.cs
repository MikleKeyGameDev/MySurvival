using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCraftingMenu : MonoBehaviour
{
    [SerializeField] private GameObject _craftMenu;

    private bool _isEnabled = false;

    private void Update()
    {
        _craftMenu.SetActive(_isEnabled);
    }

    public void Switch()
    {
        _isEnabled = !_isEnabled;
    }
}
