//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Light2D-Shape" {
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
  GpuProgramID 26634
Program "vp" {
SubProgram "d3d11 " {
Keywords { "SPRITE_LIGHT" "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SPRITE_LIGHT" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SPRITE_LIGHT" "USE_ADDITIVE_BLENDING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SPRITE_LIGHT" }
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
Keywords { "SPRITE_LIGHT" "USE_ADDITIVE_BLENDING" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SPRITE_LIGHT" "USE_NORMAL_MAP" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SPRITE_LIGHT" "USE_ADDITIVE_BLENDING" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "SPRITE_LIGHT" }
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