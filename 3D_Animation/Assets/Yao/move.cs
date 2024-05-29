using UnityEngine;

public class PlayAnimationOnMove : MonoBehaviour
{
    public AnimationClip moveAnimation; // 要播放的动画
    private Animator animator;
    private Vector3 lastPosition;

    void Start()
    {
        animator = GetComponent<Animator>();
        lastPosition = transform.position;
    }

    void Update()
    {
        // 检查物体的位置是否发生变化
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
