namespace Direct3D9.Types;

[System.Flags]
public enum ClipStatusPlanes : uint
{
	Left = 0x00000001,
	Right = 0x00000002,
	Top = 0x00000004,
	Bottom = 0x00000008,
	Front = 0x00000010,
	Back = 0x00000020,
	Plane0 = 0x00000040,
	Plane1 = 0x00000080,
	Plane2 = 0x00000100,
	Plane3 = 0x00000200,
	Plane4 = 0x00000400,
	Plane5 = 0x00000800,
	All = Left | Right | Top | Bottom | Front | Back | Plane0 | Plane1 | Plane2 | Plane3 | Plane4 | Plane5,
}