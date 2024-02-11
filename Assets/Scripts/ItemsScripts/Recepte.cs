using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recepte : MonoBehaviour
{
    [SerializeField] private GameObject _element1;
    [SerializeField] private GameObject _element2;
    [SerializeField] private GameObject _craftingObject;
    [SerializeField] private InventoryBox _inventory;

    public void Crafting()
    {
        if(_inventory.GetItem(_element1) == true && _inventory.GetItem(_element2) == true)
        {
            _inventory.AddItem(_craftingObject);
            _inventory.RemoveObject(_element1);
            _inventory.RemoveObject(_element2);
        }
        else
        {
            Debug.Log("Нет нужных предметов");
        }
    }
}
