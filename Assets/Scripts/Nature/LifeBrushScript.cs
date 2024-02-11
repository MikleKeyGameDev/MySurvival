using System.Collections;
using UnityEngine;

public class LifeBrushScript : MonoBehaviour
{
    [SerializeField] private Sprite[] _spritesStages;
    [SerializeField] private SpriteRenderer _rend;
    [SerializeField] private GameObject _producedProduct;
    [SerializeField] private InventoryBox _inventory;

    private bool _isRipe;

    private void Start()
    {
        StartCoroutine(Maturation());
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
            Debug.Log("Куст ещё не созрел");
        }
    }

    private IEnumerator Maturation()
    {
        if (_isRipe == false)
        {
            yield return new WaitForSeconds(Random.Range(50, 100));
            _isRipe = true;
            _rend.sprite = _spritesStages[1];
        }
    }
}
