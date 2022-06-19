using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeA : EnemyCaract
{
    public override void iniciar()
    {
        vidaEnemigo = 1;
        animacion.runtimeAnimatorController = animationController;
    }


   
}
