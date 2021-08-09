using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Idle (bool idle)
    {
        anim.SetBool(Constants.Animations.IDLE_ANIMATION, idle);
    }
    public void Run(bool run)
    {
        anim.SetBool(Constants.Animations.RUN_ANIMATION, run);
    }

    public void Jump()
    {
        anim.SetTrigger(Constants.Animations.JUMP_ANIMATION);
    }

    public void TowerJump()
    {
        anim.SetTrigger(Constants.Animations.TOWERJUMP_ANIMATION);
    }

    public void Fall()
    {
        anim.SetTrigger(Constants.Animations.FALL_ANIMATION);
    }

    public void PenaltyKick()
    {
        anim.SetTrigger(Constants.Animations.PENALTYKICK_ANIMATION);
    }

    public void CheerUp()
    {
        anim.SetTrigger(Constants.Animations.CHEERUP_ANIMATION);
    }
}
