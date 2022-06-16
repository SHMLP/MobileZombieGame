using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    public delegate void ManejoDeVida(int numero);
    public static event ManejoDeVida manejoDeVida;

    public delegate void ManejoDeCombos();
    public static ManejoDeCombos manejoDeCombos;


    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name == "MetaEnemigo")
        {
            manejoDeVida?.Invoke(1);
        }
    }

}
