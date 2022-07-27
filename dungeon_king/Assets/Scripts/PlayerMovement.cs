using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D body;
   [SerializeField] float speed;

   private void Awake(){
        body = GetComponent<Rigidbody2D>();
   }

   private void Update(){
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if(Input.GetKey(KeyCode.Space))
            body.velocity = new Vector2(body.velocity.x, speed);
   }
}
