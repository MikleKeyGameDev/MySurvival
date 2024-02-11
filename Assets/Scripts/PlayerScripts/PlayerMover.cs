using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private const string AxisX = "Horizontal";
    private const string AxisY = "Vertical";

    private Hero _player;
    private Rigidbody2D _rb;

    private bool _isRight = true;

    public float MoveX { get; private set; }
    public float MoveY { get; private set; }

    private void Start()
    {
        _player = GetComponent<Hero>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Walk();
    }

    private void Walk()
    {
        MoveX = Input.GetAxis(AxisX);
        MoveY = Input.GetAxis(AxisY);
        Vector2 move = new Vector2(MoveX * _player.GetSpeed(), MoveY * _player.GetSpeed());

        _rb.velocity = move;

        if(MoveX > 0 && _isRight == false)
        {
            Flip();
        }
        else if(MoveX < 0 && _isRight == true)
        {
            Flip();
        }
    }

    private void Flip()
    {
        _isRight = !_isRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1f;
        transform.localScale = scaler;
    }
}
