using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class SelectButton : MonoBehaviour
{
    [SerializeField] bool _maru;
    [SerializeField] bool _batu;
    EventSystem _eventSystem;

    public void PushButton(string s)
    {
        int[] nums = Array.ConvertAll(s.Split(), int.Parse);
        _eventSystem = EventSystem.current;
        GameObject selectButton = _eventSystem.currentSelectedGameObject;
        if(_maru)
        {
            for(int i = 0; i < selectButton.gameObject.transform.childCount; i++)
            {
                selectButton.gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
            selectButton.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        if(_batu)
        {
            for (int i = 0; i < selectButton.gameObject.transform.childCount; i++)
            {
                selectButton.gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
            selectButton.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

}
