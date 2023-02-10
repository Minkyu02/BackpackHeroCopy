//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Shadow2DUnshadowGeometry" {
Properties {
}
SubShader {
 Tags { "RenderType" = "Transparent" }
 Pass {
  Tags { "RenderType" = "Transparent" }
  ColorMask 0 0
  ZTest Always
  ZWrite Off
  Cull Off
  Stencil {
   Ref 4
   ReadMask 4
   WriteMask 4
   Comp NotEqual
   Pass Replace
   Fail Keep
   ZFail Keep
  }
  GpuProgramID 52242
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
  Tags { "RenderType" = "Transparent" }
  ColorMask 0 0
  ZTest Always
  ZWrite Off
  Cull Off
  Stencil {
   Ref 4
   ReadMask 4
   WriteMask 4
   Comp Equal
   Pass Zero
   Fail Keep
   ZFail Keep
  }
  GpuProgramID 81451
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