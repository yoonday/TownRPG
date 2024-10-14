using UnityEngine;
using UnityEngine.InputSystem; // 반드시 추가해야 함

public class PlayerInputController : TopDownController
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main; // 메인 카메라 가져오기
    }

    private void LateUpdate() // 스크립트 라이프 사이클 설명 : 다른 오브젝트 업데이트 후 작업 수행(카메라 등)
    {
        camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized; // 정규화
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>(); // 마우스 위치
 
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim); // 카메라 범위
        newAim = (worldPos - (Vector2)transform.position).normalized; // 방향 계산

        CallLookEvent(newAim);
    }

}