using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFoods : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    
    private Cell _cell;
    private Item _item;

    private void Start()
    {
        _cell = GetComponent<Cell>();
    }

    public void Eats()
    {
        _item = _cell.GetObject().GetComponent<Item>();

        if (_item != null)
        {
            _hero.Eat(_item.GetNutritionalValue());
            _cell.RemoveItem();
        }
    }
}
