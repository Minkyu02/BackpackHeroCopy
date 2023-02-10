//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Universal Render Pipeline/FinalPost" {
Properties {
}
SubShader {
 LOD 100
 Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
 Pass {
  Name "FinalPost"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 14214
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
}
}
}
SubShader {
 LOD 100
 Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
 Pass {
  Name "FinalPost"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 120564
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_POINT_SAMPLING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_DITHERING" "_FILM_GRAIN" "_FXAA" "_LINEAR_TO_SRGB_CONVERSION" "_RCAS" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}