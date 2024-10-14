using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{

    [SerializeField] private SpriteRenderer playerRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotatePlayer(direction);
    }

    private void RotatePlayer(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        playerRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        

    }
}