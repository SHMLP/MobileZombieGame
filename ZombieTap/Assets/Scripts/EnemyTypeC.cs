using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeC : EnemyCaract
{
    float waitMovementX;
    bool xMove;
    private void OnEnable()
    {
        vidaEnemigo = 1;
        xMove = false;
        GetComponent<SpriteRenderer>().color = Color.white;
        animacion.runtimeAnimatorController = animationController;
        waitMovementX = Random.Range(0.3f, 1f);
    }

    private void Update()
    {
        StayInSide();
        Vector3 sides = Camera.main.WorldToViewportPoint(transform.position);
        if (sides.y <= waitMovementX && xMove==false)
        {
            movimientox = Random.Range(-1f, 1f);
            xMove = true;
        }
        if (xMove==true)
        {
            Rebotar();
        }
            
    }
    public override void ManejoDeVida()
    {
        throw new System.NotImplementedException();
    }
}
