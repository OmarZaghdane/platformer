using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int Score;
    public Text scoreTxt;
    public AudioSource coinPick;
    // Update is called once per frame
    void Update()
    {
        if (Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", Score);
        }
        PlayerPrefs.SetInt("SavedScore", Score);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Score++;
            coinPick.Play();
            Destroy(collision.gameObject);
            scoreTxt.text = Score.ToString();
        }
    }
}
