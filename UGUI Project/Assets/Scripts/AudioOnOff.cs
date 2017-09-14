using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioOnOff : MonoBehaviour {

    public GameObject m_GameObjectOn;
    public GameObject m_GameObjectOff;

    private Toggle m_Toggle;
    //private bool m_flag;
	// Use this for initialization
	void Start () {
        m_Toggle = GetComponent<Toggle>();
        OnSwith();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnSwith()
    {
        //Debug.Log(isOn);
        m_GameObjectOn.SetActive(m_Toggle.isOn);
        m_GameObjectOff.SetActive(!m_Toggle.isOn);
    }
}
