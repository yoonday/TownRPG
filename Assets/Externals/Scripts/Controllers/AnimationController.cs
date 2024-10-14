using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected TopDownController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>(); // 그냥 GetComponent를 쓰면 안움직여짐
        controller = GetComponent<TopDownController>();
    }
}
