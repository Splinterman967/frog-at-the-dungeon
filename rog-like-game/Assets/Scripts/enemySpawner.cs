using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    [SerializeField] GameObject[] enemies;
    [SerializeField] GameObject medium_enemy;
    [SerializeField] GameObject big_enemy;
    [SerializeField] GameObject huge_enemy;
    [SerializeField] GameObject BOSS;

    [SerializeField] Transform[] spawn_points;

    [SerializeField] Transform player_transform;

    int random_point;
    int random_enemy;
    bool isSpawning = true;
    public float enemy_spawn_period = 1;


    void Start()
    {

        // player_transform = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(spawnEnemies());
        StartCoroutine(evolveEnemies());
    }

    void Update()
    {

    }


    IEnumerator sayac()
    {

        yield return new WaitForSeconds(1f);

       
    }

    IEnumerator evolveEnemies()
    {

        yield return new WaitForSeconds(5);
        {
            enemies[2] = medium_enemy;
        }

        yield return new WaitForSeconds(5);
        {
            enemies[3] = big_enemy;
        }

        yield return new WaitForSeconds(5);
        {
            enemies[4] = huge_enemy;
        }

        yield return new WaitForSeconds(5);
        {
            Instantiate(BOSS,spawn_points[0].position,player_transform.rotation);
            isSpawning = false;
            StopCoroutine(spawnEnemies());
        }
    }

    IEnumerator spawnEnemies()
    {
        //loop for every 0.3 seconds
        while (isSpawning)
        {

            random_enemy = Random.Range(0, enemies.Length);
            random_point = Random.Range(0, spawn_points.Length);

            yield return new WaitForSeconds(enemy_spawn_period);

            if (player_transform != null)
            {
               
                    GameObject enemy = Instantiate(
                enemies[random_enemy],
                spawn_points[random_point].position,
                player_transform.rotation);

                    if (enemy_spawn_period >= 0.02f)
                    {
                        enemy_spawn_period -= 0.001f;
                    }

                







            }





        }



    }
}
