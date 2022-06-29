using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeA : EnemyCaract
{
    public override void ManejoDeVida()
    {
        throw new System.NotImplementedException();
    }
 
    private void OnEnable()
    {
        vidaEnemigo = 1;
        animacion.runtimeAnimatorController = animationController;
    }
}
