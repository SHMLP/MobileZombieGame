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
            foreach (EnemyCaract item in game.enemysTypeList)
            {
                EnemyCaract choose = GetComponent(item.GetType()) as EnemyCaract;
                if (choose.enabled == true)
                {
                    if (choose.vidaEnemigo==0)
                    {
                        choose.ManejoDeVida();
                        gameObject.SetActive(false);
                    }
                    else if (choose.vidaEnemigo == 1 && choose.up==false)
                    {
                        GetComponent<Animator>().runtimeAnimatorController = muerte;
                        GetComponent<ZombieMovement>().enemyVelocityY = 0;
                        GetComponent<BoxCollider2D>().enabled = false;
                        int zombieDied= Random.Range(0, game.zombieDied.Length);
                        game.sounds.PlayOneShot(game.zombieDied[zombieDied]);
                        game.jugador.Score(1);
                        choose.enabled = false;
                        StartCoroutine("WaitToFalse");
                    }
                    else
                    {
                        choose.ManejoDeVida();
                    }
                }
            }
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
                    if (choose.up==true)
                    {
                        game.jugador.Vida(choose.vidaEnemigo);
                        game.jugador.Score(1);
                    }
                    else
                    {
                        game.jugador.Vida(1);
                        game.jugador.Score(0);
                    }
                }
                else
                    game.jugador.Score(1);
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
