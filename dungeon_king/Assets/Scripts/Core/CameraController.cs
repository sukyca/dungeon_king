using UnityEngine;
using UnityEngine; using System.Collections;

public class CameraController : MonoBehaviour
{
    //Room camera
    [SerializeField] private float speed;
    private float currentPosX;

    private float currentPosY;
    private Vector3 velocity = Vector3.zero;

    //Follow player
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;
    // private Animator anim;
    // private float lookAhead;
    // private float currentPosY;
    // private float lastPosY;
    // public Vector3 offset;
    
    // public GameObject character;

    // private void Awake()
    // {
        // character=GameObject.FindGameObjectsWithTag("Player")[0];
        // anim = character.GetComponent<Animator>();
        // currentPosY=GameObject.FindGameObjectsWithTag("Player")[0].transform.position.y;
    // }

    private void Update()
    {
        //Room camera
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, currentPosY, transform.position.z), ref velocity, speed);
        // transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
        // currentPosY=GameObject.FindGameObjectsWithTag("Player")[0].transform.position.y;

        // Debug.Log("current: " + currentPosY.ToString());
        // Debug.Log("last: " + lastPosY.ToString());

        //Follow player
        //     if (currentPosY < lastPosY && ! anim.GetBool("grounded"))
        //     {
        //         transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, offset.z);
        //     }

        //     lastPosY=GameObject.FindGameObjectsWithTag("Player")[0].transform.position.y;
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
        currentPosY = _newRoom.position.y;
    }
}