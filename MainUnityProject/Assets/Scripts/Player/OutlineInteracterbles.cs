using UnityEngine;

public class Outlineinteractables : MonoBehaviour
{
    Outline _outline;
    
    void Awake()
    {
        _outline = gameObject.AddComponent<Outline>();
        _outline.OutlineMode = Outline.Mode.OutlineVisible;
        _outline.OutlineColor = Color.orangeRed;
        _outline.OutlineWidth = 1f;
        _outline.enabled = false;
    }

    public void OnFocusGained()
    {
        _outline.enabled = true;
    }

    public void OnFocusLosr()
    {
        _outline.enabled = false;
    }
}
