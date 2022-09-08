/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace StatsMonitor
{
	internal sealed class SMGraphicsUtil // TypeDefIndex: 9059
	{
		// Fields
		internal GameObject parent; // 0x10
		internal Color defaultColor; // 0x18
		internal Font defaultFontFace; // 0x28
		internal int defaultFontSize; // 0x30
		internal static Vector2 defaultEffectDistance; // 0x00
	
		// Constructors
		public SMGraphicsUtil() {} // Dummy constructor
		internal SMGraphicsUtil(GameObject parent, Color defaultColor, Font defaultFontFace = null, int defaultFontSize = 16 /* Metadata: 0x00AE514E */) {} // 0x0000000186F22480-0x0000000186F22510
		static SMGraphicsUtil() {} // 0x0000000186F223F0-0x0000000186F22480
	
		// Methods
		// [XID] // 0x0000000189872040-0x0000000189872060
		internal Graphic Graphic(string name, System.Type type, float x = 0f /* Metadata: 0x00AE5152 */, float y = 0f /* Metadata: 0x00AE5156 */, float w = 0f /* Metadata: 0x00AE515A */, float h = 0f /* Metadata: 0x00AE515E */, Color? color = default) => default; // 0x0000000186F21590-0x0000000186F21910
		// [XID] // 0x0000000189879800-0x0000000189879820
		internal Image Image(string name, float x = 0f /* Metadata: 0x00AE5162 */, float y = 0f /* Metadata: 0x00AE5166 */, float w = 0f /* Metadata: 0x00AE516A */, float h = 0f /* Metadata: 0x00AE516E */, Color? color = default) => default; // 0x0000000186F21910-0x0000000186F21AE0
		// [XID] // 0x0000000189880E10-0x0000000189880E30
		internal RawImage RawImage(string name, float x = 0f /* Metadata: 0x00AE5172 */, float y = 0f /* Metadata: 0x00AE5176 */, float w = 0f /* Metadata: 0x00AE517A */, float h = 0f /* Metadata: 0x00AE517E */, Color? color = default) => default; // 0x0000000186F21AE0-0x0000000186F21CB0
		// [IDTag] // 0x0000000189888190-0x00000001898881D0
		// [XID] // 0x0000000189888190-0x00000001898881D0
		internal UnityEngine.UI.Text Text(string name, float x = 0f /* Metadata: 0x00AE5182 */, float y = 0f /* Metadata: 0x00AE5186 */, float w = 0f /* Metadata: 0x00AE518A */, float h = 0f /* Metadata: 0x00AE518E */, string text = "" /* Metadata: 0x00AE5192 */, Color? color = default, int fontSize = 0 /* Metadata: 0x00AE5196 */, Font fontFace = null, bool fitH = false /* Metadata: 0x00AE519A */, bool fitV = false /* Metadata: 0x00AE519B */) => default; // 0x0000000186F220E0-0x0000000186F223F0
		// [IDTag] // 0x0000000189892440-0x0000000189892480
		// [XID] // 0x0000000189892440-0x0000000189892480
		internal UnityEngine.UI.Text Text(string name, string text = "" /* Metadata: 0x00AE519C */, Color? color = default, int fontSize = 0 /* Metadata: 0x00AE51A0 */, Font fontFace = null, bool fitH = true /* Metadata: 0x00AE51A4 */, bool fitV = true /* Metadata: 0x00AE51A5 */) => default; // 0x0000000186F21E40-0x0000000186F220E0
		// [XID] // 0x000000018989CB40-0x000000018989CB60
		internal static void FitText(UnityEngine.UI.Text text, bool h, bool v) {} // 0x0000000186F213E0-0x0000000186F21590
		// [XID] // 0x00000001898A4300-0x00000001898A4320
		internal static Outline AddOutline(GameObject obj, Color color, Vector2? distance = default) => default; // 0x0000000186F21000-0x0000000186F211F0
		// [XID] // 0x00000001898BE460-0x00000001898BE480
		internal static Shadow AddShadow(GameObject obj, Color color, Vector2? distance = default) => default; // 0x0000000186F211F0-0x0000000186F213E0
		// [XID] // 0x00000001898B2E00-0x00000001898B2E20
		internal static void AddOutlineAndShadow(GameObject obj, Color color, Vector2? distance = default) {} // 0x0000000186F20D30-0x0000000186F21000
		// [XID] // 0x00000001898DC790-0x00000001898DC7B0
		internal static void RemoveEffects(GameObject obj) {} // 0x0000000186F21CB0-0x0000000186F21E40
	}
}
