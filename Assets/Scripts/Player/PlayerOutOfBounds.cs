using UnityEngine;
using UnityEngine.SceneManagement; // �V�[�������[�h�p

public class PlayerOutOfBounds : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Debug.Log("Player����ʊO�ɏo���I�Q�[���I���I");

        // �Q�[�����I��������i�����ł͊ȒP�Ƀ��X�^�[�g�����j
        SceneManager.LoadScene("KatachiCrashStart");
    }
}
