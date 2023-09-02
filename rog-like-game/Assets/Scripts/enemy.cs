using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;




public class enemy : MonoBehaviour
{

    [SerializeField] float enemy_movespeed;
    [SerializeField] public float enemy_damage;
    [SerializeField] GameObject ExpPoint;

    public float enemy_hp;

    public float scor_point;

    public Transform player_transform;

    public Vector3 player_direction;
   
    void Start()
    {
        scor_point = enemy_hp;
        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        followPlayer();
        isEnemyDead();
    }


    void isEnemyDead()
    {

        if (enemy_hp <= 0)
        {
            Destroy(this.gameObject);
            dropExpPoint();
        }
    }


    void followPlayer()
    {
        if (!playerAttrabiutes.isPlayerDead())
        {
            player_direction = player_transform.position - transform.position;

            player_direction.Normalize();

            float enemy_speed = enemy_movespeed * Time.deltaTime;

            // transform.Translate(player_direction);

            transform.position = Vector2.MoveTowards(transform.position, player_transform.position, enemy_speed);
        }
       
    }

    private void dropExpPoint()
    {
        Vector3 position = transform.position;
        GameObject expPoint = Instantiate( ExpPoint, position, Quaternion.identity);
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        //When enemys hits the player
        if (collision.gameObject.CompareTag("Player"))
        { 
            playerAttrabiutes.player_hp -= enemy_damage;

        }
    }




}
