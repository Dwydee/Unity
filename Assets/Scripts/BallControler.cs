using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(3, 4, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
