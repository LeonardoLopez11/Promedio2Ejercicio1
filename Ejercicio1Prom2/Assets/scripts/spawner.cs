using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private enemy enemy;
    public GameObject Enemigo;
    private int nivel = 1;
    private int cantidadEnemigosNivel = 1;
    private float aumentoVelocidad = 1; 


    // Start is called before the first frame update
    void Start()
    {
        enemy = FindObjectOfType<enemy>();
        StartCoroutine(SpawnEnemigos());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     IEnumerator SpawnEnemigos()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(10f);

            
            nivel++;
            cantidadEnemigosNivel++;
            enemy.velocidadMovimiento += aumentoVelocidad;
            Debug.Log("Se aumentó la velocidad de los enemigos a" + enemy.velocidadMovimiento);
            for (int i = 0; i < cantidadEnemigosNivel; i++)
            {
                SpawnEnemigo();
            }
        }
    }
    void SpawnEnemigo()
    {
        
        Vector3 spawnPosition = transform.position + Random.insideUnitSphere * 5f;

        
        spawnPosition.y = 0.5f;

        
        Instantiate(Enemigo, spawnPosition, Quaternion.identity);
    }
}
