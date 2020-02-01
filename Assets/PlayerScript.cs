﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{


    public GameObject glue;
    GlueScript glueS;

    bool active;
    float cooldown;
    public const float BASE_COOLDOWN = 0.5f;
    bool rightClicking; // continually remains true until click is released

    float glueBuildup;
    public const float GLUE_RATE_INCREASE = 0.01f;
    public const float MINIMUM_GLUE_BUILDUP = 0.2f;
    public const float MAXIMUM_GLUE_BUILDUP = 1f;

    // Start is called before the first frame update
    void Start()
    {
        active = true;
        glueS = glue.GetComponent<GlueScript>();
        glueBuildup = MINIMUM_GLUE_BUILDUP;
    }

    // Update is called once per frame
    void Update()
    {
        if (rightClicking == true)
        {
            BuildupGlue();
         	glueS.SetSize(glueBuildup);
        }
        if (Input.GetMouseButtonDown(0))
        {
            rightClicking = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            ShootGlue();
            rightClicking = false;
        }
    }

    private void ShootGlue()
    {
        //NEED METHOD CALL ON GLUE OBJECT SCRIPT SHOOTING GLUE, PASSING IN DIRECTION VECTOR
        PropelBackward();
    }

    private void PropelBackward()
    {

    }

    private void BuildupGlue()
    {
    	if (glueBuildup < MAXIMUM_GLUE_BUILDUP) {
			glueBuildup += GLUE_RATE_INCREASE;
        }
    }

}