using UnityEngine;

public class MoveByTouch : MonoBehaviour
{
    public Rigidbody rb;
    void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = touch.position;

            // Debug.Log(touchPosition.x);
            // Debug.Log(touchPosition.y);
            // Debug.Log(touchPosition.z);

            if(touchPosition.x > 800f & rb.position.y <= 3){
                rb.AddForce( 2000 * Time.deltaTime, 0, 0 );
            }

            else if(touchPosition.x < 800f & rb.position.y <= 3){
                rb.AddForce( -2000 * Time.deltaTime, 0, 0 );
            }
        }

    }
}
