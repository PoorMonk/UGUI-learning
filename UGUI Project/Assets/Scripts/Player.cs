using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float m_speed = 90.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * m_speed * Time.deltaTime);
	}

    public void ChangeSpeed(float newSpeed)
    {
        m_speed = newSpeed;
    }
}
