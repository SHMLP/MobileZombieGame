using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPosition : MonoBehaviour
{
    Vector3 enemySpawnPosition;
    float enemyPositionX,spawnTime;
    public Transform rLimit, lLimit;
    public float tiempoAparicion;
    public GameObject[] enemigos;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Skin = Random.
        enemySpawnPosition = transform.position;
        enemyPositionX = Random.Range(rLimit.position.x,lLimit.position.x);
        enemySpawnPosition.x = enemyPositionX;

        if (spawnTime >= tiempoAparicion)
        {
            foreach (GameObject item in enemigos)
            {
                if (item.activeInHierarchy==false)
                {
                    item.transform.position = enemySpawnPosition;
                    item.SetActive(true);
                    EnemyType(item);
                    break;
                }
            }
            spawnTime = 0;
            print(spawnTime);
        }
        spawnTime += Time.deltaTime;
    }

    void EnemyType(GameObject tipoenemigo)
    {
        print("Empece");
        int random;
        random = Random.Range(1, 3);
        switch (random)
        {
            case 1:
                tipoenemigo.GetComponent<EnemyTypeA>().inicar();
                break;
            case 2:
                tipoenemigo.GetComponent<EnemyTypeB>().inicar();
                break;
        }
    }
}
