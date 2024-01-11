using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(Animation))]
[RequireComponent(typeof(Rotation))]
public class Movement : MonoBehaviour
{
    private PlayerMover _mover;
    private Animation _animation;
    private Rotation _rotation;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
        _animation = GetComponent<Animation>();
        _rotation = GetComponent<Rotation>();
    }

    private void Update()
    {
        int button = 0;

        if (Input.GetMouseButtonDown(button))
            _animation.RunAttackAnimation();

        if (Input.GetKey(KeyCode.D))
            _mover.MoveToRight();

        if (Input.GetKey(KeyCode.A))
            _mover.MoveToLeft();

        _animation.RunMoveAnimation();

        _rotation.TurnTowardsWalking();
    }
}
