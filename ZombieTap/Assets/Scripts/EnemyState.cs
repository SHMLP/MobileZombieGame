using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    public delegate void ManejoDeVida(int numero);
    public static event ManejoDeVida manejoDeVida;

    public delegate void ManejoDeCombos();
    public static ManejoDeCombos manejoDeCombos;
    GameManager game;
    private void Start()
    {
        game = FindObjectOfType<GameManager>();
    }
    private void OnMouseDown()
    {
        
        gameObject.SetActive(false);
        foreach (EnemyCaract item in game.enemysTypeList)
        {
            EnemyCaract choose = GetComponent(item.GetType()) as EnemyCaract;
            if (choose.enabled == true)
            {
                if (choose.vidaEnemigo==0)
                {
                    manejoDeVida?.Invoke(3);
                }
                choose.enabled = false;
            }
        }

       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (EnemyCaract item in game.enemysTypeList)
        {
            EnemyCaract choose = GetComponent(item.GetType()) as EnemyCaract;
            if (collision.name == "MetaEnemigo" && choose.vidaEnemigo != 0 && choose.enabled == true)
            {
                manejoDeVida?.Invoke(1);
            }
        }
    }

}
