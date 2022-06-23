using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BallDirections(string tag, Vector3 pos)
    {
        if (tag == "SP1")
        {
            Debug.Log(GameObject.Find("Ball").GetComponent<BallController>().speed);
            direction = new Vector3(-2f, 1f, 2f);
            Debug.Log(direction + " " + pos);
            GameObject.Find("Ball").GetComponent<BallController>().speed = direction;
            GameObject.Find("Ball").GetComponent<BallController>().resetPosition = pos;
        }
        if (tag == "SP2")
        {
            Debug.Log(GameObject.Find("Ball").GetComponent<BallController>().speed);
            direction = new Vector3(2f, 1f, 2f);
            GameObject.Find("Ball").GetComponent<BallController>().speed = direction;
            GameObject.Find("Ball").GetComponent<BallController>().resetPosition = pos;
        }
        if (tag == "SP3")
        {
            Debug.Log(GameObject.Find("Ball").GetComponent<BallController>().speed);
            direction = new Vector3(-2f, 1f, -2f);
            GameObject.Find("Ball").GetComponent<BallController>().speed = direction;
            GameObject.Find("Ball").GetComponent<BallController>().resetPosition = pos;
        }
        if (tag == "SP4")
        {
            Debug.Log(GameObject.Find("Ball").GetComponent<BallController>().speed);
            direction = new Vector3(2f, 1f, -2f);
            GameObject.Find("Ball").GetComponent<BallController>().speed = direction;
            GameObject.Find("Ball").GetComponent<BallController>().resetPosition = pos;
        }
    }
}
