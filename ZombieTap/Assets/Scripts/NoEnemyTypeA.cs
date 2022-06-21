using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoEnemyTypeA : EnemyCaract
{


    private void OnEnable()
    {
        animacion.runtimeAnimatorController = animationController;
    }


}
