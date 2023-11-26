using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    [SerializeField] private float speed, despawn; //-10
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
        if(transform.position.x < -39f) Destroy(this.gameObject);
    }
}
