using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

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
        if (Input.GetMouseButton(0))
        {
            _anim.Play("Attack");
            _anim.SetBool("isAttack", true);
            StartCoroutine(StopTimeAnim());
        }
        else if(_mover.MoveX != 0 || _mover.MoveY != 0)
        {
            _anim.SetBool("isRun", true);
        }
        else
        {
            _anim.SetBool("isRun", false);
        }
    }

    private IEnumerator StopTimeAnim()
    {
        yield return new WaitForSeconds(0.45f);
        _anim.SetBool("isAttack", false);
    }
}
