using UnityEngine;

public class EnemySpawnerTop : MonoBehaviour
{
    public GameObject enemyPrefab;    // 1種類の敵プレハブ
    public float spawnInterval = 2f;  // 生成間隔（秒）
    public float yOffset = 1f;        // カメラ上端からどれだけ上に出現させるか

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        // 指定間隔で敵を出現させる
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (enemyPrefab == null) return;

        // 画面の左端・右端のワールド座標を取得
        Vector2 leftEdge = mainCamera.ViewportToWorldPoint(new Vector2(0f, 0f));
        Vector2 rightEdge = mainCamera.ViewportToWorldPoint(new Vector2(1f, 0f));

        // X座標をランダムに決定（画面幅の範囲内）
        float spawnX = Random.Range(leftEdge.x, rightEdge.x);

        // Y座標はカメラの上端＋オフセット
        float spawnY = mainCamera.ViewportToWorldPoint(new Vector2(0f, 1f)).y + yOffset;

        // 敵の生成
        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
