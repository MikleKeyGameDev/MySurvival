using UnityEngine;

public class InteractBrush : MonoBehaviour
{
    private LifeBrushScript _life;

    private bool _isPlayer;

    private void Update()
    {
        InputPlayer();
    }

    private void Start()
    {
        _life = GetComponent<LifeBrushScript>();
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
        if(_isPlayer == true && Input.GetKeyDown(KeyCode.E))
        {
            _life.Harvest();
        }
        else
        {
            return;
        }
    }
}
