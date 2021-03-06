using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    const float MAXHEALTH = 100f;
    float Health;
    Animator Animator;
    public Slider HealthSlider;
    // Start is called before the first frame update
    void Start()
    {
        Health = MAXHEALTH;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Die()
    {
        Debug.Log("die");
        GetComponent<Animator>().SetBool("Dead",true);
        
    }
    public void TakeDamage(float amount)
    {
        Health -= amount;

        if (Health <= 0)
        {
        Health = 0;
        Die();
        
        }
        HealthSlider.value = Health / MAXHEALTH;
    }
   
}
