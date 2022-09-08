/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

[Serializable]
public class P3D_VertexColorBrush // TypeDefIndex: 9444
{
	// Fields
	public float Size; // 0x10
	public float Opacity; // 0x14
	public float Falloff; // 0x18
	public Color CenterColor; // 0x1C
	public P3D_VertexColorBlendMode Blend; // 0x2C

	// Properties
	public float SmoothFactor { get => default; } // 0x0000000186012270-0x00000001860122E0 

	// Constructors
	public P3D_VertexColorBrush() {} // 0x00000001860121D0-0x0000000186012270

	// Methods
	public float CalculateColorPaintAmount(float distance01) => default; // 0x00000001860118D0-0x00000001860119B0
	public Color ReplaceColor(Color source, Color target, float amount) => default; // 0x0000000186011D40-0x0000000186011E00
	public Color ReplaceColor(Color source, Color target, float amount, int channel) => default; // 0x0000000186011E00-0x0000000186011F10
	public Color AddColor(Color source, float amount, Color max) => default; // 0x0000000186010EE0-0x0000000186011030
	public Color AddColor(Color source, float amount, int channel, Color max) => default; // 0x0000000186011030-0x0000000186011170
	public Color SubtractColor(Color source, float amount, Color min) => default; // 0x0000000186011F10-0x0000000186012080
	public Color SubtractColor(Color source, float amount, int channnel, Color min) => default; // 0x0000000186012080-0x00000001860121D0
	public Color Average(ICollection<Color> colors) => default; // 0x0000000186011170-0x0000000186011600
	public float Average(ICollection<float> colors) => default; // 0x0000000186011600-0x00000001860118D0
	public Color LerpColor(Color source, float target, float factor, int channel) => default; // 0x0000000186011C50-0x0000000186011D40
	private static Color ClampColor(Color color, Color min, Color max) => default; // 0x0000000186011AD0-0x0000000186011C50
	private static Color ClampColor(Color color, Color min, Color max, int channel) => default; // 0x00000001860119B0-0x0000000186011AD0
}

