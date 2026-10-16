using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;
    private NewInput _input;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigibody;


    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _input = GetComponent<NewInput>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _rigibody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoving();
        Flip();
        PlayerJumping();
    }

    public void PlayerMoving()
    {
        _animator.SetBool("isMoving", _input.inputX != 0);
    }

    public void PlayerJumping()
    {
        _animator.SetFloat("isJumping", Mathf.Abs(_rigibody.velocity.y));
    }
    public void Flip()
    {
        if (_input.inputX < 0)
        {
            _spriteRenderer.flipX = true;
        } else if (_input.inputX > 0)
        {

            _spriteRenderer.flipX = false;
        }
    }
}