using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // シングルトン（どこからでもアクセス可能）

    public int score = 0;
    public TMP_Text scoreText; // TextMeshPro の UI テキスト（任意）
    public int clearScore = 300; // クリアに必要なスコア

    void Awake()
    {
        // 他のインスタンスがあれば破棄、なければこのインスタンスを保持
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("スコア加算！現在スコア: " + score);

        // UI表示を更新
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

        Debug.Log("スコア減少！現在スコア: " + score);

        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    void Update()
    {
        if (score >= clearScore)
        {
            Debug.Log("スコアがクリア条件に到達！クリアシーンに遷移！");
            SceneManager.LoadScene("ClearScene");
        }
    }

}
