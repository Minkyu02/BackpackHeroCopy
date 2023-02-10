//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Universal Render Pipeline/BokehDepthOfField" {
Properties {
}
SubShader {
 LOD 100
 Tags { "RenderPipeline" = "UniversalPipeline" }
 Pass {
  Name "Bokeh Depth Of Field CoC"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 30164
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
  Name "Bokeh Depth Of Field Prefilter"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 67341
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
  Name "Bokeh Depth Of Field Blur"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 189143
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
  Name "Bokeh Depth Of Field Post Blur"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 240962
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
  Name "Bokeh Depth Of Field Composite"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 304865
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
SubShader {
 LOD 100
 Tags { "RenderPipeline" = "UniversalPipeline" }
 Pass {
  Name "Bokeh Depth Of Field CoC"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 370765
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
  Name "Bokeh Depth Of Field Prefilter"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 458487
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
  Name "Bokeh Depth Of Field Blur"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 468118
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
  Name "Bokeh Depth Of Field Post Blur"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 535683
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
  Name "Bokeh Depth Of Field Composite"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 641387
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