using UnityEngine;

public class PlayAnimationOnMove : MonoBehaviour
{
    public AnimationClip moveAnimation; // Ҫ���ŵĶ���
    private Animator animator;
    private Vector3 lastPosition;

    void Start()
    {
        animator = GetComponent<Animator>();
        lastPosition = transform.position;
    }

    void Update()
    {
        // ��������λ���Ƿ����仯
        if (transform.position != lastPosition)
        {
            PlayAnimation();
        }

        lastPosition = transform.position;
    }

    void PlayAnimation()
    {
        if (moveAnimation != null)
        {
            animator.Play(moveAnimation.name);
        }
    }
}
