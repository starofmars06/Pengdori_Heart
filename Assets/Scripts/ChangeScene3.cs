using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene3 : MonoBehaviour
{
    // ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    public void SwitchToNewScene3()
    {
        // "NewScene"�� ��ȯ�� ���� �̸��Դϴ�. ������ ����� ���� �̸����� �����ϼ���.
        SceneManager.LoadScene("Img_Tracking");
    }
}
