using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    //variables
    public float obstacleSpeed;
    

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * obstacleSpeed * Time.deltaTime;
    }

    
}
