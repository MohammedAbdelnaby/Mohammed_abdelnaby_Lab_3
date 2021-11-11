using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab6PhysicsSystem : MonoBehaviour
{
    public Vector3 gravity = new Vector3(0, -9.81f, 0);
    public List<Lab6Physics> lab6Physics = new List<Lab6Physics>(); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < lab6Physics.Count; i++)
        {
            lab6Physics[i].velocity += gravity * Time.deltaTime;
        }
    }
}
