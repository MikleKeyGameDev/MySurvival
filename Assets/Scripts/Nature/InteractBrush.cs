using Unity.VisualScripting;
using UnityEngine;

public class InteractBrush : MonoBehaviour
{
    private LifeBrushScript _life;

    private bool _isPlayer;
    private bool _isMousOver;

    private void Start()
    {
        _life = GetComponent<LifeBrushScript>();
    }

    private void Update()
    {
        InputPlayer();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
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
        if(_isPlayer == true && Input.GetKey(KeyCode.E) == true)
        {
            _life.Harvest();
        }
        else
        {
            return;
        }
    }
}
