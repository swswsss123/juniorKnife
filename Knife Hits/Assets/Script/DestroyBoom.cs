using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBoom : MonoBehaviour
{
    [SerializeField] Vector2 direction;
    [SerializeField] float spin;
    Rigidbody2D rB;
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        rB.AddForce(direction);//давление
        rB.AddTorque(spin);//вращение
    }


}
