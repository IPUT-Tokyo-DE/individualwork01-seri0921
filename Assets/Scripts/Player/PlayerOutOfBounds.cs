using UnityEngine;
using UnityEngine.SceneManagement; // シーンリロード用

public class PlayerOutOfBounds : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Debug.Log("Playerが画面外に出た！ゲーム終了！");

        // ゲームを終了させる（ここでは簡単にリスタートする例）
        SceneManager.LoadScene("KatachiCrashStart");
    }
}
