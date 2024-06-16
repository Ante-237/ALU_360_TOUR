using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    [SerializeField] private GameObject LocatorObj;
    [SerializeField] private GameObject TextObj;

    [Range(0, 1f)][SerializeField] private float ScaleFactor = 0.2f;

    private bool scaleUp = false;
    private bool scaleDown = false;
    private float initialTime = 0;
    private float TimeToScale = 0;

    private Vector3 localState;

    private void Start()
    {
        localState = LocatorObj.transform.localScale;  
    }

    private void Update()
    {
        if (scaleUp)
        {
            if(LocatorObj.transform.localScale.x < localState.x + ScaleFactor) {
                LocatorObj.transform.localScale = new Vector3(LocatorObj.transform.localScale.x + Time.deltaTime, LocatorObj.transform.localScale.y + Time.deltaTime, LocatorObj.transform.localScale.z + Time.deltaTime);
            }
            else
            {
                scaleUp = false;
            }          
        }

        if (scaleDown)
        {
            if (LocatorObj.transform.localScale.x > localState.x)
            {
                LocatorObj.transform.localScale = new Vector3(LocatorObj.transform.localScale.x - Time.deltaTime, LocatorObj.transform.localScale.y - Time.deltaTime, LocatorObj.transform.localScale.z - Time.deltaTime);
            }
            else
            {
                scaleDown = false;
            }
        }
    }

    public void ScaleDown()
    {
        scaleDown = true;
    }

    public void ScaleUp()
    {
        scaleUp = true;
    }

    public void ShowText()
    {
        TextObj.SetActive(true);
    }

    public void HideText()
    {
        TextObj.SetActive(false);
    }
}
