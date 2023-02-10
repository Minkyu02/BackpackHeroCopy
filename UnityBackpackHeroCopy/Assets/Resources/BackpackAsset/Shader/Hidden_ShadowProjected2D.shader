//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/ShadowProjected2D" {
Properties {
_ShadowColorMask ("__ShadowColorMask", Float) = 0
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
   Ref 5
   ReadMask 4
   WriteMask 1
   Comp NotEqual
   Pass Replace
   Fail Keep
   ZFail Keep
  }
  GpuProgramID 324
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
   Ref 3
   ReadMask 1
   WriteMask 2
   Comp Equal
   Pass Replace
   Fail Keep
   ZFail Keep
  }
  GpuProgramID 66045
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