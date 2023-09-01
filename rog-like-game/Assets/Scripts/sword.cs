using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sword : MonoBehaviour
{

    [SerializeField] float sword_damage;
    [SerializeField] TextMeshProUGUI damage_text;
    // Start is called before the first frame update
    void Start()
    {
        sword_damage = 50;
    }

    // Update is called once per frame
    void Update()
    {
        spinSword();
    }

    void spinSword()
    {
        transform.Rotate(0, 0, -200 * Time.deltaTime, Space.Self);

        transform.localPosition = new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().enemy_hp -= sword_damage;

            Instantiate(damage_text, collision.gameObject.transform.position, collision.gameObject.transform.rotation);

            damage_text.text = sword_damage.ToString();
        }
    }
}
