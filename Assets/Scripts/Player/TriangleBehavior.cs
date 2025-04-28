using UnityEngine;

public class TriangleBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 修正ポイント：gameObject.CompareTag を使う
        if (collision.gameObject.CompareTag("CircleEnemy"))
        {
            Destroy(collision.gameObject);

            //スコア加算（例：10点）
            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore(10);
            }
        }

        if (collision.gameObject.CompareTag("TriangleEnemy"))
        {
            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.ReduceScore(10);
            }
        }

    }

    public void UseSpecial()
    {
        // 何か特殊能力を書く予定があればここに
    }
}
