using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthplayer : MonoBehaviour
{
    //Health
    public int maxHealth = 15;
    public int minHealth = 0;
    public int currentHealth;

    public Bars healthBar;

    public DialogueManager dialogueManager;

    // Start is called before the first frame update
    void Start()
    {
        //Health
        currentHealth = minHealth;
        healthBar.SetMinHealth(minHealth);
       
    }

 
    public void Recover(int heal)
    {
        //health
        currentHealth += heal;
        healthBar.SetHealth(currentHealth);
       
    }
}
