namespace Direct3D9.Types;

public record struct Light(LightType Type, ColorValue Diffuse, ColorValue Specular, ColorValue Ambient, Vector Position, Vector Direction, float Range, float Falloff, float Attenuation0, float Attenuation1, float Attenuation2, float Theta, float Phi);