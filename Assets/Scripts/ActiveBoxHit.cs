using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBoxHit : MonoBehaviour
{
    public GameObject BoxHit;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void One()
    {
        StartCoroutine(ActiveSec());
    }

    private IEnumerator ActiveSec()
    {
        BoxHit.SetActive(true);
        yield return new WaitForSeconds(.33f);
        BoxHit.SetActive(false);
    }
}
