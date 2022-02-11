using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEncapsulation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Bus m_bus = new Bus();
        m_bus.DateOfManufacture = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
