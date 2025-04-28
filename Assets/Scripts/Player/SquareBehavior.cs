using UnityEngine;

public class SquareBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // TagがBreakableのオブジェクトとぶつかったとき
        if (collision.gameObject.CompareTag("TriangleEnemy"))
        {
            Destroy(collision.gameObject);
        }
    }

    public void UseSpecial()
    {

    }
}
