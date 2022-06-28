using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{

    public float enemyVelocityY;

    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * enemyVelocityY * Time.deltaTime); 
    }

    public void SideMovement(float movimientox)
    {
        transform.Translate(new Vector3(movimientox, 0, 0)* enemyVelocityY * Time.deltaTime);
    }


}
