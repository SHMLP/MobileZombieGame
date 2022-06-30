using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeE : EnemyCaract
{
    public override void ManejoDeVida()
    {
        StartCoroutine(PainColorChange());
        vidaEnemigo -= 1;
    }

    private void Update()
    {
        StayInSide();
        Rebotar();
    }

    private void OnEnable()
    {
        vidaEnemigo = 2;
        animacion.runtimeAnimatorController = animationController;
        movimientox = Random.Range(-1f, 1f);
    }
}
