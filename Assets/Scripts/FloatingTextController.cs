using UnityEngine;

public class FloatingTextController : MonoBehaviour {
    
    private static FloatingText popupText;
    private static GameObject canvas;

    public static void Initialize()
    {
        canvas = GameObject.Find("UI_Upgrade_Canvas");
        popupText = Resources.Load<FloatingText>("Prefabs/Controller");
    }

    public static void CreateFloatingText(string text, Transform textTransform)
    {
        FloatingText floatingTextInstance = Instantiate(popupText);

        Vector3 screenPos = new Vector3(textTransform.position.x + Random.Range(-0.5f, 0.5f), textTransform.position.y + Random.Range(0.0f, 1f), textTransform.position.z);

        floatingTextInstance.transform.SetParent(canvas.transform, false);
        floatingTextInstance.transform.position = screenPos;
        floatingTextInstance.transform.rotation = Camera.main.transform.rotation;

        Vector3 color;
        if (text.CompareTo(70.ToString()) > 0)
        {
            color = new Vector3(1, 0, 0);
            floatingTextInstance.SetAnimClip(1);
        }
        else
        {
            color = new Vector3(0, 0.2f, 0.8f);
            floatingTextInstance.SetAnimClip(0);
        }

        floatingTextInstance.SetTextColour(color);
        floatingTextInstance.SetText(text);
    }
}
