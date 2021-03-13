using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetScore : MonoBehaviour
{
    public Text Score;
    public Text Scoore;
    public Text hs;
    public GameObject medalargent;
    public GameObject medalor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = PlayerPrefs.GetInt("SavedScore").ToString();
        hs.text = PlayerPrefs.GetInt("HighScore").ToString();
      
        
    }
}
