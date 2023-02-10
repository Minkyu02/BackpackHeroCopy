//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Universal Render Pipeline/PaniniProjection" {
Properties {
}
SubShader {
 LOD 100
 Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
 Pass {
  Name "Panini Projection"
  LOD 100
  Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 55513
Program "vp" {
SubProgram "d3d11 " {
Keywords { "_GENERIC" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_UNIT_DISTANCE" }
"// shader disassembly not supported on DXBC"
}
}
Program "fp" {
SubProgram "d3d11 " {
Keywords { "_GENERIC" }
"// shader disassembly not supported on DXBC"
}
SubProgram "d3d11 " {
Keywords { "_UNIT_DISTANCE" }
"// shader disassembly not supported on DXBC"
}
}
}
}
}