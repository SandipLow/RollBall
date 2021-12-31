using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    public Text HighScore;
    public float score;
    public float HS;

    void FixedUpdate()
    {
        HS = PlayerPrefs.GetFloat("High Score");
        
        score = 500 + player.position.z;

        scoretext.text = "Score : " + score.ToString("0");

        if (HS<score) {
            HS = score;
        }

        HighScore.text = "High Score : " + HS.ToString("0");
        
        PlayerPrefs.SetFloat("High Score", HS);
    }
}
