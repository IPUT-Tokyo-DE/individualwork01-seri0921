using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;    // 生成する敵プレハブ
    public float spawnInterval = 2f;  // 生成間隔（秒）

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (enemyPrefab == null) return;

        // 画面右半分 (X=0.5〜1.0) でランダムなX
        float randomViewportX = Random.Range(0.5f, 1f);

        // 画面全体 (Y=0.0〜1.0) でランダムなY
        float randomViewportY = Random.Range(0.2f, 0.3f);

        // ビューポート座標（0〜1）をワールド座標に変換
        Vector2 spawnPosition = mainCamera.ViewportToWorldPoint(new Vector2(randomViewportX, randomViewportY));

        // 敵を生成
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
