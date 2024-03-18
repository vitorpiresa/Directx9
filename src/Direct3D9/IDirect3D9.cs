using System.Runtime.InteropServices;

namespace Direct3D9;

public struct IDirect3D9
{
	private unsafe Direct3D9* pthis;
	//d3dx9d
	//[DllImport("D3d9d.dll", EntryPoint = "Direct3DCreate9")]
	public static extern IDirect3D9 Create(SDKVersion SDKVersion);
	public unsafe uint GetAdapterCount() => pthis->Vtable->GetAdapterCount(pthis);
}

internal unsafe struct Direct3D9
{
	public Vtable_Direct3D9* Vtable;
}

internal unsafe struct Vtable_Direct3D9
{
	public nint QueryInterface;
	public nint AddRef;
	public nint Release;
	public nint RegisterSoftwareDevice;
	public delegate* unmanaged[Stdcall]<Direct3D9*, uint> GetAdapterCount;
	public nint GetAdapterIdentifier;
	public nint GetAdapterModeCount;
	public nint EnumAdapterModes;
	public nint GetAdapterDisplayMode;
	public nint CheckDeviceType;
	public nint CheckDeviceFormat;
	public nint CheckDeviceMultiSampleType;
	public nint CheckDepthStencilMatch;
	public nint CheckDeviceFormatConversion;
	public nint GetDeviceCaps;
	public nint GetAdapterMonitor;
	public nint CreateDevice;
	public nint Version;
}