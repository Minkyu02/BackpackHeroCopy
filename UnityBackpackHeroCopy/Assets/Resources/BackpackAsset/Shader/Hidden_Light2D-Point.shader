//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Light2D-Point" {
Properties {
_SrcBlend ("__src", Float) = 1
_DstBlend ("__dst", Float) = 0
}
SubShader {
 Tags { "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
 Pass {
  Tags { "QUEUE" = "Transparent" "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
  Blend Zero Zero, Zero Zero
  ZWrite Off
  Cull Off
  GpuProgramID 39981
Program "vp" {
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_NORMAL_MAP" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_ADDITIVE_BLENDING" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_NORMAL_MAP" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_ADDITIVE_BLENDING" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_ADDITIVE_BLENDING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_ADDITIVE_BLENDING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_NORMAL_MAP" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_ADDITIVE_BLENDING" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_NORMAL_MAP" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_ADDITIVE_BLENDING" "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_POINT_LIGHT_COOKIES" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" "USE_ADDITIVE_BLENDING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "LIGHT_QUALITY_FAST" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "USE_ADDITIVE_BLENDING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
}
}