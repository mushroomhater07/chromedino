using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMan : MonoBehaviour
{

    [SerializeField]float counter, interval,offsetX;
    [SerializeField] private GameObject floor, parent;
        public GameObject gamover;
    void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            Instantiate(floor, new Vector3(offsetX, -1.6f, 0),transform.rotation,parent.transform);
            counter = interval;
        }
    }

    public void loadscreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}

