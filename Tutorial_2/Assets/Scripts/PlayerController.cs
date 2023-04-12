using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is 
    public float HorizontalInputcalled;
    public float speed = 10.0f;
    public float board_limit = 10.0f;
    public GameObject projectilePrefab;
    //  before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            //launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
         if (transform.position.x < -board_limit)
        {
            transform.position = new Vector3(-board_limit, transform.position.y, transform.position.z);
        }
        if (transform.position.x > board_limit)
        {
            transform.position = new Vector3(board_limit, transform.position.y, transform.position.z);
        }
        else{
        HorizontalInputcalled = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInputcalled * Time.deltaTime * speed);
            
        }

    }
}
