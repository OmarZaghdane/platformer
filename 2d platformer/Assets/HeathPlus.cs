using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeathPlus : MonoBehaviour
{
    const float MAXHEALTH = 100f;
    float Health;
    
    public Slider HealthSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlusHealth"))
        {
            Health += MAXHEALTH;
            HealthSlider.value = Health / MAXHEALTH;
            Destroy(gameObject);
        }

    }
}
