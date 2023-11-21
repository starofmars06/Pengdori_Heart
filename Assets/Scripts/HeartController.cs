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
                    // ��ġ�� ���۵� ��ġ ����
                    touchStartPos = touch.position;
                    initialRotation = heart.transform.rotation;
                    break;

                case TouchPhase.Moved:
                    // ��ġ �̵� �� �� ȸ��

                    float deltaX = touch.position.x - touchStartPos.x;

                    // �ʱ� ȸ������ ������ ȸ������ ���Ͽ� ������ ȸ������ ���
                    Quaternion newRotation = initialRotation * Quaternion.Euler(0f, -deltaX * rotSpeed, 0f);

                    // �𵨿� ���ο� ȸ���� ����
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

            // deltaMagnitudeDiff ���� ����� �Ÿ��� ����, ������ �Ÿ��� ����
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
