Shader "Hidden/GaussianSplatting/CopyRenderOrder"
{
    SubShader
    {
        Tags { "RenderPipeline"="UniversalPipeline" "RenderType"="Opaque" "Queue"="Overlay" }
        Pass
        {
            Cull Off
            ZWrite Off
            ZTest Always

            HLSLPROGRAM
            #pragma vertex vert_img
            #pragma fragment frag

            #include "UnityCG.cginc"

            sampler2D _MainTex;

            float frag(v2f_img input) : SV_Target
            {
                return tex2D(_MainTex, input.uv).r;
            }
            ENDHLSL
        }
    }
    Fallback Off
}
