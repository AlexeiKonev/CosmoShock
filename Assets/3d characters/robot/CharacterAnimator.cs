using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
  [SerializeField] protected Animator _animator;
    // Start is called before the first frame update
  protected  void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1 pressed");
            _animator.SetInteger("walk", 1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("2 pressed");
            _animator.SetInteger("walk", 2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("3 pressed");
            _animator.SetInteger("walk", 3);
        }
       else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("4 pressed");
            _animator.SetInteger("walk", 4);
        }
        else
        {
            _animator.SetInteger("walk", 0);
        }
    }
}
