using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public float scrollSpeed = 2f;     // 地面の移動速度（左向き）
    public float resetPositionX = -20f; // 地面がこれより左に行ったらリセット
    public float startPositionX = 20f;  // リセット後の位置（右端）

    void Update()
    {
        // 毎フレーム左に移動
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

        // 左端を超えたら右にワープ
        if (transform.position.x < resetPositionX)
        {
            Vector3 newPos = new Vector3(startPositionX, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
