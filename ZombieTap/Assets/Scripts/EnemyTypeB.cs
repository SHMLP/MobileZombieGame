using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeB : EnemyCaract
{

    private void Start()
    {
        vidaEnemigo = 1;
        animacion.runtimeAnimatorController = animationController;
        movimientox = Random.Range(-1f, 1f);
    }


    private void Update()
    {
            movement.SideMovement(movimientox); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        movimientox *= -1;
    }
}
