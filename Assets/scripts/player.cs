using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int maxHealth = 25;
    public int currentHealth;
    public healthbar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
  

        public void OnCollisionEnter(Collision collision)
        {
            Debug.Log("collosion");
        }
        public void OnTriggerEnter(Collider other)
        {
            Debug.Log("triggered");
            if (other.gameObject.tag == "damageobject")
            {
                TakeDamage(5);
            }
      
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);
    }
}
