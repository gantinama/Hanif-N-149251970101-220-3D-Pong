using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;
    public string lastPlayer;
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("speed " + speed + "reset pos " + resetPosition);
    }

    public void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag == "Player 1")
        {
            lastPlayer = "Player 1";
            Debug.Log(lastPlayer);
        }
        if (collision.gameObject.tag == "Player 2")
        {
            lastPlayer = "Player 2";
            Debug.Log(lastPlayer);
        }
        if (collision.gameObject.tag == "Player 3")
        {
            lastPlayer = "Player 3";
            Debug.Log(lastPlayer);
        }
        if (collision.gameObject.tag == "Player 4")
        {
            lastPlayer = "Player 4";
            Debug.Log(lastPlayer);
        }
    }

    public void ResetBall()
    {
        transform.position = resetPosition;
        // Destroy(gameObject);
        // rig.velocity = speed;
    }

    // public void MoveBall(Vector3 direction)
    // {
    //     rig.velocity = direction;
    //     Debug.Log(rig.velocity);
    // }
}
