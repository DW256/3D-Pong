using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Paddle
{
    Bottom = 0, Top = 1, Left = 2, Right = 3
}

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rig;
    public Paddle lastPaddle;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionExit(Collision collision)
    {
        switch (collision.gameObject.name)
        {
            case ("Paddle B"):
                lastPaddle = Paddle.Bottom;
                break;
            case ("Paddle T"):
                lastPaddle = Paddle.Top;
                break;
            case ("Paddle L"):
                lastPaddle = Paddle.Left;
                break;
            case ("Paddle R"):
                lastPaddle = Paddle.Right;
                break;
            default:
                //Debug.Log(lastPaddle);
                break;
        }
    }
}
