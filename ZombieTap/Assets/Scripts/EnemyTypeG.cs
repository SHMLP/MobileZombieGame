using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeG : EnemyCaract
{
    public override void ManejoDeVida()
    {
        vidaEnemigo += 1;
    }

    private void Update()
    {
        StayInSide();
        Rebotar();
    }

    private void OnEnable()
    {
        up = true;
        vidaEnemigo = 0;
        animacion.runtimeAnimatorController = animationController;
        movimientox = Random.Range(-1f, 1f);
    }
}
