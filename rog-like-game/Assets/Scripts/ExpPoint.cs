using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPoint : MonoBehaviour
{
    public  Transform player_transform;

    public Vector3 player_direction;

    float exp_speed = 8f;

    private void Start()
    {

        player_transform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        moveToPlayer();
    }

    void moveToPlayer()
    {
       
        if (player_transform != null)
        {
            player_direction = player_transform.position - transform.position;

            player_direction.Normalize();

            float enemy_speed = exp_speed * Time.deltaTime;

            // transform.Translate(player_direction);

            transform.position = Vector2.MoveTowards(transform.position, player_transform.position, enemy_speed);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            ExpBar.Exp += 25;
            AudioManager.Instance.PlaySFX("expPointCollect");
            //exp point yok olacak ve experience hanemize 10 puan eklencek

        }
    }
}
