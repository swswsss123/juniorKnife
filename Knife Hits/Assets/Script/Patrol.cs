using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    private bool moveright = true;
    public Transform detection;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right* speed * Time.deltaTime);// движение накавальни
        RaycastHit2D infoDetection = Physics2D.Raycast(detection.position, Vector2.down, 2f);
        if(infoDetection.collider == false)
        {
            if(moveright == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveright = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                moveright = true;
            }
        }
    }
}
