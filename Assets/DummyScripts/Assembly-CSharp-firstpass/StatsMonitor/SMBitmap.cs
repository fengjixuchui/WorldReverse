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

namespace StatsMonitor
{
	internal sealed class SMBitmap // TypeDefIndex: 9058
	{
		// Fields
		internal Texture2D texture; // 0x10
		internal Color color; // 0x18
		private readonly Rect _rect; // 0x28
	
		// Constructors
		public SMBitmap() {} // Dummy constructor
		internal SMBitmap(int width, int height, Color? color = default) {} // 0x0000000186F20A50-0x0000000186F20BD0
		internal SMBitmap(float width, float height, Color? color = default) {} // 0x0000000186F20BD0-0x0000000186F20D30
	
		// Methods
		// [XID] // 0x0000000189914600-0x0000000189914620
		internal void Resize(int width, int height) {} // 0x0000000186F204B0-0x0000000186F205A0
		// [XID] // 0x00000001899237E0-0x0000000189923800
		internal void Clear(Color? color = default) {} // 0x0000000186F1F940-0x0000000186F1FAD0
		// [IDTag] // 0x0000000189816700-0x0000000189816740
		// [XID] // 0x0000000189816700-0x0000000189816740
		internal void FillRect(Rect? rect = default, Color? color = default) {} // 0x0000000186F200B0-0x0000000186F20320
		// [IDTag] // 0x00000001898213E0-0x0000000189821420
		// [XID] // 0x00000001898213E0-0x0000000189821420
		internal void FillRect(int x, int y, int w, int h, Color? color = default) {} // 0x0000000186F1FEC0-0x0000000186F200B0
		// [IDTag] // 0x000000018982B780-0x000000018982B7C0
		// [XID] // 0x000000018982B780-0x000000018982B7C0
		internal void FillColumn(int x, Color? color = default) {} // 0x0000000186F1FD30-0x0000000186F1FEC0
		// [IDTag] // 0x0000000189835CD0-0x0000000189835D10
		// [XID] // 0x0000000189835CD0-0x0000000189835D10
		internal void FillColumn(int x, int y, int height, Color? color = default) {} // 0x0000000186F1FBA0-0x0000000186F1FD30
		// [XID] // 0x000000018986E7F0-0x000000018986E810
		internal void FillRow(int y, Color? color = default) {} // 0x0000000186F20320-0x0000000186F204B0
		// [IDTag] // 0x0000000189847740-0x0000000189847780
		// [XID] // 0x0000000189847740-0x0000000189847780
		internal void SetPixel(int x, int y, Color color) {} // 0x0000000186F20820-0x0000000186F20930
		// [IDTag] // 0x0000000189851B00-0x0000000189851B40
		// [XID] // 0x0000000189851B00-0x0000000189851B40
		internal void SetPixel(float x, float y, Color color) {} // 0x0000000186F20930-0x0000000186F20A50
		// [XID] // 0x000000018973D630-0x000000018973D650
		internal void Scroll(int x, Color? fillColor = default) {} // 0x0000000186F205A0-0x0000000186F20820
		// [XID] // 0x0000000189863930-0x0000000189863950
		internal void Apply() {} // 0x0000000186F1F890-0x0000000186F1F940
		// [XID] // 0x000000018986AC20-0x000000018986AC40
		internal void Dispose() {} // 0x0000000186F1FAD0-0x0000000186F1FBA0
	}
}
