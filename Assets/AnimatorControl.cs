using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimatorControlExample : MonoBehaviour
{
    public string animationName = "Wolf_Run";

    void Start()
    {
        foreach (Animator animator in GetComponentsInChildren<Animator>())
        {
            animator.Play(animationName);
        }
    }

    void Update()
    {
        foreach (Animator animator in GetComponentsInChildren<Animator>())
        {
            animator.Update(Time.deltaTime);
        }
    }
}
