using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class InteractTrees : MonoBehaviour
{
    private Hero _hero;

    private LifeBrushScript _life;
    private Color _colorStandart;

    private bool _isPlayer;
    private bool _isMousOver;

    private TreeScript _tree;

    private void Start()
    {
        _hero = FindAnyObjectByType<Hero>();
        _life = GetComponent<LifeBrushScript>();
        _tree = GetComponent<TreeScript>();
        _colorStandart = GetComponent<SpriteRenderer>().color;
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

    private void OnMouseExit()
    {
        _isMousOver = false;
        GetComponent<SpriteRenderer>().color = _colorStandart;
    }

    private void OnMouseEnter()
    {
        _isMousOver = true;
        GetComponent<SpriteRenderer>().color = Color.grey;
    }

    private void OnMouseDown()
    {
        if (_isPlayer == true && _isMousOver == true && _hero.GetAxe() == true)
        {
            _tree.TakeDamage(1f);
        }
        else
        {
            return;
        }
    }
}
