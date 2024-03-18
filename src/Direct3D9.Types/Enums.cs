using System;
namespace Direct3D9.Types;

public enum ShadeMode
{
	Flat = 1,
	Gouraud = 2,
	Phong = 3,
}

public enum FillMode
{
	Point = 1,
	Wireframe = 2,
	Solid = 3,
}

public enum Blend
{
	Zero = 1,
	One = 2,
	SrcColor = 3,
	InvSrcColor = 4,
	SrcAlpha = 5,
	InvSrcAlpha = 6,
	DestAlpha = 7,
	InvDestAlpha = 8,
	DestColor = 9,
	InvDestColor = 10,
	SrcAlphaSat = 11,
	BothSrcAlpha = 12,
	BothInvSrcAlpha = 13,
	BlendFactor = 14,
	InvBlendFactor = 15,
	SrcColor2 = 16,
	InvSrcColor2 = 17,
}

public enum BlendOp
{
	Add = 1,
	Subtract = 2,
	RevSubtract = 3,
	Min = 4,
	Max = 5,
}

public enum TextureAddress
{
	Wrap = 1,
	Mirror = 2,
	Clamp = 3,
	Border = 4,
	MirrorOnce = 5,
}

public enum Cull
{
	None = 1,
	CW = 2,
	CCW = 3,
}

public enum CmpFunc
{
	Never = 1,
	Less = 2,
	Equal = 3,
	LessEqual = 4,
	Greater = 5,
	NotEqual = 6,
	GreaterEqual = 7,
	Always = 8,
}

public enum StencilOp
{
	Keep = 1,
	Zero = 2,
	Replace = 3,
	IncrSat = 4,
	DecrSat = 5,
	Invert = 6,
	Incr = 7,
	Decr = 8,
}

public enum FogMode
{
	None = 0,
	Exp = 1,
	Exp2 = 2,
	Linear = 3,
}

public enum ZBufferType
{
	False = 0,
	True = 1,
	UseW = 2,
}

public enum PrimitiveType
{
	PointList = 1,
	LineList = 2,
	LineStrip = 3,
	TriangleList = 4,
	TriangleStrip = 5,
	TriangleFan = 6,
}

public enum TransformStateType
{
	View = 2,
	Projection = 3,
	Texture0 = 16,
	Texture1 = 17,
	Texture2 = 18,
	Texture3 = 19,
	Texture4 = 20,
	Texture5 = 21,
	Texture6 = 22,
	Texture7 = 23,
}

public enum RenderStateType
{
	ZEnable = 7,
	FillMode = 8,
	ShadeMode = 9,
	ZWriteEnable = 14,
	AlphaTestEnable = 15,
	LastPixel = 16,
	SrcBlend = 19,
	DestBlend = 20,
	CullMode = 22,
	ZFunc = 23,
	AlphaRef = 24,
	AlphaFunc = 25,
	DitherEnable = 26,
	AlphaBlendEnable = 27,
	FogEnable = 28,
	SpecularEnable = 29,
	FogColor = 34,
	FogTableMode = 35,
	FogStart = 36,
	FogEnd = 37,
	FogDensity = 38,
	RangeFogEnable = 48,
	StencilEnable = 52,
	StencilFail = 53,
	StencilZFail = 54,
	StencilPass = 55,
	StencilFunc = 56,
	StencilRef = 57,
	StencilMask = 58,
	StencilWriteMask = 59,
	TextureFactor = 60,
	Wrap0 = 128,
	Wrap1 = 129,
	Wrap2 = 130,
	Wrap3 = 131,
	Wrap4 = 132,
	Wrap5 = 133,
	Wrap6 = 134,
	Wrap7 = 135,
	Clipping = 136,
	Lighting = 137,
	Ambient = 139,
	FogVertexMode = 140,
	ColorVertex = 141,
	LocalViewer = 142,
	NormalizeNormals = 143,
	DiffuseMaterialSource = 145,
	SpecularMaterialSource = 146,
	AmbientMaterialSource = 147,
	EmissiveMaterialSource = 148,
	VertexBlend = 151,
	ClipPlaneEnable = 152,
	PointSize = 154,
	PointSize_Min = 155,
	PointSpriteEnable = 156,
	PointScaleEnable = 157,
	PointScale_A = 158,
	PointScale_B = 159,
	PointScale_C = 160,
	MultiSampleAntialias = 161,
	MultiSampleMask = 162,
	PatchEdgeStyle = 163,
	DebugMonitorToken = 165,
	PointSize_Max = 166,
	IndexedVertexBlendEnable = 167,
	ColorWriteEnable = 168,
	TweenFactor = 170,
	BlendOp = 171,
	PositionDegree = 172,
	NormalDegree = 173,
	ScissorTestEnable = 174,
	SlopEscaleDepthBias = 175,
	AntiAliasedLineEnable = 176,
	MinTessellationLevel = 178,
	MaxTessellationLevel = 179,
	AdaptiveTess_X = 180,
	AdaptiveTess_Y = 181,
	AdaptiveTess_Z = 182,
	AdaptiveTess_W = 183,
	EnableAdaptiveTessellation = 184,
	TwoSidedStencilMode = 185,
	CCW_StencilFail = 186,
	CCW_StencilZFail = 187,
	CCW_StencilPass = 188,
	CCW_StencilFunc = 189,
	ColorWriteEnable1 = 190,
	ColorWriteEnable2 = 191,
	ColorWriteEnable3 = 192,
	BlendFactor = 193,
	SRGBWriteEnable = 194,
	DepthBias = 195,
	Wrap8 = 198,
	Wrap9 = 199,
	Wrap10 = 200,
	Wrap11 = 201,
	Wrap12 = 202,
	Wrap13 = 203,
	Wrap14 = 204,
	Wrap15 = 205,
	SeparateAlphaBlendEnable = 206,
	SrcBlendAlpha = 207,
	DestBlendAlpha = 208,
	BlendOpAlpha = 209,
}