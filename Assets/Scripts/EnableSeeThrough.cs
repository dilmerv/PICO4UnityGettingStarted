using System.Collections;
using Unity.XR.PXR;
using UnityEngine;

public class EnableSeeThrough : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private float enableSeeThroughAfter = 1.0f;

    private void Awake()
    {
        if (mainCamera)
        {
            Debug.Log(nameof(ToggleSeeThrough));
            StartCoroutine(ToggleSeeThrough(true));
            mainCamera.backgroundColor = new Color(0, 0, 0, 0);
        }
        else
        {
            Debug.LogError("Camera must be referenced");
        }

    }

    private IEnumerator ToggleSeeThrough(bool enable)
    {
        yield return new WaitForSeconds(enableSeeThroughAfter);

        PXR_Boundary.EnableSeeThroughManual(enable);
        Debug.Log($"See through is set to ({enabled})");
    }
}
