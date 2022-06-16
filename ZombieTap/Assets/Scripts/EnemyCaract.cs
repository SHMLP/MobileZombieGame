using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCaract : MonoBehaviour
{
    public int vidaEnemigo;
    protected SpriteRenderer skin;
    protected Animator animacion;

    // Start is called before the first frame update
    void Start()
    {
        skin = GetComponent<SpriteRenderer>();
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
