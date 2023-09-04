using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    [SerializeField] GameObject[] enemies;
    [SerializeField] Transform[] spawn_points;

    [SerializeField]  Transform player_transform;

    int random_point;
    int random_enemy;

   
    void Start()
    {

        // player_transform = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(spawnEnemies());
    }

    void Update()
    {
     
    }


    IEnumerator spawnEnemies()
    {
        //loop for every 0.3 seconds
        while (true)
        {
            
            random_enemy = Random.Range(0, enemies.Length);
            random_point= Random.Range(0, spawn_points.Length);

            yield return new WaitForSeconds(0.3f);

            if (player_transform!=null)
            {
                GameObject enemy = Instantiate
             (enemies[random_enemy],
             spawn_points[random_point].position,
             player_transform.rotation);
            }
         
        }

       

    }


 
}
