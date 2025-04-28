using UnityEngine;

public class CircleBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Tag��Breakable�̃I�u�W�F�N�g�ƂԂ������Ƃ�
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
