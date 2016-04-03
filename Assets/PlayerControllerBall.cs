using UnityEngine;
using System.Collections;

public class PlayerControllerBall : MonoBehaviour
{
    private Rigidbody rb;
    private Transform trans;
    private Actions actions;

    private float speedFactor = 0.0f;
    private float speed = 0.0f;
    //private float accelerationDelta = 0.0f;
    //private float accelerationTime = 2.00f;
    private float maxSpeed = 0.1f;
    private bool mStartRunning;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        actions = GetComponent<Actions>();
    }

    void performRunning()
    {
        //accelerationDelta += Time.deltaTime;

        //if( accelerationDelta > accelerationTime )
        //{
        //    accelerationDelta = accelerationTime;
        //}

        //speedFactor = accelerationDelta / accelerationTime;
        //speed = speedFactor * maxSpeed;
        
        speed = speedFactor * maxSpeed;
        actions.Run();

    }

    void FixedUpdate()
    {
        // Performed before physics calculation.
        //rb.velocity

        if ( Input.GetKey( KeyCode.Space ) )
        {
            speedFactor = 1.0f;
            mStartRunning = true;
        }

        if ( mStartRunning && Input.GetKey(KeyCode.UpArrow))
        {
            speedFactor += 0.10f;
            mStartRunning = true;
        }
        else if (mStartRunning && Input.GetKeyUp(KeyCode.DownArrow))
        {
            speedFactor -= 0.10f;
            mStartRunning = true;
        }

        if (mStartRunning)
        {
            performRunning();
            trans.Translate(new Vector3(0, 0, speed));
        }

        //if( speed > 0 )
        //{
        //    actions.Run();
        //    speed -= 0.0005f;
        //}
        //else
        //{
        //    actions.Stay();
        //    speed = 0;
        //}

        //trans.Translate(new Vector3(0, 0, speed));


        //float moveHorizontal = Input.GetAxis("Horizontal");
        ////float moveVertical = Input.GetAxis("Vertical");

        ////Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        ////rb.AddForce(movement);

        //if( moveHorizontal == 0 )
        //{
        //    actions.Stay();
        //}
        //else
        //{
        //    actions.Run();
        //}

        //trans.Translate(new Vector3(0, 0, moveHorizontal * 0.1f));
    }
}
