using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    [SerializeField] private GameObject _objectItem;
    [SerializeField] private GameObject _buttonEat;
    [SerializeField] private int _quantity;
    [SerializeField] private int _maxQuantity;
    [SerializeField] private Text _textQuantity;
    [SerializeField] private Sprite _standartSprite;
    [SerializeField] private Image _imageCell;

    [SerializeField] private Item _item;
    private SpriteRenderer _sprite;

    private void Update()
    {
        if (_objectItem != null)
        {
            if (_objectItem.GetComponent<Item>().GetQuantitative() == true && _quantity > 0) { _textQuantity.text = _quantity.ToString(); }
            else { _textQuantity.text = ""; }

            if(_item != null) { _buttonEat.SetActive(_item.GetIsFood()); }
        }

    }

    public bool AddItem(GameObject objectItem)
    {
        if (_objectItem == null)
        {
            _objectItem = objectItem;
            _quantity++;
            _item = _objectItem.GetComponent<Item>();
            _sprite = _item.GetSpriteRenderer();
            _imageCell.sprite = _sprite.sprite;
            return true;
        }
        else if(_item.GetName() == objectItem.GetComponent<Item>().GetName() && _quantity < _maxQuantity && objectItem.GetComponent<Item>().GetQuantitative() == true)
        {
            _quantity++;
            return true;
        }
        else
        {
            return false;
        }
    }
     
    public void RemoveItem()
    {
        _quantity--;

        if(_quantity <= 0)
        {
            _objectItem = null;
            _quantity = 0;
            _item = null;
            _sprite = null;
            _imageCell.sprite = _standartSprite;
            _textQuantity.text = "";
            _buttonEat.SetActive(false);
        }
    }

    public string GetName()
    {
        if (_objectItem != null)
        {
            return _objectItem.GetComponent<Item>().GetName();
        }
        else
        {
            return "";
        }
    }

    public GameObject GetObject()
    {
        return _objectItem;
    }
}
