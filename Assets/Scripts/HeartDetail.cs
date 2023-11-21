using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartDetail : MonoBehaviour
{
    public int num;

    void Update()
    {
        // ��ġ �Է� ����
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // ��ġ�� ���۵Ǿ��� ��
            if (touch.phase == TouchPhase.Began)
            {
                // ��ġ ������ ȭ�� ��ǥ�� Ray�� ��ȯ�Ͽ� �浹 �˻�
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    // ��ġ�� ������Ʈ�� ���� ��ũ��Ʈ�� �پ� �ִ� ������Ʈ���
                    if (hit.transform.gameObject == gameObject)
                    {
                        // num�� ���� ���� �ε�
                        switch (num)
                        {
                            case 1:
                                SceneManager.LoadScene("Detail1");
                                break;
                            case 2:
                                SceneManager.LoadScene("Detail2");
                                break;
                            case 3:
                                SceneManager.LoadScene("Detail3");
                                break;
                            case 4:
                                SceneManager.LoadScene("Detail4");
                                break;
                            case 5:
                                SceneManager.LoadScene("Detail5");
                                break;
                            case 6:
                                SceneManager.LoadScene("Detail6");
                                break;
                            case 7:
                                SceneManager.LoadScene("Detail7");
                                break;
                            case 8:
                                SceneManager.LoadScene("Detail8");
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
