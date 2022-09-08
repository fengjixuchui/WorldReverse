/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public sealed class LuaLimitRegionTask : LuaTask // TypeDefIndex: 21154
	{
		// Fields
		private bool _guiding; // 0x78
		private float _guidingDurationCnt; // 0x7C
		private float _guidingDuration; // 0x80
		private float _warningDurationCnt; // 0x84
		private float _warningDuration; // 0x88
		private bool _warning; // 0x8C
		private float _testLength; // 0x90
		private float _transOffset; // 0x94
		private bool _pauseTask; // 0x98
		private float _curInterval; // 0x9C
		private float _maxInterval; // 0xA0
		private ILimitRegionCallProxy _proxy; // 0xA8
	
		// Constructors
		public LuaLimitRegionTask() {} // 0x0000000184F07560-0x0000000184F075F0
	
		// Methods
		// [XID] // 0x00000001895E7430-0x00000001895E7450
		public void InitWithData(ILimitRegionTaskData data, ILimitRegionCallProxy proxy) {} // 0x0000000184F06C70-0x0000000184F06DC0
		// [XID] // 0x00000001895EED20-0x00000001895EED40
		protected override void TickInternal() {} // 0x0000000184F06E90-0x0000000184F073A0
		// [XID] // 0x00000001895F66E0-0x00000001895F6700
		private void UnPauseTask() {} // 0x0000000184F074C0-0x0000000184F07560
		// [XID] // 0x00000001895FDAA0-0x00000001895FDAC0
		protected override void DestroyInternal() {} // 0x0000000184F06BA0-0x0000000184F06C70
		// [XID] // 0x00000001896052F0-0x0000000189605310
		protected override void ReleaseTask() {} // 0x0000000184F06DC0-0x0000000184F06E90
	}
}
