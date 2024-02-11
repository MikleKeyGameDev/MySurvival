using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HendScript : MonoBehaviour
{
    [SerializeField] private GameObject _objectItem;
    [SerializeField] private Hero _hero;
    [SerializeField] private Sprite _standartSprite;

    private Image _imageCell;
    
    private Item _item;

    private SpriteRenderer _sprite;

    private InventoryBox _inventory;

    private void Start()
    {
        _inventory = FindAnyObjectByType<InventoryBox>();
        _imageCell = GetComponent<Image>();
    }

    public bool AddItem(GameObject objectItem)
    {
        if (_objectItem == null)
        {
            _objectItem = objectItem;
            _item = _objectItem.GetComponent<Item>();
            _sprite = _item.GetSpriteRenderer();
            _imageCell.sprite = _sprite.sprite;
            return true;
        }

        return false;
    }

    public void BackToInventory()
    {
        _inventory.AddItem(_objectItem);
        _objectItem = null;
        _item = null;
        _sprite = null;
        _imageCell.sprite = _standartSprite;
        _hero.SetHendObject(null);
    }
}
