//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Universal Render Pipeline/Bloom" {
Properties {
}
SubShader {
 LOD 100
 Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
 Pass {
  Name "Bloom Prefilter"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 53086
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_BLOOM_HQ" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_BLOOM_HQ" "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_BLOOM_HQ" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_BLOOM_HQ" "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  Name "Bloom Blur Horizontal"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 67328
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  Name "Bloom Blur Vertical"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 187883
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
}
}
 Pass {
  Name "Bloom Upsample"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 206502
Program "vp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_BLOOM_HQ" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_BLOOM_HQ" "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_BLOOM_HQ" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_BLOOM_HQ" "_USE_RGBM" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}