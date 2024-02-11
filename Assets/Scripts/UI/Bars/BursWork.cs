using UnityEngine;
using UnityEngine.UI;

public class BursWork : MonoBehaviour
{
    [SerializeField] private Hero _player;
    [SerializeField] private Image _healthBar;
    [SerializeField] private Image _hungerBar;

    private void Update()
    {
        _healthBar.fillAmount = _player.GetHealth() / 100f;
        _hungerBar.fillAmount = _player.GetHunger() / 100f;
    }
}
