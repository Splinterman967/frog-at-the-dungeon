using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerInputs : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float moveSpeed;
    [SerializeField] Transform gunPoint;
   
   // [SerializeField] float bulletSpeed = 20f;


    Transform playerTransform;
    Vector3 moveInput;
    Vector2 lookDirection;
    float lookAngle;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        moveSpeed = playerAttrabiutes.player_movespeed;
    }

    // Update is called once per frame
    void Update()
    {
       // setlookDirection();
        Move();
    }

    void OnMove(InputValue value)
    {

        moveInput = value.Get<Vector2>();
      

    }

    void OnFire()
    {

        //GameObject bullet = Instantiate(bulletPrefab, gunPoint.position, gunPoint.rotation);
        //bullet.transform.position = gunPoint.position;
        //bullet.transform.rotation = Quaternion.Euler(0, 0, lookAngle);
        //bullet.GetComponent<Rigidbody2D>().velocity = gunPoint.right * bulletSpeed;

    }
    void Move()
    {
        playerTransform.Translate(moveInput * moveSpeed * Time.deltaTime);
    }

    void setlookDirection()
    {
        lookDirection = Camera.main.WorldToScreenPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        gunPoint.rotation = Quaternion.Euler(0, 0, lookAngle);
    }

}
