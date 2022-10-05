using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAlgae : MonoBehaviour
{
   // int health = 15;

    public GameObject algaePrefab; //need prefab with script so that it will keep spawning

    public healthplayer healthPlayer; //Spawner should have a reference to the script that controls the health

    //public DialogueManager dialogueManager;

    void Start()
    {
        InvokeRepeating("SpawnScum", 10.0f, 50.0f);
    }

    void SpawnScum()
    {
        GameObject newAlgae = Instantiate(algaePrefab); //create new algae
        newAlgae.GetComponent<algaePrefab>().hp = healthPlayer; //new algae needs the refrence to be set at runtime
    } //whatever script gets attached to the algae is the one refernced in <>


}