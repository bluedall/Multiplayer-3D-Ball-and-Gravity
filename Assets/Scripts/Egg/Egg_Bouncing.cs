using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Bouncing : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidbody;
    [SerializeField] float Speed_ColliderwithPlayer;
    [SerializeField] float Speed_ColliderwithWalls;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Bouncing(collision.GetContact(0).normal, Speed_ColliderwithPlayer);
        }
        else
        {
            if (collision.transform.CompareTag("Wall"))
            {
                Bouncing(collision.GetContact(0).normal, Speed_ColliderwithWalls);
                print("Wall");
            }
        }
    }
    void Bouncing(Vector3 normal, float _speed)
    {
        _rigidbody.velocity = normal * _speed;
    }
}
