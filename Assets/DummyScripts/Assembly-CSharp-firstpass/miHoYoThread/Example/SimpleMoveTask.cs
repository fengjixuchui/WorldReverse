/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using miHoYoThread;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread.Example
{
	public class SimpleMoveTask : ThreadGroupTask<SimpleMoveData> // TypeDefIndex: 9085
	{
		// Fields
		private float _xRatio; // 0x38
		private float _yRatio; // 0x3C
		private float _zRatio; // 0x40
		private float _deltaTime; // 0x44
	
		// Properties
		public override string taskName { /* [XID] */ /* 0x00000001898A2810-0x00000001898A2830 */ get => default; } // 0x000000018726D7F0-0x000000018726D8A0 
	
		// Constructors
		public SimpleMoveTask() {} // 0x000000018726D760-0x000000018726D7F0
	
		// Methods
		// [XID] // 0x00000001896C9DC0-0x00000001896C9DE0
		protected override void CollectInternal(int index) {} // 0x000000018726CFF0-0x000000018726D220
		// [XID] // 0x00000001896D1540-0x00000001896D1560
		protected override void ExecuteInternal(int index) {} // 0x000000018726D220-0x000000018726D440
		// [XID] // 0x00000001899E8A20-0x00000001899E8A40
		protected override void FlushInternal(int index) {} // 0x000000018726D440-0x000000018726D5A0
	}
}
