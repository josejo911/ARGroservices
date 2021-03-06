﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB5 : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject a5;
    private GameObject vaquero;
    public AudioSource perro1, perro2, perro3, perro4, perro5;


    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("perro 5 presionado");
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

        a5 = GameObject.Find("btnsote5");
        a5.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    void Run1()
    {
        if (!perro1.isPlaying)
        {
            perro2.Stop();
            perro3.Stop();
            perro4.Stop();
            perro5.Stop();
            perro1.Play();
        }
        else
        {
            perro1.Stop();
        }
    }

}