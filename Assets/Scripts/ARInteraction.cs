using UnityEngine;
using UnityEngine.SceneManagement;

public class ARInteraction : MonoBehaviour
{
    void Update()
    {
        // 터치 이벤트 감지
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // 터치된 화면 좌표를 Ray로 변환
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            // Ray와 충돌한 물체 확인
            if (Physics.Raycast(ray, out hit))
            {
                // 충돌한 물체의 태그가 "InteractiveObject"인 경우
                if (hit.collider.CompareTag("Heart"))
                {
                    // 터치한 물체가 "InteractiveObject" 태그를 가진 경우에 실행할 코드
                    SceneManager.LoadScene("HeartAnim");
                }
            }
        }
    }
}
