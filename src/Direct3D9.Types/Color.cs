namespace Direct3D9.Types;

public record struct Color(byte a, byte r, byte g, byte b)
{
	public static Color ARGB(byte a, byte r, byte g, byte b) => new(a, r, g, b);
	public static Color RGBA(byte r, byte g, byte b, byte a) => new(a, r, g, b);
	public static Color XRGB(byte r, byte g, byte b) => new(0xFF, r, g, b);
	public static Color XYUV(byte y, byte u, byte v) => new(0xFF, y, u, v);
	public static Color AYUV(byte a, byte y, byte u, byte v) => new(a, y, u, v);
	public static Color ColorValue(float a, float r, float g, float b) => new((byte)(a * 255f), (byte)(r * 255f), (byte)(g * 255f), (byte)(b * 255f));
}