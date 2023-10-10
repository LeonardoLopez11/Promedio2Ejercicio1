using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyestatico : MonoBehaviour
{
    public GameObject bala;
    public Transform origendedisparo;
    private float attackspeed = 2;
    private float attackspeed2;



    // Start is called before the first frame update
    void Start()
    {
        attackspeed2 = Time.time + attackspeed;
    }


    private void DispararEnemigo()
    {
        Instantiate(bala, origendedisparo.position, origendedisparo.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= attackspeed2)
        {
            DispararEnemigo();
            attackspeed2 = Time.time + attackspeed;
        }
    }
}
