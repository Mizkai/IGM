using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAlgae : MonoBehaviour
{

    public GameObject algaePrefab; //this is the prefab with AlgaeHealthDown script 

    public HeartBar healthPlayer; //Spawner should have a reference to the script that controls the health

    void Start()
    {
        InvokeRepeating("SpawnScum", 30.0f, 60.0f); //time to start loop and time of loop
    }

    void SpawnScum()
    {
        if (algaePrefab == null) return;
        GameObject newAlgae = Instantiate(algaePrefab); //create new algae
        newAlgae.GetComponent<AlgaeHealthDown>().hp = healthPlayer; //new algae needs the refrence to be set at runtime 

    } //whatever script gets attached to the algae is the one refernced in <>


}