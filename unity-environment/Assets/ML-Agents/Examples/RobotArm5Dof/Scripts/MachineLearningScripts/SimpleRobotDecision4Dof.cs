﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRobotDecision4Dof : MonoBehaviour, Decision {

    public float[] Decide(List<float> state, List<Camera> observation, float reward, bool done, float[] memory)
    {
        if (gameObject.GetComponent<Brain>().brainParameters.actionSpaceType == StateType.continuous)
        {
            // MAKE SURE THIS IS THE SAME SIZE AS THE ACTION SPACE
            return new float[5] { 0f, 0f, 0f, 0f, 0f };
        }
        else
        {
            Debug.LogWarning("Simple robot 5DOF is not designed for discrete space");
            return new float[1] { 0f };
        }
    }

    public float[] MakeMemory(List<float> state, List<Camera> observation, float reward, bool done, float[] memory)
    {
        return new float[0];
    }

}
