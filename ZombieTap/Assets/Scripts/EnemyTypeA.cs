using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeA : EnemyCaract
{
    private void Start()
    {
        vidaEnemigo = 1;
        animacion.runtimeAnimatorController = animationController;
    }
   

   
}
