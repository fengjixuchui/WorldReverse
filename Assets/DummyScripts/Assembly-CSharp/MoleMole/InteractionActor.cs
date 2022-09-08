/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189B018C0-0x0000000189B01900
	[RecycleType] // 0x0000000189B018C0-0x0000000189B01900
	public sealed class InteractionActor : GlobalActor, IAutoAllocRecycle // TypeDefIndex: 20205
	{
		// Fields
		private InteractionManager _interMgr; // 0x120
		private Action<ILuaActor, int> _OnStartInterCallBack; // 0x128
		private Action<ILuaActor, int> _OnFinishInterCallBack; // 0x130
	
		// Constructors
		public InteractionActor() {} // 0x0000000182BB2630-0x0000000182BB26B0
	
		// Methods
		[BlackList] // 0x0000000189B0BDD0-0x0000000189B0BE10
		// [XID] // 0x0000000189B0BDD0-0x0000000189B0BE10
		public override void AutoAllocTypeFields() {} // 0x0000000182BB19A0-0x0000000182BB1A40
		[BlackList] // 0x0000000189B16130-0x0000000189B16170
		// [XID] // 0x0000000189B16130-0x0000000189B16170
		public override void AutoRecycleTypeFields() {} // 0x0000000182BB1A40-0x0000000182BB1B00
		[BlackList] // 0x0000000189B20830-0x0000000189B20870
		// [XID] // 0x0000000189B20830-0x0000000189B20870
		public override void ReturnToObjectPool() {} // 0x0000000182BB21B0-0x0000000182BB2250
		// [XID] // 0x0000000189B2AE40-0x0000000189B2AE60
		public override void InitGlobal() {} // 0x0000000182BB1C90-0x0000000182BB1E10
		// [XID] // 0x0000000189B323C0-0x0000000189B323E0
		private void OnStartInterEvent(ILuaActor luaActor, int cnt) {} // 0x0000000182BB1EF0-0x0000000182BB1FD0
		// [XID] // 0x0000000189B39CF0-0x0000000189B39D10
		private void OnFinishInterEvent(ILuaActor luaActor, int cnt) {} // 0x0000000182BB1E10-0x0000000182BB1EF0
		// [XID] // 0x0000000189B415B0-0x0000000189B415D0
		public override void Destroy(bool isActorOnly) {} // 0x0000000182BB1B00-0x0000000182BB1C90
		// [XID] // 0x0000000189B48F80-0x0000000189B48FA0
		public void RegisterStartInterCallback(Action<ILuaActor, int> callback) {} // 0x0000000182BB20C0-0x0000000182BB21B0
		// [XID] // 0x0000000189B50580-0x0000000189B505A0
		public void UnregisterStartInterCallback(Action<ILuaActor, int> callback) {} // 0x0000000182BB2540-0x0000000182BB2630
		// [XID] // 0x0000000189B57E50-0x0000000189B57E70
		public void RegisterFinishInterCallback(Action<ILuaActor, int> callback) {} // 0x0000000182BB1FD0-0x0000000182BB20C0
		// [XID] // 0x0000000189B5F810-0x0000000189B5F830
		public void UnregisterFinishInterCallback(Action<ILuaActor, int> callback) {} // 0x0000000182BB2450-0x0000000182BB2540
	}
}
