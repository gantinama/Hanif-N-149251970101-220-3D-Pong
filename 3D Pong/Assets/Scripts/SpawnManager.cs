using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public int maxBalls;
    public int spawnIntervals;
    public Vector3 spawnAreaMin;
    public Vector3 spawnAreaMax;
    public List<GameObject> balls;
    public List<GameObject> spawnArea;

    Vector3 pos;
    private int totalBalls = 0;
    // Start is called before the first frame update
    void Start()
    {
        // spawnArea = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        GenerateRandomBalls();
    }

    public void GenerateRandomBalls()
    {
        int randomSpawnIndex = Random.Range(0, spawnArea.Count);
        GenerateRandomBallsPos(randomSpawnIndex);
    }

    public void GenerateRandomBallsPos(int position)
    {
        if (totalBalls >= maxBalls)
        {
            return;
        }
        // if (position.x < spawnAreaMin.x ||
        //     position.x > spawnAreaMax.x ||
        //     position.y < spawnAreaMin.y ||
        //     position.y > spawnAreaMax.y ||
        //     position.z < spawnAreaMin.z ||
        //     position.z > spawnAreaMax.z)
        // {
        //     return;
        // }


        int randomIndex = Random.Range(0, balls.Count);
        pos = new Vector3(spawnArea[position].transform.position.x, spawnArea[position].transform.position.y, spawnArea[position].transform.position.z);
        Debug.Log(balls.Count);


        GameObject ball = Instantiate(balls[randomIndex], pos, Quaternion.identity);

        balls[randomIndex].SetActive(true);

        totalBalls += 1;
    }
}
