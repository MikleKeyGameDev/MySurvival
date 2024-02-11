using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private GameObject _dropItem;
    private Animator _animator;

    private bool _isTimeLeft = true;

    [SerializeField] private int _quantetyItemDrop;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void TakeDamage(float damage)
    {
        if (_isTimeLeft == true)
        {
            _health -= damage;
            _animator.Play("Hit");
            StartCoroutine(StopTime());
            _isTimeLeft = false;
        }

        if (_health <= 0)
        {
            DeadTree();
        }
    }

    private void DeadTree()
    {
        for (int i = 0; i < _quantetyItemDrop; i++)
        {
            GameObject obj = Instantiate(_dropItem, transform);
            obj.GetComponent<InteractoinItem>().FindInventory();
            obj.transform.parent = null;
        }

        Destroy(gameObject);
    }

    private IEnumerator StopTime()
    {
        yield return new WaitForSeconds(0.25f);
        _animator.Play("New State");
        _isTimeLeft = true;
    }
}
