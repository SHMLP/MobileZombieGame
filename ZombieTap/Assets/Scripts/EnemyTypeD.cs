using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeD : EnemyCaract
{
    public override void ManejoDeVida()
    {
        vidaEnemigo -= 1;
    }


    private void OnEnable()
    {
        vidaEnemigo = 2;
        animacion.runtimeAnimatorController = animationController;
    }
}
