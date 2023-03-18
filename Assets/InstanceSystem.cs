using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InstanceSystem<T> : MonoBehaviour where T : MonoBehaviour
{
    static T _instance;
    public static T Instance
    {
        get
        {
            if(!_instance)
            {
                _instance = FindObjectOfType<T>();
                Type type = typeof(T);
                if(!_instance)
                {
                    Debug.Log($"{type}がアタッチされたオブジェクトがありません");
                }
            }
            return _instance;
        }
    }

    virtual protected void Awake()
    {
        if(FindObjectsOfType<T>().Length > 1)
        {
            Destroy(this);
        }
        else
        {
            DontDestroyOnLoad(this);
        }
    }
}
