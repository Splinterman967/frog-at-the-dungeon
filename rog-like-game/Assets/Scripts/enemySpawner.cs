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
    [SerializeField] GameObject DangerZone;
    int random_point;
    int random_enemy;
    bool isSpawning = true;
    public float enemy_spawn_period = 1;
    float boss_spawn_time = 10;
    float medium_enemy_spwan_time = 10;
    float big_enemy_spwan_time = 10;
    float huge_enemy_spwan_time = 10;
    void Start()
    {
        // player_transform = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(spawnEnemies());
        StartCoroutine(evolveEnemies());
    }
    IEnumerator sayac()
    {
        yield return new WaitForSeconds(1f);          
    }     
    IEnumerator evolveEnemies()
    {
        yield return new WaitForSeconds(medium_enemy_spwan_time);
        {
            enemies[2] = medium_enemy;
        }
        yield return new WaitForSeconds(big_enemy_spwan_time);
        {
            enemies[3] = big_enemy;
        }
        yield return new WaitForSeconds(huge_enemy_spwan_time);
        {
            enemies[4] = huge_enemy;
            DangerZone.SetActive(true);
        }
        yield return new WaitForSeconds(boss_spawn_time);
        {
            Instantiate(BOSS,spawn_points[0].position,player_transform.rotation);
            //isSpawning = false;           
            boss_spawn_time += 5;
            enemy_spawn_period += 5;
            medium_enemy_spwan_time = 5;
            big_enemy_spwan_time = 5;
            huge_enemy_spwan_time = 5;
            //StopCoroutine(spawnEnemies());
            DangerZone.SetActive(false);

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
