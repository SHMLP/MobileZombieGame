using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyCaract : MonoBehaviour
{
    public int vidaEnemigo;
    protected Animator animacion;
    protected float movimientox;
    protected ZombieMovement movement;
    public RuntimeAnimatorController animationController;
    

    private void Awake()
    {
        movement = GetComponent<ZombieMovement>();
        animacion = GetComponent<Animator>();
    }

    private void Update()
    {
        StayInSide();
    }

    public void StayInSide()
    {
        Vector3 sides = Camera.main.WorldToViewportPoint(transform.position);
        Vector3 derecha = Camera.main.ViewportToWorldPoint(new Vector3(0.9f, sides.y, sides.z));
        Vector3 izquierda = Camera.main.ViewportToWorldPoint(new Vector3(0.1f, sides.y, sides.z));
        if (sides.x >= 0.9)
            transform.position = derecha;
        else if (sides.x <= 0.1)
            transform.position = izquierda;
    }
}
