using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // ��ư Ŭ�� �� ȣ��Ǵ� �޼���
    public void SwitchToNewScene()
    {
        // "NewScene"�� ��ȯ�� ���� �̸��Դϴ�. ������ ����� ���� �̸����� �����ϼ���.
        SceneManager.LoadScene("HeartAnim");
    }
}
