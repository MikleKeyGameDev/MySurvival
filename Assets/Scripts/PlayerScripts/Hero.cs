using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _id;
    [SerializeField] private float _speed;
    [SerializeField, Range(0, 100)] private float _health;
    [SerializeField, Range(0, 100)] private float _hunger;

    private LifeHero _life;

    private void Start()
    {
        _life = GetComponent<LifeHero>();
    }

    public void Eat(float nutritionalValue)
    {
        _hunger += nutritionalValue;

        if (_hunger > 100)
        {
            _hunger = 100;
        }
    }

    public void LifeCicle()
    {
        if (_hunger > 0)
        {
            _hunger--;
        }
        else if(_hunger <= 0 && _health > 0)
        {
            _hunger = 0;
            _health--;
        }
        else if(_health <= 0)
        {
            Debug.Log("Ты помер!");
        }

        StartCoroutine(_life.Life());
    }

    public float GetSpeed() { return _speed; }

    public float GetHealth() { return _health; }
    public float GetHunger() { return _hunger; }
}
