using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    Vector3 enemySpawnPosition;
    float enemyPositionX,spawnTime;
    public Transform rLimit, lLimit;
    public float tiempoAparicion;
    public Transform enemigos;
    public List<Transform> listaEnemigos;
    GameManager game;

    void Start()
    {
        game = FindObjectOfType<GameManager>();
        for (int i = 0; i < enemigos.childCount; i++)
        {
            listaEnemigos.Add(enemigos.GetChild(i));
        }
    }

    void Update()
    {
        
        enemySpawnPosition = transform.position;
        enemyPositionX = Random.Range(rLimit.position.x,lLimit.position.x);
        enemySpawnPosition.x = enemyPositionX;

        spawnTime += Time.deltaTime;
        if (spawnTime >= tiempoAparicion)
        {
            
            spawnTime = 0;
            foreach (Transform item in listaEnemigos)
            {
                if (item.gameObject.activeInHierarchy==false)
                {

                    item.position = enemySpawnPosition;
                    item.gameObject.SetActive(true);
                    EnemyType(item);
                    break;
                }
            }
        }
        
    }

    void EnemyType(Transform tipoenemigo)
    {
        int random = Random.Range(0, game.enemysTypeList.Length);
        EnemyCaract choose = tipoenemigo.GetComponent(game.enemysTypeList[random].GetType()) as EnemyCaract;
        choose.enabled = true;
    }
}
