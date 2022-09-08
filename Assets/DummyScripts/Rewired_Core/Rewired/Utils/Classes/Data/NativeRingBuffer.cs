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

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class NativeRingBuffer : IDisposable // TypeDefIndex: 4343
	{
		// Fields
		private readonly NativeBuffer HaaYbekkYkVzqIEKjXoDUBlmwQE; // 0x10
		private readonly int ZQtXcXYFxPSVYxnpniroAAvoIDE; // 0x18
		private long eSDdjSVXrpQWppMZyfdHMKkSkBV; // 0x20
		private long xuRVibkStwYJzfDZINhAtRbfsJa; // 0x28
		private int lakhHRvvHYCEDhrWoTamMOvOGCOA; // 0x30
		private bool LnRforneFjeSPukYMublsguMNfU; // 0x34
		private uint MPvtJorjPXvtIhcDDDtlhGMqkgSA; // 0x38
		private bool vsurYtRlepcrpAzAENwjqjJEZPT; // 0x3C
	
		// Properties
		public int BytesInBuffer { get => default; } // 0x0000000185558E70-0x0000000185558ED0 
	
		// Constructors
		public NativeRingBuffer() {} // Dummy constructor
		public NativeRingBuffer(int capacity) {} // 0x0000000185558DA0-0x0000000185558E70
	
		// Methods
		public int Write(byte[] buffer, int numBytesToWrite, out int startOffset, out uint passId) {
			startOffset = default;
			passId = default;
			return default;
		} // 0x0000000185558A50-0x0000000185558DA0
		public int Write(byte[] buffer, int numBytesToWrite) => default; // 0x00000001855589B0-0x0000000185558A50
		public int Read(byte[] buffer, int numBytesToRead) => default; // 0x0000000185558520-0x0000000185558700
		public void Reset() {} // 0x0000000185558700-0x0000000185558770
		private void VGdBuWGqPpjEfjkGGPOSNVjFMEHI(int param_000090dc) {} // 0x0000000185558770-0x00000001855589B0
		private void rZfgvnvVyLImXvEbSdviOPICNOS(int param_000090dd) {} // 0x0000000185558F40-0x0000000185559020
		private void nyzhfttLDYyCPlHxXwExnunHcrN() {} // 0x0000000185558ED0-0x0000000185558F40
		public void Dispose() {} // 0x00000001855581F0-0x0000000185558300
		~NativeRingBuffer() {} // 0x00000001855583D0-0x0000000185558520
		protected void Dispose(bool disposing) {} // 0x0000000185558300-0x00000001855583D0
	}
}
