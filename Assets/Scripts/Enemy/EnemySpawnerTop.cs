using UnityEngine;

public class EnemySpawnerTop : MonoBehaviour
{
    public GameObject enemyPrefab;    // 1��ނ̓G�v���n�u
    public float spawnInterval = 2f;  // �����Ԋu�i�b�j
    public float yOffset = 1f;        // �J������[����ǂꂾ����ɏo�������邩

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        // �w��Ԋu�œG���o��������
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (enemyPrefab == null) return;

        // ��ʂ̍��[�E�E�[�̃��[���h���W���擾
        Vector2 leftEdge = mainCamera.ViewportToWorldPoint(new Vector2(0f, 0f));
        Vector2 rightEdge = mainCamera.ViewportToWorldPoint(new Vector2(1f, 0f));

        // X���W�������_���Ɍ���i��ʕ��͈͓̔��j
        float spawnX = Random.Range(leftEdge.x, rightEdge.x);

        // Y���W�̓J�����̏�[�{�I�t�Z�b�g
        float spawnY = mainCamera.ViewportToWorldPoint(new Vector2(0f, 1f)).y + yOffset;

        // �G�̐���
        Vector2 spawnPosition = new Vector2(spawnX, spawnY);
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
