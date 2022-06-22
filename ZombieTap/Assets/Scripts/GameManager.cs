using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public EnemyCaract[] enemysTypeList;
    public SpawnPosition spawnPosition;
    public TextMeshProUGUI score;
    private void Awake()
    {
        enemysTypeList = enemyPrefab.GetComponents<EnemyCaract>();
        spawnPosition = FindObjectOfType<SpawnPosition>();
    }
    void Start()
    {

       

    }


    void Update()
    {
        
    }
 
}
