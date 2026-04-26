using UnityEngine;

using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FitCameraHeight : MonoBehaviour
{
    private Camera sceneCamera;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        this.sceneCamera = Camera.main;
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        AdjustLocalScale();
    }

    private void AdjustLocalScale()
    {
        float cameraWidth = this.sceneCamera.orthographicSize * 2;
        float cameraHeight = this.sceneCamera.aspect * cameraWidth;

        float spriteHeight = this.spriteRenderer.sprite.bounds.size.y;

        float scale = (cameraWidth / spriteHeight);

        this.transform.localScale = Vector2.one * scale;
    }
}