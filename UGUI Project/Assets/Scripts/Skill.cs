using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour {

    private Image m_Image;

    public float m_coldTime = 2.0f;
    public bool m_isClick = false;
    private float m_Time = 0.0f;
    public KeyCode m_KeyCode;

	// Use this for initialization
	void Start () {
        m_Image = GameObject.Find("FillImage").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(m_KeyCode))
        {
            m_isClick = true;
        }

		if(m_isClick)
        {
            m_Time += Time.deltaTime;
            m_Image.fillAmount = (m_coldTime - m_Time) / m_coldTime;

            if(m_coldTime < m_Time)
            {
                m_isClick = false;
                m_Time = 0.0f;
            }
        }
	}

    /// <summary>
    /// 点击技能
    /// </summary>
    public void OnClickBtn()
    {
        m_Image.fillAmount = 1;
        m_isClick = true;
        //Debug.Log("-----");
    }
}
