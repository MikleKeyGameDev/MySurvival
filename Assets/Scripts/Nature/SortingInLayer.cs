using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingInLayer : MonoBehaviour
{
    [SerializeField] GameObject _player;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Sorting();
    }

    private void Sorting()
    {
        if( _player.transform.position.y > transform.position.y)
        {
            _spriteRenderer.sortingLayerName = "NatureForeGround";
        }
        else
        {
            _spriteRenderer.sortingLayerName = "NatureBackGround";
        }
    }
}
