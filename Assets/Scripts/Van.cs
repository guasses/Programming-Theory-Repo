using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Van : Car
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();//Inheritance  ABSTRACTION
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Hoot();
        }
    }

    protected override void Hoot()// POLYMORPHISM
    {
        Debug.Log("Van is honking!");
    }
}
