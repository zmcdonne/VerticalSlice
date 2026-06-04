using UnityEngine;
using UnityEngine.Rendering;
public class Renderswitcher : MonoBehaviour

{
    public RenderPipelineAsset noEffectRenderPipeline;
    public RenderPipelineAsset crashoutRenderPipeline; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void SetDefaultRenderer()
    {
        GraphicsSettings.defaultRenderPipeline = noEffectRenderPipeline;
        QualitySettings.renderPipeline = noEffectRenderPipeline;
    }

    // Update is called once per frame
    public void SetCrashoutRenderer ()
    {
        GraphicsSettings.defaultRenderPipeline = crashoutRenderPipeline;
        QualitySettings.renderPipeline = crashoutRenderPipeline; 
    }

    private void Start()
    {
        SetDefaultRenderer();
    }
}
