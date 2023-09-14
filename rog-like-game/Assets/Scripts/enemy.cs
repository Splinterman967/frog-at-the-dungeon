using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemy : MonoBehaviour
{     
    public float enemy_movespeed;
    [SerializeField] public float enemy_damage;
    [SerializeField] GameObject ExpPoint;  
    public float enemy_hp;
    public float scor_point;
    public Transform player_transform;
    public Vector3 player_direction;
    public float enemy_orig_hp;
    public float origSpeed;
    void Start()
    {
        enemy_orig_hp = enemy_hp;
        origSpeed = enemy_movespeed;
        //scor_point = enemy_hp;
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
            scor.changeScor(scor_point);
            AudioManager.Instance.PlaySFX("Ouh");
        }
    }

    void followPlayer()
    {
        if (player_transform !=null)
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
            AudioManager.Instance.PlaySFX("hurt");
            playerAttrabiutes.player_hp -= enemy_damage;
        }
    } 
}
