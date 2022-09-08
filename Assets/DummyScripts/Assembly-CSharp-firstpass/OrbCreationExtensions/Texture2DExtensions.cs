/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace OrbCreationExtensions
{
	public static class Texture2DExtensions // TypeDefIndex: 10062
	{
		// Methods
		// [XID] // 0x0000000189632340-0x0000000189632360
		public static TextureFormat GetWritableFormat(TextureFormat format) => default; // 0x0000000187244E70-0x0000000187244F40
		// [XID] // 0x0000000189711450-0x0000000189711470
		private static Color[] ScaledPixels(Color[] originalPixels, int oldWidth, int oldHeight, int width, int height) => default; // 0x0000000187245780-0x0000000187245DA0
	
		// Extension methods
		// [IDTag] // 0x000000018987B120-0x000000018987B170
		// [XID] // 0x000000018987B120-0x000000018987B170
		public static Texture2D GetCopy(this Texture2D tex) => default; // 0x0000000187244920-0x0000000187244A40
		// [IDTag] // 0x0000000189888100-0x0000000189888150
		// [XID] // 0x0000000189888100-0x0000000189888150
		public static Texture2D GetCopy(this Texture2D tex, int x, int y, int w, int h) => default; // 0x0000000187244620-0x0000000187244750
		// [XID] // 0x0000000189895360-0x00000001898953A0
		public static Texture2D GetSection(this Texture2D tex, int x, int y, int w, int h) => default; // 0x0000000187244A40-0x0000000187244B70
		// [IDTag] // 0x000000018989F5A0-0x000000018989F5F0
		// [XID] // 0x000000018989F5A0-0x000000018989F5F0
		public static Texture2D GetCopy(this Texture2D tex, int x, int y, int w, int h, bool mipMaps) => default; // 0x0000000187244750-0x0000000187244920
		// [XID] // 0x00000001898ACF20-0x00000001898ACF60
		public static Texture2D ScaledCopy(this Texture2D tex, int width, int height, bool mipMaps) => default; // 0x0000000187245510-0x0000000187245780
		// [XID] // 0x00000001898B7690-0x00000001898B76D0
		public static void CopyFrom(this Texture2D tex, Texture2D fromTex, int toX, int toY, int fromX, int fromY, int width, int height) {} // 0x00000001872437E0-0x0000000187243A50
		// [XID] // 0x00000001898C1E50-0x00000001898C1E90
		public static void Scale(this Texture2D tex, int width, int height) {} // 0x0000000187245310-0x0000000187245510
		// [XID] // 0x00000001898CC460-0x00000001898CC4A0
		public static void MakeFormatWritable(this Texture2D tex) {} // 0x0000000187245180-0x0000000187245310
		// [IDTag] // 0x00000001898DEE70-0x00000001898DEEC0
		// [XID] // 0x00000001898DEE70-0x00000001898DEEC0
		public static Color GetAverageColor(this Texture2D tex) => default; // 0x0000000187243EA0-0x00000001872441F0
		// [IDTag] // 0x00000001898EC4F0-0x00000001898EC540
		// [XID] // 0x00000001898EC4F0-0x00000001898EC540
		public static Color GetAverageColor(this Texture2D tex, Color useThisColorForAlpha) => default; // 0x00000001872441F0-0x0000000187244620
		// [XID] // 0x00000001898F9DE0-0x00000001898F9E20
		public static bool IsReadable(this Texture2D tex) => default; // 0x0000000187245090-0x0000000187245180
		// [XID] // 0x00000001899047E0-0x0000000189904820
		public static bool HasTransparency(this Texture2D tex) => default; // 0x0000000187244F40-0x0000000187245090
		// [XID] // 0x00000001899169C0-0x0000000189916A00
		public static Texture2D GetUnityNormalMap(this Texture2D tex) => default; // 0x0000000187244B70-0x0000000187244E70
		// [XID] // 0x0000000189921030-0x0000000189921070
		public static Texture2D FromUnityNormalMap(this Texture2D tex) => default; // 0x0000000187243BA0-0x0000000187243EA0
		// [XID] // 0x000000018992B960-0x000000018992B9A0
		public static void Fill(this Texture2D tex, Color aColor) {} // 0x0000000187243A50-0x0000000187243BA0
	}
}
