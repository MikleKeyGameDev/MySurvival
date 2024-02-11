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
                    Debug.Log("Добавили новый!");
                    _cells[i].AddItem(_objectID[objectItem.GetComponent<Item>().GetID()]);
                    return true;
                }
            }

            Debug.Log("Нет места");
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
                    Debug.Log("Добавили к имеющимуся!");
                    return true;
                }
            }
        }

        return false;
    }
}
