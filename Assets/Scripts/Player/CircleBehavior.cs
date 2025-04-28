using UnityEngine;

public class CircleBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // TagがBreakableのオブジェクトとぶつかったとき
        if (collision.gameObject.CompareTag("Breakable"))
        {
            Destroy(collision.gameObject);
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
        
    }
}
