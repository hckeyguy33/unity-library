using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeBounce : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    private bool updated; 
    // Start is called before the first frame update
    void Start()
    {
        updated = false;
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    void Update()
    {
        //rigidbody2D.AddForce(randomVector * 10f);
        float radius = 0.05f;

        if (updated)
        {
            updated = false;
        }
        else
        {

            Vector2 pos = Camera.main.WorldToViewportPoint(transform.position);
            rigidbody2D = this.GetComponent<Rigidbody2D>();

            if ((pos.x-radius/2) < 0.0)
            {
                Debug.Log("I am left of the camera's view.");

                //this.transform.position = Vector2.Reflect(pos, Vector2.right);
                rigidbody2D.position = new Vector2(this.transform.position.x + radius, transform.position.y);
                rigidbody2D.velocity = Vector2.Reflect(rigidbody2D.velocity, Vector2.right);
                updated = true;
            }

            if (1.0 < (pos.x + radius/2))
            {

                Debug.Log("I am right of the camera's view.");
                //this.transform.position = Vector2.Reflect(pos, Vector2.left);
                rigidbody2D.position = new Vector2(this.transform.position.x - radius, transform.position.y );
                rigidbody2D.velocity = Vector2.Reflect(rigidbody2D.velocity, Vector2.left);
                updated = true;
            }

            if (pos.y-0.05 < 0.0)
            {
                Debug.Log("I am below the camera's view.");
                //rigidbody2D.position = Vector2.Reflect(rigidbody2D.position, Vector2.down);
                Debug.Log("B Velocity: " + rigidbody2D.velocity);
                Debug.Log("B RB Position: " + rigidbody2D.position);
                Debug.Log("B World Position: " + pos);
                rigidbody2D.position = new Vector2(this.transform.position.x, transform.position.y+radius);
                rigidbody2D.velocity = Vector2.Reflect(rigidbody2D.velocity, Vector2.down);
                Debug.Log("A Velocity: " + rigidbody2D.velocity);
                Debug.Log("A RB Position: " + rigidbody2D.position);
                Debug.Log("A World Position: " + pos);
                updated = true;
            }

            if (1.0 < pos.y+0.05)
            {
                Debug.Log("I am above the camera's view.");
                //this.transform.position = Vector2.Reflect(pos, Vector2.up);
                rigidbody2D.position = new Vector2(this.transform.position.x, transform.position.y - radius);
                rigidbody2D.velocity = Vector2.Reflect(rigidbody2D.velocity, Vector2.up);
                updated = true;
            }

        }
        


    }
}
