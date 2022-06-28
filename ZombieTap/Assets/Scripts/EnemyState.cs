using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    public RuntimeAnimatorController muerte;
    GameManager game;

    private void Start()
    {
        game = FindObjectOfType<GameManager>();

    }

    private void OnMouseDown()
    {
        if (game.isPause==false)
        {
            GetComponent<ZombieMovement>().enemyVelocityY = 0;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Animator>().runtimeAnimatorController = muerte;
            
            foreach (EnemyCaract item in game.enemysTypeList)
            {
                EnemyCaract choose = GetComponent(item.GetType()) as EnemyCaract;
                if (choose.enabled == true)
                {
                    if (choose.vidaEnemigo==0)
                    {
                        game.jugador.Vida(3);
                    }
                    else
                    {
                        int zombieDied= Random.Range(0, game.zombieDied.Length);
                        game.sounds.PlayOneShot(game.zombieDied[zombieDied]);
                        game.jugador.Score(1);
                    }
                    choose.enabled = false;
                }
            }
            StartCoroutine("WaitToFalse");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (EnemyCaract item in game.enemysTypeList)
        {
            EnemyCaract choose = GetComponent(item.GetType()) as EnemyCaract;
            if (collision.name == "MetaEnemigo" && choose.enabled == true)
            {
                if (choose.vidaEnemigo != 0)
                {
                    game.jugador.Vida(1);
                    game.jugador.Score(0);
                }
                choose.enabled = false;
                gameObject.SetActive(false);
            }
        }
    }

    IEnumerator WaitToFalse()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
}
