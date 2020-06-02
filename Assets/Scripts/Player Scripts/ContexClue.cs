using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContexClue : MonoBehaviour
{
    public GameObject contexClue;
    public bool contextActive;
    
    public void ChangeContext()
    {
        contextActive = !contextActive;
        if(contextActive)
        {
            contexClue.SetActive(true);
        }
        else
        {
            contexClue.SetActive(false);
        }
    }
}
