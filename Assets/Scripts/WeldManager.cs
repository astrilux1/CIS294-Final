using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class WeldManager : MonoBehaviour
{
    public TextMeshProUGUI EndTime;
    private float elapsedRunningTime = 0f;
    private float runningStartTime = 0f;
    public GameObject StartPanel;
    public GameObject EndPanel;
    public GameObject TimerPanel;
    private Camera cam;
    public bool Running = false;
    float weldTimer;
    public float weldStatus;
    public LayerMask WlayerMask;
    public GameObject Sphere;
    public GameObject Sphere1;
    public GameObject Sphere2;
    public GameObject Sphere3;
    public GameObject Sphere4;
    public GameObject Sphere5;
    public GameObject Sphere6;
    public GameObject Sphere7;
    public GameObject Sphere8;
    public bool SphereBool = false;
    public bool SphereBool1 = false;
    public bool SphereBool2 = false;
    public bool SphereBool3 = false;
    public bool SphereBool4 = false;
    public bool SphereBool5 = false;
    public bool SphereBool6 = false;
    public bool SphereBool7 = false;
    public bool SphereBool8 = false;

    public void ToggleRunning()
    {
        Running = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        weldStatus = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Running)
        {
            runningStartTime = Time.time;
        }
        if(Running)
        {
            TimerPanel.SetActive(true);
            elapsedRunningTime = (int)Time.time - (int)runningStartTime;
            EndTime.text = elapsedRunningTime.ToString() + "s";
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Sphere")
                    {
                        MeshRenderer m = Sphere.GetComponent<MeshRenderer>();
                        m.enabled = true;
                        weldStatus++;
                        SphereBool = true;
                    }
                    else if (hit.transform.name == "Sphere (1)")
                    {
                        MeshRenderer m = Sphere1.GetComponent<MeshRenderer>();
                        m.enabled = true;
                        weldStatus++;
                        SphereBool1 = true;
                    }
                    else if (hit.transform.name == "Sphere (2)")
                    {
                        MeshRenderer m = Sphere2.GetComponent<MeshRenderer>();
                        m.enabled = true;
                        weldStatus++;
                        SphereBool2 = true;
                    }
                    else if (hit.transform.name == "Sphere (3)")
                    {
                        MeshRenderer m = Sphere3.GetComponent<MeshRenderer>();
                        m.enabled = true;
                        weldStatus++;
                        SphereBool3 = true;
                    }
                    else if (hit.transform.name == "Sphere (4)")
                    {
                        MeshRenderer m = Sphere4.GetComponent<MeshRenderer>();
                        m.enabled = true;
                        weldStatus++;
                        SphereBool4 = true;
                    }
                    else if (hit.transform.name == "Sphere (5)")
                    {
                        MeshRenderer m = Sphere5.GetComponent<MeshRenderer>();
                        m.enabled = true;
                        weldStatus++;
                        SphereBool5 = true;
                    }
                    else if (hit.transform.name == "Sphere (6)")
                    {
                        MeshRenderer m = Sphere6.GetComponent<MeshRenderer>();
                        m.enabled = true;
                        weldStatus++;
                        SphereBool6 = true;
                    }
                    else if (hit.transform.name == "Sphere (7)")
                    {
                        MeshRenderer m = Sphere7.GetComponent<MeshRenderer>();
                        m.enabled = true;
                        weldStatus++;
                        SphereBool7 = true;
                    }
                    else if (hit.transform.name == "Sphere (8)")
                    {
                        MeshRenderer m = Sphere8.GetComponent<MeshRenderer>();
                        m.enabled = true;
                        weldStatus++;
                        SphereBool8 = true;
                    }

                }
            if(SphereBool && SphereBool1 && SphereBool2 && SphereBool3 && SphereBool4 && SphereBool5 && SphereBool6 && SphereBool7 && SphereBool8)
                {
                    Running = false;
                    EndPanel.SetActive(true);
                    EndTime.text = elapsedRunningTime.ToString();
                    Debug.Log(elapsedRunningTime.ToString());
                }


            }
        }
    }
}