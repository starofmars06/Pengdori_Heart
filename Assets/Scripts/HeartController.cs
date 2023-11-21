using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartController : MonoBehaviour
{
    private Vector2 touchStartPos;
    private Quaternion initialRotation;
    public GameObject heart;
    private float rotSpeed = 0.7f;
    private float initialScale;
    public float scaleSpeed = 0.03f;

    void Update()
    {
        //기존 코드는 x축 위주로만 회전이 가능하도록 작성되어 있음.
        /*
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    touchStartPos = touch.position;
                    initialRotation = heart.transform.rotation;
                    break;

                case TouchPhase.Moved:
                    float deltaX = touch.position.x - touchStartPos.x;
                    Quaternion newRotation = initialRotation * Quaternion.Euler(0f, -deltaX * rotSpeed, 0f);
                    heart.transform.rotation = newRotation;
                    touchStartPos = touch.position;
                    break;
            }
        }
        */


        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    touchStartPos = touch.position;
                    initialRotation = heart.transform.rotation;
                    break;

                case TouchPhase.Moved:
                    float deltaX = touch.position.x - touchStartPos.x;
                    float deltaY = touch.position.y - touchStartPos.y;

                    // 왼쪽으로 스와이프하면 오른쪽으로, 오른쪽으로 스와이프하면 왼쪽으로 회전하도록 수정
                    Quaternion newRotation = initialRotation * Quaternion.Euler(-deltaY * rotSpeed, -deltaX * rotSpeed, 0f);
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
