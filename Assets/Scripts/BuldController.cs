using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuldController : MonoBehaviour
{
    private Animator buldAnimator;
    public bool buldOn;
    // Start is called before the first frame update

    void Awake()
    {
        buldAnimator = gameObject.GetComponent<Animator>();

        turnOff();
    }
    void Start()
    {
        
    }

    public void turnOn()
    {
        buldAnimator.SetBool ("on", true);
        buldOn = true;
    
    }

    public void turnOff()
    {
        buldAnimator.SetBool("on", false);
        buldOn = false;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
