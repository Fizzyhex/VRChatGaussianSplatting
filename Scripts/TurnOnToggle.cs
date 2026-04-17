
using UnityEngine;

namespace GaussianSplatting
{

public class TurnOnToggle : MonoBehaviour
{   
    [Tooltip("The GameObject that will be enabled when this toggle is activated.")]
    public int enableObjectIndex = 0; // Index of the object to enable in the GaussianSplatRenderer's splatObjects array
    [Tooltip("The Gaussian Splat Renderer that will use the enabled object as the splat object.")]
    public GaussianSplatRenderer gaussianSplatRenderer;

    public void Start()
    {
        if (gaussianSplatRenderer == null)
        {
            return;
        }

        GameObject targetObject = gaussianSplatRenderer.GetObjectByIndex(enableObjectIndex);
        if (targetObject != null)
        {
            gameObject.name = "Select " + targetObject.name;
        }
    }

    public void SelectObject()
    {
        if (gaussianSplatRenderer == null)
        {
            return;
        }

        gaussianSplatRenderer.SelectSplatObject(enableObjectIndex);
    }

    public void Interact()
    {
        SelectObject();
    }

    public void OnTrigger()
    {
        SelectObject();
    }
}

}
