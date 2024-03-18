using System;
using System.Runtime.InteropServices;

namespace D3d9.Types;

public record struct D3DVECTOR(float x, float y, float z);
public record struct D3DCOLORVALUE(float r, float g, float b, float a);
public record struct D3DRECT(int x1, int y1, int x2, int y2);
public record struct D3DMATRIX(float _11, float _12, float _13, float _14, float _21, float _22, float _23, float _24, float _31, float _32, float _33, float _34, float _41, float _42, float _43, float _44);
public record struct D3DVIEWPORT9(int X, int Y, int Width, int Height, float MinZ, float MaxZ);
public record struct D3DCLIPSTATUS9(int ClipUnion, int ClipIntersection);
public record struct D3DMATERIAL9(D3DCOLORVALUE Diffuse, D3DCOLORVALUE Ambient, D3DCOLORVALUE Specular, D3DCOLORVALUE Emissive, float Power);
public record struct D3DLIGHT9(D3DLIGHTTYPE Type, D3DCOLORVALUE Diffuse, D3DCOLORVALUE Specular, D3DCOLORVALUE Ambient, D3DVECTOR Position, D3DVECTOR Direction, float Range, float Falloff, float Attenuation0, float Attenuation1, float Attenuation2, float Theta, float Phi);
public record struct D3DVERTEXELEMENT9(ushort Stream, ushort Offset, byte Type, byte Method, byte Usage, byte UsageIndex);