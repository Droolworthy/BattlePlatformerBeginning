using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Rotation : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    private float _inputHorizontal;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TurnTowardsWalking()
    {
        _inputHorizontal = Input.GetAxis("Horizontal");

        if (_inputHorizontal > 0)
            _spriteRenderer.flipX = false;

        if (_inputHorizontal < 0)
            _spriteRenderer.flipX = true;
    }
}
