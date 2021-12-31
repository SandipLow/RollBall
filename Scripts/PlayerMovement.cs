using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public PlayerMovement movement;
    public GameManager gm;
    public Text pspl;

    void FixedUpdate() {

        rb.AddForce(0, 0, 2000 * Time.deltaTime);

        if(Input.GetKey("d") & rb.position.y <= 3){
            rb.AddForce( 2000 * Time.deltaTime, 0, 0 );
        }

        else if(Input.GetKey("a") & rb.position.y <= 3){
            rb.AddForce( -2000 * Time.deltaTime, 0, 0 );
        }
    }

    void OnCollisionEnter(Collision collisionInfo) {
        
        if(collisionInfo.collider.tag == "Obstacle") {

            movement.enabled = false;
            gm.EndGame();

        }

    }

    void OnTriggerEnter ()
    {
        gm.CompleteLevel();
        movement.enabled = false;
    }

    
    public void PausePlay()
    {
        if (pspl.text == "Pause")
        {
            pspl.text = "Play";
            movement.enabled = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

        else 
        {
            pspl.text = "Pause";
            movement.enabled = true;
            rb.constraints = RigidbodyConstraints.None;
        }
    }
}
