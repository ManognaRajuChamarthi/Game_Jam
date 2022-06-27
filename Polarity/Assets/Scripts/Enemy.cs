using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //variables
    public GameObject[] obstacle;
    private float timer;
    public float max_time;

    // Start is called before the first frame update
    void Start()
    {
        GameObject new_Obstacle = Instantiate(obstacle[Random.Range(0,obstacle.Length)]);
        new_Obstacle.transform.position = transform.position + new Vector3(Random.Range(-10, 10), 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer > max_time)
        {
            GameObject new_Obstacle = Instantiate(obstacle[Random.Range(0, obstacle.Length)]);
            new_Obstacle.transform.position = transform.position + new Vector3(Random.Range(-10, 10), 0, 0);
            Destroy(new_Obstacle, 9);
            timer = 0;
        }
        timer += Time.deltaTime ;
    }
}
