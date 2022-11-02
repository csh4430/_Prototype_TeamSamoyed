using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : PlayerBehaviour
{
    public PlayerBase thisBase { get; set; }
    private Animator _animator = null;

    private int MoveHash = Animator.StringToHash("Move");
    private int AttackHash = Animator.StringToHash("Attack");
    public void Awake()
    {
        _animator = thisBase.GetComponentInChildren<Animator>();
    }

    public void Start()
    {

        
    }

    public void Update()
    {
        _animator.SetBool(MoveHash, thisBase.isMoving);
        if (thisBase.isAttack)
        {
            _animator.SetTrigger(AttackHash);
        }
    }

    public void LateUpdate()
    {

    }
}
