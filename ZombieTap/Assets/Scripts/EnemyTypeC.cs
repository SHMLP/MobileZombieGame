using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeC : EnemyCaract
{
    private void OnEnable()
    {
        vidaEnemigo = 1;
        animacion.runtimeAnimatorController = animationController;
    }

    public override void ManejoDeVida()
    {
        throw new System.NotImplementedException();
    }
}
