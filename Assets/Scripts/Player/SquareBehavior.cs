using UnityEngine;

public class SquareBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Tag��Breakable�̃I�u�W�F�N�g�ƂԂ������Ƃ�
        if (collision.gameObject.CompareTag("TriangleEnemy"))
        {
            Destroy(collision.gameObject);
        }
    }

    public void UseSpecial()
    {

    }
}
