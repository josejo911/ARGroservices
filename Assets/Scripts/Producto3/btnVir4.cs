using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btnVir4 : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject b4;
    private GameObject vaquero;
    public AudioSource bongo1, bongo2, bongo3, bongo4, bongo5;


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

        b4 = GameObject.Find("botoncito4");
        b4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    void Run1()
    {
        if (!bongo1.isPlaying)
        {
            bongo2.Stop();
            bongo3.Stop();
            bongo4.Stop();
            bongo5.Stop();
            bongo1.Play();
        }
        else
        {
            bongo1.Stop();
        }
    }

}