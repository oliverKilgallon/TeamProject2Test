using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public float m_Speed = 10f;
    private float m_HorizInput;
    private float m_RotInput;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        m_HorizInput = Input.GetAxis("Horizontal");
        m_RotInput = Input.GetAxis("Vertical");

        Vector3 v_Movement = new Vector3(m_HorizInput, 0, 0);
        transform.position += v_Movement * m_Speed * Time.deltaTime;
        transform.Rotate(Vector3.up,m_RotInput * m_Speed, Space.World);
    }
}
