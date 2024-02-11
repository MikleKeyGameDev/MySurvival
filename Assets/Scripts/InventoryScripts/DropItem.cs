using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DropItem : MonoBehaviour
{
    [SerializeField] private Hero _hero;

    private Cell _cell;
    private Item _item;

    private void Start()
    {
        _cell = GetComponent<Cell>();
    }

    public void Drop()
    {
        _item = _cell.GetObject().GetComponent<Item>();

        if (_item != null)
        {
            GameObject obj = Instantiate(_cell.GetObject(), _hero.gameObject.transform);
            obj.GetComponent<InteractoinItem>().FindInventory();
            obj.transform.parent = null;
            _cell.RemoveItem();
        }
    }
}
