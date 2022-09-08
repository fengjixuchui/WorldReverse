/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000189967760-0x00000001899677B0
	[CustomObfuscation] // 0x0000000189967760-0x00000001899677B0
	internal class UnityUnifiedMouseSource : IDisposable, IUnifiedMouseSource // TypeDefIndex: 4077
	{
		// Fields
		private static HardwareControllerMap_Game cLVUPgpXvNTHDsnZDRDXonKMcJy; // 0x00
		private UpdateLoopDataSet<ELNUHPVDFzjdVKAQJTgqKUqliOWI> mtnCXNhGEJZnJZGQpwPudPTRhtR; // 0x10
		private float[] lDcuUEeYdvJFXXyZLebbawNxBQj; // 0x18
		private bool[] LBfpgqAWVyAGHfuvtIBMkEiLzMs; // 0x20
		private bool vsurYtRlepcrpAzAENwjqjJEZPT; // 0x28
	
		// Properties
		public InputSource inputSource { get => default; } // 0x00000001855768E0-0x0000000185576930 
		public HardwareControllerMap_Game hardwareMap { get => default; } // 0x0000000185576840-0x00000001855768E0 
		public int buttonCount { get => default; } // 0x00000001855767F0-0x0000000185576840 
		public int axisCount { get => default; } // 0x00000001855767A0-0x00000001855767F0 
		public Vector2 mousePosition { get => default; } // 0x0000000185576930-0x0000000185576A30 
	
		// Nested types
		private class ELNUHPVDFzjdVKAQJTgqKUqliOWI // TypeDefIndex: 4078
		{
			// Fields
			private float[] lDcuUEeYdvJFXXyZLebbawNxBQj; // 0x10
			private bool[] LBfpgqAWVyAGHfuvtIBMkEiLzMs; // 0x18
	
			// Constructors
			public ELNUHPVDFzjdVKAQJTgqKUqliOWI() {} // Dummy constructor
			public ELNUHPVDFzjdVKAQJTgqKUqliOWI(int buttonCount, int axisCount) {} // 0x00000001855512E0-0x00000001855513A0
	
			// Methods
			public void LBpsVaSXSQkcwnTMybAtexLXfOw(bool[] param_0000877a, float[] param_0000877b) {} // 0x00000001855510E0-0x0000000185551220
			public void ZZebUlUGtjBzpJmgHcPisXyZtae(ControllerDataUpdater param_0000877c) {} // 0x0000000185551220-0x00000001855512E0
			public void sEJGlOIjzgifzyhkCWeYUBDjqdxq() {} // 0x00000001855513A0-0x0000000185551420
		}
	
		// Constructors
		public UnityUnifiedMouseSource() {} // 0x0000000185575A10-0x0000000185575C50
	
		// Methods
		public void UpdateInputData(ControllerDataUpdater dataUpdater) {} // 0x0000000185575940-0x0000000185575A10
		private void kLzgfkzvBIVVaIZuWaxWRsCUVMk() {} // 0x0000000185576A30-0x0000000185576B90
		private void gZimAxINAGanCPPcmrEUhkBFAW(UpdateLoopType param_00008776) {} // 0x0000000185576700-0x00000001855767A0
		private static HardwareControllerMap_Game aLwAgqfgniRIvXABCwRQKPbNEES() => default; // 0x0000000185575C50-0x0000000185576680
		public void Dispose() {} // 0x0000000185575690-0x0000000185575710
		~UnityUnifiedMouseSource() {} // 0x0000000185575890-0x0000000185575940
		protected virtual void Dispose(bool disposing) {} // 0x0000000185575710-0x0000000185575890
	}
}
