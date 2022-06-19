using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoEnemyTypeA : EnemyCaract
{
  
    public override void iniciar()
    {
        animacion.runtimeAnimatorController = animationController;
    }
}
