namespace Direct3D9.Types;

public record struct Material(ColorValue Diffuse, ColorValue Ambient, ColorValue Specular, ColorValue Emissive, float Power);