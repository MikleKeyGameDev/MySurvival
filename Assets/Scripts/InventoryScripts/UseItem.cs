using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class UseItem : MonoBehaviour
{
    [SerializeField] private HendScript _hend;

    private Hero _hero;
    private Cell _cell;
    private Item _item;

    private void Start()
    {
        _cell = GetComponent<Cell>();
    }

    public void Used()
    {
        _hero = FindAnyObjectByType<Hero>();
        _item = _cell.GetObject().GetComponent<Item>();

        if (_item != null)
        {
            _hero.SetHendObject(_item.gameObject);
            _hend.AddItem(_item.gameObject);
            _cell.RemoveItem();
        }
    }
}
