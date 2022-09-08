/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 38: ProBuilderCore-Unity5.dll - Assembly: ProBuilderCore-Unity5, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3356-3465

namespace ProBuilder2.Common
{
	public static class pb_ColorUtil // TypeDefIndex: 3368
	{
		// Fields
		private static readonly Dictionary<string, pb_CIE_Lab_Color> ColorNameLookup; // 0x00
	
		// Constructors
		static pb_ColorUtil() {} // 0x0000000187711280-0x0000000187726990
	
		// Methods
		private static bool approx(float lhs, float rhs) => default; // 0x0000000187726990-0x0000000187726A50
		public static pb_XYZ_Color RGBToXYZ(Color col) => default; // 0x0000000187710D30-0x0000000187710E00
		public static pb_XYZ_Color RGBToXYZ(float r, float g, float b) => default; // 0x0000000187710AC0-0x0000000187710D30
		public static pb_CIE_Lab_Color XYZToCIE_Lab(pb_XYZ_Color xyz) => default; // 0x0000000187711060-0x0000000187711280
		public static float DeltaE(pb_CIE_Lab_Color lhs, pb_CIE_Lab_Color rhs) => default; // 0x00000001877103B0-0x00000001877104E0
		public static Color HSVtoRGB(pb_HsvColor hsv) => default; // 0x00000001877107E0-0x00000001877108E0
		public static Color HSVtoRGB(float h, float s, float v) => default; // 0x00000001877108E0-0x0000000187710AC0
		public static pb_HsvColor RGBtoHSV(Color color) => default; // 0x0000000187710E00-0x0000000187711060
		public static string GetColorName(Color InColor) => default; // 0x00000001877104E0-0x00000001877107E0
		private static pb_CIE_Lab_Color CIELabFromRGB(float R, float G, float B, float Scale) => default; // 0x00000001877102E0-0x00000001877103B0
	}
}
