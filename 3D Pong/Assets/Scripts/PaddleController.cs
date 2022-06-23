using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public int lifePoint;
    public KeyCode rightKey; 
    public KeyCode leftKey;
    public KeyCode upKey; 
    public KeyCode downKey;
    public VictoryController victory;

    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = GetInput(); 
         
        // move object 
        MoveObject(movement); 

        if (lifePoint == 0)
        {
            gameObject.SetActive(false);
            victory.GetComponent<VictoryController>().RemovePlayer(gameObject);
        }
    }

    //mengambil key dari keyboard
    private Vector3 GetInput() 
    { 
        if (Input.GetKey(rightKey)) 
        { 
            return Vector3.right * speed; 
        } 
        if (Input.GetKey(leftKey))
        { 
            return Vector3.left * speed; 
        } 
        if (Input.GetKey(upKey)) 
        { 
            return Vector3.forward * speed; 
        } 
        if (Input.GetKey(downKey))
        { 
            return Vector3.back * speed; 
        } 
         
        return Vector3.zero; 
    } 
    
    //move object
    private void MoveObject(Vector3 movement) 
    { 
        // Debug.Log(transform.localScale.y);
        transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    } 

    public void LosingLP(string player)
    {
        if (gameObject.tag == player)
        {
            lifePoint -= 1;
        }
    }
}
