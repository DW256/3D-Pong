using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public Paddle paddleName;
    public float speed;
    public KeyCode key1;
    public KeyCode key2;

    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (rig.rotation.y == 0)
        {
            if (Input.GetKey(key1)) //paddle up
            {
                return Vector3.left * speed;
            }
            else if (Input.GetKey(key2)) //paddle down
            {
                return Vector3.right * speed;
            }
        }
        else
        {
            if (Input.GetKey(key1)) //paddle up
            {
                return Vector3.forward * speed;
            }
            else if (Input.GetKey(key2)) //paddle down
            {
                return Vector3.back * speed;
            }
        }
        
        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        //Debug.Log("TEST: " + movement);
        rig.velocity = movement;
    }
}
