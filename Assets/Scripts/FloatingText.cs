using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipInfo[0].clip.length);
    }

    public void SetText(string text)
    {
        animator.GetComponent<TextMesh>().text = text;
    }

    public void SetTextColour(Vector3 color)
    {
        animator.GetComponent<TextMesh>().color = new Color(color.x, color.y, color.z);
    }
}
