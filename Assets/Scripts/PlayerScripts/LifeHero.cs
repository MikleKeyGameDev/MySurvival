using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHero : MonoBehaviour
{
    [SerializeField] private float _lifeValue;
    
    private Hero _hero;

    private void Start()
    {
        _hero = GetComponent<Hero>();
        StartCoroutine(Life());
    }

    public IEnumerator Life()
    {
        yield return new WaitForSeconds(_lifeValue);
        _hero.LifeCicle();
    }
}
