/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class DualRingReportBuffer : IDisposable // TypeDefIndex: 4393
	{
		// Fields
		private readonly int JsWqLyRAcXhZNkLsxjuBXfwhmWA; // 0x10
		private readonly int LnpURUNqdBexZJerDrDoTzgqArD; // 0x14
		private readonly int IMsCkPUMiKIpmqJuQyxgwOBBeab; // 0x18
		private NativeRingBuffer AgaeOzbnwbZTnLCldFCURFLGqBPs; // 0x20
		private NativeRingBuffer tOVIzhfcpcXHPgxsMptNgxCoFTu; // 0x28
		private byte[] jJSRcrVdTSEDJiIcYIAoKWwasXv; // 0x30
		private byte[] yklJZkXNbOufRZLvWdjJCNuimLZL; // 0x38
		private int VjumbiPgFmcOBdQukCYWmRDjfVeK; // 0x40
		private bool vsurYtRlepcrpAzAENwjqjJEZPT; // 0x44
	
		// Properties
		public byte[] ReadBuffer { get => default; } // 0x00000001862E0EC0-0x00000001862E0F20 
	
		// Constructors
		public DualRingReportBuffer() {} // Dummy constructor
		public DualRingReportBuffer(int entryByteLength, int entryCapacity) {} // 0x00000001862E0D30-0x00000001862E0EC0
	
		// Methods
		public int StartRead() => default; // 0x00000001862E0AC0-0x00000001862E0B40
		public int Read() => default; // 0x00000001862E09B0-0x00000001862E0AC0
		public int Write(byte[] buffer, int numBytesToWrite) => default; // 0x00000001862E0B40-0x00000001862E0D30
		public void Clear() {} // 0x00000001862E04A0-0x00000001862E05F0
		private void GgIqVHSIgmpaDqRKoxJUqmgcpzL() {} // 0x00000001862E0850-0x00000001862E09B0
		public void Dispose() {} // 0x00000001862E0670-0x00000001862E0740
		~DualRingReportBuffer() {} // 0x00000001862E0740-0x00000001862E0850
		protected void Dispose(bool disposing) {} // 0x00000001862E05F0-0x00000001862E0670
	}
}
