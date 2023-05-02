
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class CameraPostProcessing : MonoBehaviour
{
    public Material postProcessingMaterial;

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (postProcessingMaterial == null) {
            Graphics.Blit(source, destination);
            return;
        }
        Graphics.Blit(source, destination, postProcessingMaterial);
    }
}