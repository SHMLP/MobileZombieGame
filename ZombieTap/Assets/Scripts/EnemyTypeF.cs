using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeF : EnemyCaract
{
    public override void ManejoDeVida()
    {
        StartCoroutine(PainColorChange());
        vidaEnemigo += 1;
    }



    private void OnEnable()
    {
        up = true;
        vidaEnemigo = 0;
        animacion.runtimeAnimatorController = animationController;
    }
}
