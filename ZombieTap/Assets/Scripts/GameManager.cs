using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public EnemyCaract[] enemysTypeList;
    public SpawnPosition spawnPosition;

    private void Awake()
    {
        enemysTypeList = enemyPrefab.GetComponents<EnemyCaract>();
        spawnPosition = FindObjectOfType<SpawnPosition>();
        spawnPosition.enabled = true;
    }
    void Start()
    {

       

    }


    void Update()
    {
        
    }
 
}
