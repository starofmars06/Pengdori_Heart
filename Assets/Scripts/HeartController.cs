using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    private Vector2 touchStartPos;
    private Quaternion initialRotation;
    public GameObject heart;
    private float rotSpeed = 0.7f;
    private float initialScale;
    public float scaleSpeed = 0.03f;


    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // 터치가 시작된 위치 저장
                    touchStartPos = touch.position;
                    initialRotation = heart.transform.rotation;
                    break;

                case TouchPhase.Moved:
                    // 터치 이동 시 모델 회전

                    float deltaX = touch.position.x - touchStartPos.x;

                    // 초기 회전값에 누적된 회전값을 더하여 현재의 회전값을 계산
                    Quaternion newRotation = initialRotation * Quaternion.Euler(0f, -deltaX * rotSpeed, 0f);

                    // 모델에 새로운 회전값 적용
                    heart.transform.rotation = newRotation;

                    touchStartPos = touch.position;
                    break;
            }
        }
        else if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            Vector2 touchSize1 = touch1.position - touch2.position;
            Vector2 touchSize2 = touch1.deltaPosition - touch2.deltaPosition;

            Vector2 touchStartPos1 = touch1.position - touch1.deltaPosition;
            Vector2 touchStartPos2 = touch2.position - touch2.deltaPosition;

            float prevTouchDeltaMag = (touchStartPos1 - touchStartPos2).magnitude;
            float touchDeltaMag = (touch1.position - touch2.position).magnitude;

            float deltaMagnitudeDiff = touchDeltaMag - prevTouchDeltaMag;

            // deltaMagnitudeDiff 값이 양수면 거리가 증가, 음수면 거리가 감소
            if (deltaMagnitudeDiff > 0)
            {
                heart.transform.localScale += heart.transform.localScale * scaleSpeed;
            }
            else if (deltaMagnitudeDiff < 0)
            {
                heart.transform.localScale -= heart.transform.localScale * scaleSpeed;
            }

        }
    }
}
