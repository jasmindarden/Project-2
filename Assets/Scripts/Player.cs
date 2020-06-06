using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform tf;
    public float turnSpeed = 90f;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.Player = this.gameObject;
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -turnSpeed * Time.deltaTime);
        }
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
}
