using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxBallAmount;

    public int spawnInterval;
    private float timer;

    public List<GameObject> ballTemplateList;
    public List<GameObject> ballList;
    // Start is called before the first frame update
    void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
        GenerateRandomBall();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandomBall();
            timer -= spawnInterval;
        }
    }

    private void GenerateRandomBall()
    {
        if (ballList.Count >= maxBallAmount)
        {
            return;
        }

        int randomIndex = Random.Range(0, ballTemplateList.Count);
        GameObject ball = Instantiate(ballTemplateList[randomIndex], ballTemplateList[randomIndex].transform.position, Quaternion.identity, spawnArea);
        ball.SetActive(true);

        ballList.Add(ball);
    }
    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }


}
