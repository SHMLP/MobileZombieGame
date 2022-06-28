using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeB : EnemyCaract
{


    private void OnEnable()
    {
        vidaEnemigo = 1;
        animacion.runtimeAnimatorController = animationController;
        movimientox = Random.Range(-1f, 1f);

    }

    private void Update()
    {
        movement.SideMovement(movimientox);
        Vector3 sides = Camera.main.WorldToViewportPoint(transform.position);
        StayInSide();
        if (sides.x >= 0.9)
            movimientox = -Mathf.Abs(movimientox);
        else if (sides.x <= 0.1)
            movimientox = Mathf.Abs(movimientox);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (movimientox>=0)
            movimientox = -Mathf.Abs(movimientox);
        else
            movimientox = Mathf.Abs(movimientox);
    }
}
