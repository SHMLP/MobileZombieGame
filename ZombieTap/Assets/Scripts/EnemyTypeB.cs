using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeB : EnemyCaract
{
    Camera camara;

    private void OnEnable()
    {
        vidaEnemigo = 1;
        animacion.runtimeAnimatorController = animationController;
        movimientox = Random.Range(-1f, 1f);
        camara = FindObjectOfType<Camera>();
    }

    private void Update()
    {
        movement.SideMovement(movimientox);
        Vector3 sides = camara.WorldToViewportPoint(transform.position);
        if (sides.x >= 0.9)
            movimientox = -Mathf.Abs(movimientox);
        else if (sides.x <= 0.1)
            movimientox = Mathf.Abs(movimientox);
    }
}
