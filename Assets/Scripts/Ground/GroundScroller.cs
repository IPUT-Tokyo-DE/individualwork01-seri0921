using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public float scrollSpeed = 2f;     // �n�ʂ̈ړ����x�i�������j
    public float resetPositionX = -20f; // �n�ʂ������荶�ɍs�����烊�Z�b�g
    public float startPositionX = 20f;  // ���Z�b�g��̈ʒu�i�E�[�j

    void Update()
    {
        // ���t���[�����Ɉړ�
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

        // ���[�𒴂�����E�Ƀ��[�v
        if (transform.position.x < resetPositionX)
        {
            Vector3 newPos = new Vector3(startPositionX, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
