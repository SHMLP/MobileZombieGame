using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeF : EnemyCaract
{
    public override void ManejoDeVida()
    {
        vidaEnemigo += 2;
    }



    private void OnEnable()
    {
        animacion.runtimeAnimatorController = animationController;
    }
}
