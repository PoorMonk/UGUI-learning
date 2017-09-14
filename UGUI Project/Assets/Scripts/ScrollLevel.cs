using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollLevel : MonoBehaviour, IBeginDragHandler, IEndDragHandler {

    private ScrollRect m_ScrollRect;
    private float[] m_levelArray = new float[]{ 0, 0.333333f, 0.666666f, 1};

    private float m_targetScrollPostion;
    bool m_bFlag = false;
    public int m_iSmooth = 4;
    public Toggle[] m_ToggleArray;
    // Use this for initialization
    void Start () {
        m_ScrollRect = GetComponent<ScrollRect>();
	}
	
	// Update is called once per frame
	void Update () {
		if(m_bFlag == false)
        {
            m_ScrollRect.horizontalNormalizedPosition = Mathf.Lerp(m_ScrollRect.horizontalNormalizedPosition,
                m_targetScrollPostion, Time.deltaTime * m_iSmooth);
        }
	}

    public void OnBeginDrag(PointerEventData eventData)
    {
        m_bFlag = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        m_bFlag = false;
        float posX = m_ScrollRect.horizontalNormalizedPosition;
        //Debug.Log(posX);
        int index = 0;
        float tempPos = Mathf.Abs(m_levelArray[index] - posX);
        for (int i = 0; i < m_levelArray.Length; ++i)
        {
            float tempVal = Mathf.Abs(m_levelArray[i] - posX);
            if(tempVal < tempPos)
            {
                tempPos = tempVal;
                index = i;
            }
        }
        //m_ScrollRect.horizontalNormalizedPosition = m_levelArray[index];
        m_targetScrollPostion = m_levelArray[index];
        m_ToggleArray[index].isOn = true;
        //Debug.Log(index);
    }

    public void MoveToPage1()
    {
        m_targetScrollPostion = m_levelArray[0];
    }

    public void MoveToPage2()
    {
        m_targetScrollPostion = m_levelArray[1];
    }

    public void MoveToPage3()
    {
        m_targetScrollPostion = m_levelArray[2];
    }

    public void MoveToPage4()
    {
        m_targetScrollPostion = m_levelArray[3];
        //Debug.Log("MoveToPage4");
    }
}
