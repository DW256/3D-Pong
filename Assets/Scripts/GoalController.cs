using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public BallsManager ballsManager;
    public GameObject paddle;
    private Paddle owner;
    public StatsManager manager;

    public int maxKebobolan;
    // Start is called before the first frame update
    void Start()
    {
        owner = paddle.GetComponent<PaddleController>().paddleName;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            manager.addScore(collision.GetComponent<BallController>().lastPaddle);
            manager.addKebobolan(owner);
            //Debug.Log(owner);
            ballsManager.RemoveBall(collision.gameObject);
            if (manager.kebobolan[(int)owner]>=maxKebobolan) {
                gameObject.GetComponent<Collider>().isTrigger = false;
                paddle.tag = "Untagged";
                manager.checkPlayers();
                paddle.SetActive(false);
                
            }
        }
    }
}
