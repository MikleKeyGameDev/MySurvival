using System.Collections.Generic;
using UnityEngine;

public class InventoryBox : MonoBehaviour
{
    [SerializeField] private List<Cell> _cells;

    [SerializeField] private GameObject[] _objectID;

    public bool AddItem(GameObject objectItem)
    {
        if (AddQuantitativeItem(_objectID[objectItem.GetComponent<Item>().GetID()]) == false)
        {
            for (int i = 0; i < _cells.Count; i++)
            {
                if (_cells[i].GetObject() == null)
                {
                    _cells[i].AddItem(_objectID[objectItem.GetComponent<Item>().GetID()]);
                    return true;
                }
            }

            return false;
        }
        else
        {
            return true;
        }
    }

    private bool AddQuantitativeItem(GameObject objectItem)
    {
        for (int i = 0; i < _cells.Count; i++)
        {
            if (_cells[i].GetName() == objectItem.GetComponent<Item>().GetName())
            {
                if (_cells[i].AddItem(objectItem))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public void RemoveObject(GameObject objectItem) 
    {
        for (int i = 0; i < _cells.Count; i++)
        {
            if (objectItem == _cells[i].GetObject())
            {
                _cells[i].RemoveItem();
            }
        }
    }

    public bool GetItem(GameObject objectItem)
    {
        for(int i = 0; i < _cells.Count; i++)
        {
            if(objectItem == _cells[i].GetObject())
            {
                return true;
            }
        }

        return false;
    }
}
