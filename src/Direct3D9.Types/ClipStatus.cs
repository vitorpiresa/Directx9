namespace Direct3D9.Types;

public record struct ClipStatus(ClipStatusPlanes ClipUnion, ClipStatusPlanes ClipIntersection)
{
	public const uint MaxUserClipPlanes = 32;
}