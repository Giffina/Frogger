using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    public AudioSource audSrc;
    private void OnTriggerEnter2D()
    {
        Debug.Log("You Won!");
        Score.CurrentScore += 1;
        audSrc.Play();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}