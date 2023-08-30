using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class wand : MonoBehaviour
{
    [Header("Projectile")]
    [SerializeField] GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine( Fire());
    }

    // Update is called once per frame
    void Update()
    {


       
    }

    void OnFire()
    {
      
    }

    IEnumerator Fire()
    {

        while (true)
        {

            yield return new WaitForSeconds(0.5f);

            GameObject spell_ball;
           
            
            spell_ball = Instantiate(projectile, transform.position, transform.rotation);


        }
       
    }


}
