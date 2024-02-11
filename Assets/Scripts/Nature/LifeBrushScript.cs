using System.Collections;
using UnityEngine;

public class LifeBrushScript : MonoBehaviour
{
    [SerializeField] private Sprite[] _spritesStages;
    [SerializeField] private GameObject _producedProduct;
    [SerializeField] private InventoryBox _inventory;

    [SerializeField] private float[] _timeLife;

    private SpriteRenderer _rend;
    private bool _isRipe;

    private void Start()
    {
        StartCoroutine(Maturation());
        _rend = GetComponent<SpriteRenderer>();
    }

    public void Harvest()
    {
        if (_isRipe == true)
        {
            if (_inventory.AddItem(_producedProduct))
            {
                _isRipe = false;
                _rend.sprite = _spritesStages[0];
                StartCoroutine(Maturation());
            }
        }
        else
        {
            return;
        }
    }

    private IEnumerator Maturation()
    {
        if (_isRipe == false)
        {
            yield return new WaitForSeconds(Random.Range(_timeLife[0], _timeLife[1]));
            _isRipe = true;
            _rend.sprite = _spritesStages[1];
        }
    }
}
