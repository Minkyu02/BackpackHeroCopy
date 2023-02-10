//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Shadow2DUnshadowSprite" {
Properties {
_MainTex ("Texture", 2D) = "white" { }
_ShadowColorMask ("__ShadowColorMask", Float) = 0
}
SubShader {
 Tags { "RenderType" = "Transparent" }
 Pass {
  Tags { "RenderType" = "Transparent" }
  Blend OneMinusSrcColor SrcColor, OneMinusSrcAlpha SrcAlpha
  ColorMask 0 0
  ZTest Always
  ZWrite Off
  Cull Off
  Stencil {
   Ref 1
   Comp Equal
   Pass Keep
   Fail Keep
   ZFail Keep
  }
  GpuProgramID 6745
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
}
}