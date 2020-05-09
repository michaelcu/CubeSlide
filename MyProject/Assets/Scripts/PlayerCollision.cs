using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public Player_Movement movement;
    

    //Works as long as there's a rigidbody or collider
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log("We hit something.");

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
         
        }
    }

}
