using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public Transform[] breakObjs;
    public Transform[] textInfo;
    int count = 0;

    public void BreakDownButton()
    {
        for (int i = 0; i < breakObjs.Length; i++)
        {
            breakObjs[i].GetComponent<Animator>().SetTrigger("Break");
        } 
    }

    public void BreakUpButton()
    {
        for (int i = 0; i < breakObjs.Length; i++)
        {
            breakObjs[i].GetComponent<Animator>().SetTrigger("rest");
        }
    }

    public void InfomationOK()
    {
        count += 1;
        if (count == 1)
        {
            for (int i = 0; i < textInfo.Length; i++)
            {
                textInfo[i].gameObject.SetActive(true);
            }
        }
        else if (count == 2)
        {
            for (int i = 0; i < textInfo.Length; i++)
            {
                textInfo[i].gameObject.SetActive(false);
            }
            count = 0;
        }
    }

}
