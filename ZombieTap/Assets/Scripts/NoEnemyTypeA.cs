using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoEnemyTypeA : EnemyCaract
{
    public override void ManejoDeVida()
    {
        game.jugador.Vida(3);
    }


    private void OnEnable()
    {
        animacion.runtimeAnimatorController = animationController;
    }
}
