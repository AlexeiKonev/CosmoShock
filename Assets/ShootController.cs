using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : CharacterAnimator
{
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
            _animator.SetTrigger("target");
        if (Input.GetButtonDown("Fire1"))
            _animator.SetTrigger("shoot");
    }
}
