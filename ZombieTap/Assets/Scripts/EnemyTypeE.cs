using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeE : EnemyCaract
{
    private void OnEnable()
    {
        vidaEnemigo = 1;
        animacion.runtimeAnimatorController = animationController;
    }
}