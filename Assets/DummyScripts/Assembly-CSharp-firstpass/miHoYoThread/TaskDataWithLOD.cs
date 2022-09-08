/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoThread
{
	public abstract class TaskDataWithLOD // TypeDefIndex: 9081
	{
		// Fields
		private bool _hasCollected; // 0x20
	
		// Properties
		public Func<float> onGetDeltaTime { /* [XID] */ /* 0x0000000189BB4940-0x0000000189BB4980 */ private get; /* [XID] */ /* 0x0000000189BBEBF0-0x0000000189BBEC30 */ set; } // 0x000000018763DD40-0x000000018763DDA0 0x000000018763DE00-0x000000018763DE60
		public Func<bool> onShouldPause { /* [XID] */ /* 0x0000000189BC9B00-0x0000000189BC9B40 */ private get; /* [XID] */ /* 0x0000000189BD42D0-0x0000000189BD4310 */ set; } // 0x000000018763DDA0-0x000000018763DE00 0x000000018763DE60-0x000000018763DF60
		protected float deltaTime { /* [XID] */ /* 0x00000001898AED80-0x00000001898AEDA0 */ get; } // 0x000000018763DC40-0x000000018763DD40 
	
		// Constructors
		protected TaskDataWithLOD() {} // 0x000000018763DBD0-0x000000018763DC40
	
		// Methods
		// [XID] // 0x00000001895EB730-0x00000001895EB750
		public bool ShouldCollect(bool considerPauseOnly) => default; // 0x000000018763D910-0x000000018763DA90
		// [XID] // 0x000000018998D3D0-0x000000018998D3F0
		public bool ShouldExecute() => default; // 0x000000018763DA90-0x000000018763DB30
		// [XID] // 0x00000001895FA400-0x00000001895FA420
		public bool ShouldFlush() => default; // 0x000000018763DB30-0x000000018763DBD0
		// [XID] // 0x0000000189601D90-0x0000000189601DB0
		protected virtual void Clear() {} // 0x000000018763D7F0-0x000000018763D910
	}
}
