using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDuration : MonoBehaviour
{
    [SerializeField] float VelocityBallY;
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * VelocityBallY * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Fin");
    }


}
