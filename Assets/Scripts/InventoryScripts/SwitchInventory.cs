using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInventory : MonoBehaviour
{
    [SerializeField] private GameObject _inventory;
    private bool _isActive = true;

    private void Start()
    {
        _isActive = false;
    }

    private void Update()
    {
        _inventory.SetActive(_isActive); 
        Switch();
    }

    private void Switch()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            _isActive = !_isActive;
        }
    }
}
