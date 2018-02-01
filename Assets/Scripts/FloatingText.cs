using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public Animator m_Animator;
    private AnimatorClipInfo[] m_ClipInfo;
    private int m_AnimClipNum;

    private void Start()
    {
        m_ClipInfo = m_Animator.GetCurrentAnimatorClipInfo(m_AnimClipNum);
        Destroy(gameObject, m_ClipInfo[m_AnimClipNum].clip.length);
    }

    public void SetAnimClip(int clipNum)
    {
        m_AnimClipNum = clipNum;
    }

    public void SetText(string text)
    {
        m_Animator.GetComponent<TextMesh>().text = text;
    }

    public void SetTextColour(Vector3 color)
    {
        m_Animator.GetComponent<TextMesh>().color = new Color(color.x, color.y, color.z);
    }
}
