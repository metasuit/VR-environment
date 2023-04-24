using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform teleportHuman;
    public Transform teleportSelf;

    public float teleportDelay = 1.0f;
    private float lastTeleportTime;
    bool atHuman = true;
   

    private void Start()
    {
        lastTeleportTime = 0.0f;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Tab))
        {
            if(Time.time - lastTeleportTime >= teleportDelay)
            {
                if (atHuman == false)
                {
                    controller.Move(teleportHuman.position - transform.position);
                    atHuman = true;
                }
                else
                {
                    controller.Move(teleportSelf.position - transform.position);
                    atHuman = false;
                }
                lastTeleportTime = Time.time;
            }
            

        }
        
    }
}
