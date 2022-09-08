/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class HIDLight // TypeDefIndex: 4052
	{
		// Fields
		private byte btODrqrTXLIQQrwfSRNgazppDrT; // 0x10
		private byte ZPBVbmZTCQvkmpKDDwuOinVLlLH; // 0x11
		private byte igVxxQLKMzPhpMmYVXPiNICtYwv; // 0x12
		private Action VLIacpadFzqLReAPgFHzRrPMtwzS; // 0x18
	
		// Properties
		public float ColorR { set {} } // 0x000000018582E4C0-0x000000018582E560
		public float ColorG { set {} } // 0x000000018582E3A0-0x000000018582E440
		public float ColorB { set {} } // 0x000000018582E250-0x000000018582E2F0
		public byte ColorRRaw { get => default; set {} } // 0x000000018582E080-0x000000018582E0E0 0x000000018582E440-0x000000018582E4C0
		public byte ColorGRaw { get => default; set {} } // 0x000000018582E020-0x000000018582E080 0x000000018582E2F0-0x000000018582E3A0
		public byte ColorBRaw { get => default; set {} } // 0x000000018582DFC0-0x000000018582E020 0x000000018582E1B0-0x000000018582E250
	
		// Events
		public event Action ValueChangedEvent;
	
		// Constructors
		public HIDLight() {} // Dummy constructor
		public HIDLight(byte colorRRaw, byte colorGRaw, byte colorBRaw) {} // 0x000000018582DE30-0x000000018582DED0
	}
}
