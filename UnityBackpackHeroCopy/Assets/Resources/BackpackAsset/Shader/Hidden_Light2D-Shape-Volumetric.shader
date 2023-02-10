//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Light2D-Shape-Volumetric" {
Properties {
}
SubShader {
 Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
 Pass {
  Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" }
  Blend SrcAlpha One, SrcAlpha One
  ZTest Off
  ZWrite Off
  Cull Off
  GpuProgramID 9332
Program "vp" {
SubProgram "d3d11 " {
Keywords { "SPRITE_LIGHT" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "SPRITE_LIGHT" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
"// shader disassembly not supported on DXBC"
}
}
}
}
}