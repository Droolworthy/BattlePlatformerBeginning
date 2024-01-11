using UnityEngine;

public class Animation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void RunMoveAnimation()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");

        _animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

    public void RunAttackAnimation()
    {
        _animator.SetTrigger("Attack");
    }
}
