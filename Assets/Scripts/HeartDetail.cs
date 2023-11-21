using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartDetail : MonoBehaviour
{
    public int num;

    void Update()
    {
        // 터치 입력 감지
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // 터치가 시작되었을 때
            if (touch.phase == TouchPhase.Began)
            {
                // 터치 지점의 화면 좌표를 Ray로 변환하여 충돌 검사
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    // 터치된 오브젝트가 현재 스크립트가 붙어 있는 오브젝트라면
                    if (hit.transform.gameObject == gameObject)
                    {
                        // num에 따라 씬을 로드
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
