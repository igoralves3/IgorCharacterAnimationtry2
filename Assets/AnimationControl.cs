using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class AnimationControl : MonoBehaviour
{

    public Animation anim;
    public Animator animator;
    public AnimationClip animA;
    public AnimationClip animB;
    public AnimationClip animC;
    public AnimationClip current;
    // Start is called before the first frame update
    void Start()
    {
        current = animA;
        animator.Play("exercitando");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            Debug.Log("1");
            //animator.Stop();
            current = animA;
            animator.Play("exercitando");
        }
        if (Input.GetKey("2"))
        {
            Debug.Log("2");
            //animator.Stop();
            current = animB;
            animator.Play("pensando");
        }
        if (Input.GetKey("3"))
        {
            Debug.Log("3");
            //animator.Stop();
            current = animC;
            animator.Play("acenando");
        }
    }
}
