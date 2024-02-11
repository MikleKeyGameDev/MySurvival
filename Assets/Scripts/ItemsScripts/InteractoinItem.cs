using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractoinItem : MonoBehaviour
{
    [SerializeField] private InventoryBox _inventory;
    [SerializeField] private GameObject _producedProduct;
    private bool _isPlayer;

    private void Update()
    {
        InputPlayer();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _isPlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _isPlayer = false;
        }
    }

    private void InputPlayer()
    {
        if (_isPlayer == true && Input.GetKeyDown(KeyCode.E))
        {
            _inventory.AddItem(_producedProduct);
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
}
