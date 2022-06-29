using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeB : EnemyCaract
{


    private void OnEnable()
    {
        vidaEnemigo = 1;
        animacion.runtimeAnimatorController = animationController;
        movimientox = Random.Range(-1f, 1f);

    }

    private void Update()
    {

        StayInSide();
        Rebotar();

    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (movimientox>=0)
    //        movimientox = -Mathf.Abs(movimientox);
    //    else
    //        movimientox = Mathf.Abs(movimientox);
    //}

    public override void ManejoDeVida()
    {
        throw new System.NotImplementedException();
    }
}
