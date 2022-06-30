using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeD : EnemyCaract
{
    public override void ManejoDeVida()
    {
        StartCoroutine(PainColorChange());
        vidaEnemigo -= 1;
    }


    private void OnEnable()
    {
        vidaEnemigo = 2;
        GetComponent<SpriteRenderer>().color = Color.white;
        animacion.runtimeAnimatorController = animationController;
    }
}
