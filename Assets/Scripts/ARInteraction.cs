using UnityEngine;
using UnityEngine.SceneManagement;

public class ARInteraction : MonoBehaviour
{
    void Update()
    {
        // ��ġ �̺�Ʈ ����
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // ��ġ�� ȭ�� ��ǥ�� Ray�� ��ȯ
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            // Ray�� �浹�� ��ü Ȯ��
            if (Physics.Raycast(ray, out hit))
            {
                // �浹�� ��ü�� �±װ� "InteractiveObject"�� ���
                if (hit.collider.CompareTag("Heart"))
                {
                    // ��ġ�� ��ü�� "InteractiveObject" �±׸� ���� ��쿡 ������ �ڵ�
                    SceneManager.LoadScene("HeartAnim");
                }
            }
        }
    }
}
