using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene2 : MonoBehaviour
{
    // ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    public void SwitchToNewScene2()
    {
        // "NewScene"�� ��ȯ�� ���� �̸��Դϴ�. ������ ����� ���� �̸����� �����ϼ���.
        SceneManager.LoadScene("Heart_Detail");
    }
}
