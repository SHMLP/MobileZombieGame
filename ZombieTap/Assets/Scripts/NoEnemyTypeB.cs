using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoEnemyTypeB : EnemyCaract
{


    private void OnEnable()
    {
        animacion.runtimeAnimatorController = animationController;
    }
}
