//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Universal Render Pipeline/2D/Sprite-Lit-Default" {
Properties {
_MainTex ("Diffuse", 2D) = "white" { }
_MaskTex ("Mask", 2D) = "white" { }
_NormalMap ("Normal Map", 2D) = "bump" { }
_Color ("Tint", Color) = (1,1,1,1)
_RendererColor ("RendererColor", Color) = (1,1,1,1)
_Flip ("Flip", Vector) = (1,1,1,1)
_AlphaTex ("External Alpha", 2D) = "white" { }
_EnableExternalAlpha ("Enable External Alpha", Float) = 0
}
SubShader {
 Tags { "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
 Pass {
  Tags { "LIGHTMODE" = "Universal2D" "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
  Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
  ZWrite Off
  Cull Off
  GpuProgramID 40534
Program "vp" {
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_2" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_2" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_2" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_1" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_2" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_2" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_1" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_2" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_2" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_2" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_2" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_2" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_2" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_1" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_2" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_2" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_1" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_2" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_2" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_0" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_SHAPE_LIGHT_TYPE_1" "USE_SHAPE_LIGHT_TYPE_2" "USE_SHAPE_LIGHT_TYPE_3" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  Tags { "LIGHTMODE" = "NormalsRendering" "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
  Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
  ZWrite Off
  Cull Off
  GpuProgramID 75362
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
 Pass {
  Tags { "LIGHTMODE" = "UniversalForward" "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
  Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha
  ZWrite Off
  Cull Off
  GpuProgramID 139610
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
Fallback "Sprites/Default"
}