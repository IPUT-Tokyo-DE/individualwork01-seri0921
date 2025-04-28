using UnityEngine;

public class TriangleBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �C���|�C���g�FgameObject.CompareTag ���g��
        if (collision.gameObject.CompareTag("CircleEnemy"))
        {
            Destroy(collision.gameObject);

            //�X�R�A���Z�i��F10�_�j
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
        // ��������\�͂������\�肪����΂�����
    }
}
