using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private GameObject _objItem;
    
    [SerializeField] private string _name;
    
    [SerializeField] private int _id;
    
    [SerializeField] private float _nutritionalValue;

    [SerializeField] private bool _isQuantitative;
    [SerializeField] private bool _isFood;
    [SerializeField] private bool _isCrafting;
    [SerializeField] private bool _isUse;

    private Recepte _recept;

    private void Start()
    {
        if(_isCrafting) { _recept = GetComponent<Recepte>(); }
    }

    public float GetNutritionalValue() { return _nutritionalValue; }

    public bool GetIsFood() { return _isFood; }
    public bool GetIsUse() { return _isUse; }
    public bool GetQuantitative() { return _isQuantitative; }

    public SpriteRenderer GetSpriteRenderer() { return _objItem.GetComponent<SpriteRenderer>(); }

    public string GetName() { return _name; }
    public int GetID() { return _id; }
}
