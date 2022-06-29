using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyCaract : MonoBehaviour
{
    public int vidaEnemigo;
    public bool rebotar=false;
    protected Animator animacion;
    protected float movimientox;
    protected ZombieMovement movement;
    public RuntimeAnimatorController animationController;
    public GameManager game;

    private void Awake()
    {
        movement = GetComponent<ZombieMovement>();
        animacion = GetComponent<Animator>();
        game = FindObjectOfType<GameManager>();
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

    public void Rebotar()
    {

            this.rebotar = true;
            movement.SideMovement(movimientox);
            Vector3 sides = Camera.main.WorldToViewportPoint(transform.position);
            if (sides.x >= 0.9)
                movimientox = -Mathf.Abs(movimientox);
            else if (sides.x <= 0.1)
                movimientox = Mathf.Abs(movimientox);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rebotar==true)
        {
            if (movimientox >= 0)
                movimientox = -Mathf.Abs(movimientox);
            else
                movimientox = Mathf.Abs(movimientox);
        }
    }

    public abstract void ManejoDeVida();
}
