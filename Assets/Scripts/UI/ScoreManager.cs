using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // �V���O���g���i�ǂ�����ł��A�N�Z�X�\�j

    public int score = 0;
    public TMP_Text scoreText; // TextMeshPro �� UI �e�L�X�g�i�C�Ӂj
    public int clearScore = 300; // �N���A�ɕK�v�ȃX�R�A

    void Awake()
    {
        // ���̃C���X�^���X������Δj���A�Ȃ���΂��̃C���X�^���X��ێ�
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("�X�R�A���Z�I���݃X�R�A: " + score);

        // UI�\�����X�V
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void ReduceScore(int amount)
    {
        score -= amount;
        if (score < 0) score = 0;

        Debug.Log("�X�R�A�����I���݃X�R�A: " + score);

        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    void Update()
    {
        if (score >= clearScore)
        {
            Debug.Log("�X�R�A���N���A�����ɓ��B�I�N���A�V�[���ɑJ�ځI");
            SceneManager.LoadScene("ClearScene");
        }
    }

}
