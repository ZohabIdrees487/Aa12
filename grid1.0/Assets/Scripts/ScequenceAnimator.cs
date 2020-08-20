using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScequenceAnimator : MonoBehaviour
{
    public float waitBetween;
    
    List<Animator> _animators;

    void Start()
    {
        _animators = new List<Animator>(GetComponentsInChildren<Animator>());
        StartCoroutine(DoAnimation());
    }

    public IEnumerator DoAnimation()
    {
        while (true)
        {
            

            foreach (var animator in _animators)
            {
                animator.SetTrigger("DoAnimation");
                    yield return new WaitForSeconds(waitBetween);
                
            }

        }
        
    }

}
