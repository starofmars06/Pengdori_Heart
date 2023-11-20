using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // 버튼 클릭 시 호출되는 메서드
    public void SwitchToNewScene()
    {
        // "NewScene"은 전환할 씬의 이름입니다. 실제로 사용할 씬의 이름으로 변경하세요.
        SceneManager.LoadScene("HeartAnim");
    }
}
