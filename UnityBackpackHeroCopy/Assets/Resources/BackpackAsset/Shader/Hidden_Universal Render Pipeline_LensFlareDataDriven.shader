//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Universal Render Pipeline/LensFlareDataDriven" {
Properties {
}
SubShader {
 Pass {
  Name "LensFlareAdditive"
  LOD 100
  Tags { "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
  Blend One One, One One
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 4830
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_INVERSE_SDF" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  Name "LensFlareScreen"
  LOD 100
  Tags { "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
  Blend One OneMinusSrcColor, One OneMinusSrcColor
  BlendOp Max, Max
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 121771
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_INVERSE_SDF" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  Name "LensFlarePremultiply"
  LOD 100
  Tags { "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
  Blend One OneMinusSrcAlpha, One OneMinusSrcAlpha
  ColorMask RGB 0
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 150504
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_INVERSE_SDF" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  Name "LensFlareLerp"
  LOD 100
  Tags { "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
  Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
  ColorMask RGB 0
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 204775
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_INVERSE_SDF" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_CIRCLE" "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_OCCLUSION" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "FLARE_INVERSE_SDF" "FLARE_OCCLUSION" "FLARE_POLYGON" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}