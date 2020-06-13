using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform tf;
    public float turnSpeed = 90f; //Degrees per second
    public float moveSpeed = 5f; //Meters per second
                                 // Start is called before the first frame update

    void Start()
    {
        GameManager.instance.Player = this.gameObject;
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleRotation();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // tf.Translate(Vector3.up * moveSpeed * Time.deltaTime, Space.Self);
            tf.position += tf.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }



    public void Shoot()
    {
        //TODO: Implement Shooting.
        Debug.Log("Shooting not implemented yet.");
    }


    public void HandleRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -turnSpeed * Time.deltaTime);
        }

        void Die()
        {
            //TODO: Write death code here
            Destroy(this.gameObject);
        }

        void OnCollisionEnter2D(Collision2D otherObject)
        {
            //If the player runs into something, they should die.
            Die();
        }


        void OnDestroy()
        {
            GameManager.instance.Player = null;
        }
    }
}