/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public sealed class LuaFreeStyleTask : LuaTask // TypeDefIndex: 21146
	{
		// Fields
		private EntityActor _entityActor; // 0x78
		private int _freeStyleType; // 0x80
	
		// Constructors
		public LuaFreeStyleTask() {} // 0x0000000184F01AA0-0x0000000184F01B20
	
		// Methods
		// [XID] // 0x0000000189996AE0-0x0000000189996B00
		public void SetFreeStyleType(int freeStyleType) {} // 0x0000000184F01770-0x0000000184F01820
		[BlackList] // 0x000000018999E650-0x000000018999E690
		// [XID] // 0x000000018999E650-0x000000018999E690
		public override void Init(LuaTaskType taskType, int taskQueueID, BaseActor actor, string tag) {} // 0x0000000184F01480-0x0000000184F015E0
		// [XID] // 0x00000001899A8F20-0x00000001899A8F40
		public override void Tick() {} // 0x0000000184F01820-0x0000000184F018E0
		// [XID] // 0x00000001899B0910-0x00000001899B0930
		private void CheckFinish() {} // 0x0000000184F01250-0x0000000184F01300
		// [XID] // 0x0000000189B61920-0x0000000189B61940
		public bool IsCurrentFreeTask(int freeStyleType) => default; // 0x0000000184F015E0-0x0000000184F016A0
		// [XID] // 0x00000001899BF6B0-0x00000001899BF6D0
		public void FinishFreeStyleTask(int freeStyleType) {} // 0x0000000184F013C0-0x0000000184F01480
		// [XID] // 0x00000001899C7070-0x00000001899C7090
		protected override void DestroyInternal() {} // 0x0000000184F01300-0x0000000184F013C0
		// [XID] // 0x00000001899CE550-0x00000001899CE570
		protected override void ReleaseTask() {} // 0x0000000184F016A0-0x0000000184F01770
	}
}
