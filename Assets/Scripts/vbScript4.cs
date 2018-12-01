using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript4 : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject vbButtonObject4;
    private GameObject vaquero;
    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource sound3;
    public AudioSource sound4;
    public AudioSource sound5;

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Boton 4 presionado");
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

        vbButtonObject4 = GameObject.Find("boton4");
        vbButtonObject4.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    void Run1()
    {
        if (!sound1.isPlaying)
        {
            sound2.Stop();
            sound3.Stop();
            sound4.Stop();
            sound5.Stop();
            sound1.Play();
        }
        else
        {
            sound1.Stop();
        }
    }

}