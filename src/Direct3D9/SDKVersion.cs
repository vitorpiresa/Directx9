namespace Direct3D9;

public enum SDKVersion : uint
{
	D3D = 32,
	D3D9b = 31,
	D3D_Debug = 32 | 0x80000000,
	D3D9b_Debug = 31 | 0x80000000,
}