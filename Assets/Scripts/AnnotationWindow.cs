﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

using HoloToolkit.UI.Keyboard;

public class AnnotationWindow : MonoBehaviour {

    private GameObject gameObj;
    private GameObject textObj;
    private GameObject activeObj;
    private GameObject[] tmp;
    private KeyboardInputField note;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void saveAnnotation()
    {

        if (GameObject.Find("Annotation_window") != null)
        {
            note = GameObject.Find("MessageInputField").GetComponent<KeyboardInputField>();
            HoverScript.activeObj.GetComponent<HoverScript>().annotation = note.text;
            HoverScript.activeObj.GetComponent<HoverScript>().gameObjNote.text = note.text;
            note.text = "";
           
        }
        else
            Debug.Log("No GameObject with the name 'Text' attached to the gameObject");
        
        GameObject.Find("Holograms").GetComponent<PanelScript>().keyboard.Close();
        
    }

    public void GetAnnotation()
    {
        string note = HoverScript.activeObj.GetComponent<HoverScript>().annotation;
        GameObject.Find("MessageInputField/Text").GetComponent<Text>().text = note;
    }
}
