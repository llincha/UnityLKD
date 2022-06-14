using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    private Animator rAnimator;
    // Start is called before the first frame update
    void Start()
    {
        rAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            rAnimator.SetTrigger("Rotate");
        }
    }
}
