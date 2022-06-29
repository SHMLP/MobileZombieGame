using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeG : EnemyCaract
{
    public override void ManejoDeVida()
    {
        vidaEnemigo += 2;
    }

    private void Update()
    {
        StayInSide();
        Rebotar();
    }

    private void OnEnable()
    {
        animacion.runtimeAnimatorController = animationController;
        movimientox = Random.Range(-1f, 1f);
    }
}
