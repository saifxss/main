using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public float RotationSpeed ;
    public float strengthOfAttraction = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward,-RotationSpeed);
 
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "majdi")
        {
            //col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.forward, (ForceMode2D)(-RotationSpeed));
           /* Vector3 pos = transform.position;
            pos.y = Vector3.Dot(Input.gyro.gravity, Vector3.up) * movementScale;
            transform.position = pos;*/
        }
    }
}
