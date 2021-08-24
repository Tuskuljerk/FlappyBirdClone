using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class time : MonoBehaviour

{
    private DateTime _previousTimeTextUpdate = DateTime.MinValue;
    private Text _sometext;
    
    public  void Start()
    {
        _sometext = gameObject.GetComponent<Text>();
    }

    void Update()
    {
        if (_previousTimeTextUpdate < DateTime.UtcNow.AddSeconds(1))
        {
            _previousTimeTextUpdate = DateTime.UtcNow;
            _sometext.text = _previousTimeTextUpdate.ToLocalTime().ToString("HH:mm:ss");
        }
    }


   
}
