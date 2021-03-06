﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class botonvir4 : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbO4;
    private GameObject vaquero;
    public AudioSource son1, son2, son3, son4, son5;


    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("btn 4 presionado");
        //vbButtonObject1.GetComponent<AudioSource>().Play();
        Run1();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        //vbButtonObject1.GetComponent<AudioSource>().Stop();

    }

    // Use this for initialization
    void Start()
    {

        vbO4 = GameObject.Find("btn4");
        vbO4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    void Run1()
    {
        if (!son1.isPlaying)
        {
            son2.Stop();
            son3.Stop();
            son4.Stop();
            son5.Stop();
            son1.Play();
        }
        else
        {
            son1.Stop();
        }
    }

}