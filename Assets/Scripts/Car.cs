using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car : MonoBehaviour
{
    public int horsepower;
    protected float m_DateOfManufacture;
    public float DateOfManufacture
    {
        get { return m_DateOfManufacture; }
        set
        {
            if(value < 0.0f)
            {
                Debug.LogError("生产日期不能输入负数！");
            }
            else
            {
                m_DateOfManufacture = value;
            }
        }
    }
    protected float verticalInput;
    protected Rigidbody carRb;
    protected abstract void Hoot();

    protected virtual void Move()
    {
        verticalInput = Input.GetAxis("Vertical");
        if (carRb == null)
        {
            carRb = GetComponent<Rigidbody>();
        }
        carRb.AddForce(Vector3.forward * horsepower * verticalInput, ForceMode.Force);
    }
}
