using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderscript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("detected");
        Debug.Log(GameObject.Find("gameOverScreen"));
        FindObjectOfType<GameMan>().gamover.SetActive(true);
        Time.timeScale = 0;
    }

}
