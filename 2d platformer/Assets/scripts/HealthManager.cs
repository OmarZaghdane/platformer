﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public const float MAXHEALTH = 100f;
    float Health;
    Animator Animator;
    public Slider HealthSlider;
    // Start is called before the first frame update
    void Start()
    {
        Health = MAXHEALTH;

    }

    void Die()
    {
        Debug.Log("die");
        GetComponent<Animator>().SetBool("Dead", true);
        //Time.timeScale = 0f;
        SceneManager.LoadScene(SceneNames.Score.ToString());
    }
    public void TakeDamage(float amount)
    {
        GetComponent<AudioSource>().Play();
        Health -= amount;

        if (Health <= 0)
        {
            Health = 0;
            Die();

        }
        HealthSlider.value = Health;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlusHealth"))
        {
            Debug.Log("functioniscalled");
            Health += 10;
            HealthSlider.value = Health;
            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log(other.tag);

        }


    }
}


public enum SceneNames
{
    Game, Score
}