using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    private PlayerMover _mover;
    private Animator _anim;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        SwitchWalk();
    }

    private void SwitchWalk()
    {
        if(_mover.MoveX != 0 || _mover.MoveY != 0)
        {
            _anim.SetBool("isRun", true);
        }
        else
        {
            _anim.SetBool("isRun", false);
        }
    }
}
