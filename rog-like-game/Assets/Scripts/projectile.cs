using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    Rigidbody2D projectile_rigidbody;
    [SerializeField] float projectile_damage;
    // Start is called before the first frame update
    void Start()
    {
        moveEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().enemy_hp -= projectile_damage;
        }
    }

    void moveEnemy()
    {
        projectile_damage = 20;

        Vector2 force = new Vector2(Random.Range(-360, 360), Random.Range(-360, 360));

        projectile_rigidbody = GetComponent<Rigidbody2D>();

        projectile_rigidbody.AddForce(force);
    }
}
