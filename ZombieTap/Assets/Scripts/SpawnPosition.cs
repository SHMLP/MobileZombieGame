using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    Vector3 enemySpawnPosition;
    float enemyPositionX,spawnTime;
    public Transform rLimit, lLimit;
    public float tiempoAparicion;
    GameManager game;
 

    void Start()
    {
        lLimit.position = Camera.main.ViewportToWorldPoint(new Vector3(0.1f, 1, 0));
        rLimit.position = Camera.main.ViewportToWorldPoint(new Vector3(0.9f, 1, 0));
        game = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        
        enemySpawnPosition = transform.position;
        enemyPositionX = Random.Range(lLimit.position.x,rLimit.position.x);
        enemySpawnPosition.x = enemyPositionX;

        spawnTime += Time.deltaTime;
        if(spawnTime >= 3 / (1 + 1.5 * (game.levelFactor - 1)))
        {
            
            spawnTime = 0;
            int zombieBorn = Random.Range(0, game.zombieBorn.Length);
            game.sounds.PlayOneShot(game.zombieBorn[zombieBorn]);
            foreach (Transform item in game.listaEnemigos)
            {
                if (item.gameObject.activeInHierarchy==false)
                {
                    item.position = enemySpawnPosition;
                    item.GetComponent<BoxCollider2D>().enabled=true;
                    item.GetComponent<ZombieMovement>().enemyVelocityY = game.velocidadEnemigoY;
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
