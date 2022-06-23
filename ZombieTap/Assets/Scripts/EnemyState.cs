using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    GameManager game;
    Jugador jugador;
    private void Start()
    {
        game = FindObjectOfType<GameManager>();
        jugador = FindObjectOfType<Jugador>();
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
                        jugador.Vida(3);
                    }
                    else
                    {
                        int score;
                        int.TryParse(game.score.text, out score);
                        score += 25 * jugador.Combo(1); 
                        game.score.text = score.ToString();
                        
                    }
                    choose.enabled = false;
                }
            }
            gameObject.SetActive(false);
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
                    jugador.Vida(1);
                    jugador.Combo(0);
                }
                choose.enabled = false;
                gameObject.SetActive(false);
            }
        }
    }

    
}
