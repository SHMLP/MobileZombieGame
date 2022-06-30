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

    public override void ManejoDeVida()
    {
        throw new System.NotImplementedException();
    }
}
