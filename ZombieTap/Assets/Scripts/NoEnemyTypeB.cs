using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoEnemyTypeB : EnemyCaract
{
    public override void ManejoDeVida()
    {
        game.jugador.Vida(3);
    }
    private void Update()
    {
        StayInSide();
        Rebotar();
    }


    private void OnEnable()
    {
        vidaEnemigo = 0;
        animacion.runtimeAnimatorController = animationController;
        movimientox = Random.Range(-1f, 1f);
    }
}
