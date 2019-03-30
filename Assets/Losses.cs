using UnityEngine;
using UnityEngine.UI;

public class Losses : MonoBehaviour
{
    public static int CurrentScore = 0;

    public Text scoreText;

    void Start()
    {
        scoreText.text = "Losses: " + CurrentScore.ToString();
    }

}
