using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour
{
    public Rigidbody[] players;

    public void FixedUpdate()
    {
        rotate();
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene("Menu Scene");
    }

    public void rotate()
    {
        if (Input.GetKey("left"))
        {
            players[0].angularVelocity = new Vector3(0, -2, 0);
        }
        else
        if (Input.GetKey("right"))
        {
            players[0].angularVelocity = new Vector3(0, 2, 0);
        }
        else
        if (Input.GetKey("a"))
        {
            players[1].angularVelocity = new Vector3(0, -2, 0);
        }
        else
        if (Input.GetKey("d"))
        {
            players[1].angularVelocity = new Vector3(0, 2, 0);
        }
        else
        if (Input.GetKey("w"))
        {
            players[2].angularVelocity = new Vector3(2, 0, 0);
        }
        else
        if (Input.GetKey("s"))
        {
            players[2].angularVelocity = new Vector3(-2, 0, 0);
        }
        else
        if (Input.GetKey("up"))
        {
            players[3].angularVelocity = new Vector3(2, 0, 0);
        }
        else
        if (Input.GetKey("down"))
        {
            players[3].angularVelocity = new Vector3(-2, 0, 0);
        }
        else
        {
            foreach (Rigidbody rig in players)
            {
                rig.angularVelocity = Vector3.zero;
            }
        }

    }
}
