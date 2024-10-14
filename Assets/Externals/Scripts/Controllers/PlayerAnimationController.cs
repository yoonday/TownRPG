using System;
using UnityEngine;

public class PlayerAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");
    private static readonly int isTalking = Animator.StringToHash("isTalking"); // 말하는 모션 다르게

    private readonly float magnituteTreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake(); 
    }

    protected void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteTreshold); // 움직인 거리 비교 후 실행
    }

    private void Talking()
    {
       animator.SetBool(isTalking, true);
    }
}
