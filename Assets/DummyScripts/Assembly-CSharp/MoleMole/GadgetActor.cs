/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189B2DD20-0x0000000189B2DD60
	[RecycleType] // 0x0000000189B2DD20-0x0000000189B2DD60
	public sealed class GadgetActor : EntityActor, IAutoAllocRecycle // TypeDefIndex: 20201
	{
		// Constructors
		public GadgetActor() {} // 0x0000000181F80570-0x0000000181F805D0
	
		// Methods
		[BlackList] // 0x00000001898C4300-0x00000001898C4340
		// [XID] // 0x00000001898C4300-0x00000001898C4340
		public override void AutoAllocTypeFields() {} // 0x0000000181F7FE10-0x0000000181F7FEB0
		[BlackList] // 0x00000001898CE870-0x00000001898CE8B0
		// [XID] // 0x00000001898CE870-0x00000001898CE8B0
		public override void AutoRecycleTypeFields() {} // 0x0000000181F7FEB0-0x0000000181F7FF50
		[BlackList] // 0x00000001898D92D0-0x00000001898D9310
		// [XID] // 0x00000001898D92D0-0x00000001898D9310
		public override void ReturnToObjectPool() {} // 0x0000000181F802B0-0x0000000181F80350
		// [XID] // 0x00000001898E3DC0-0x00000001898E3DE0
		public void AddSimpleTrigger(float distance, DistType distType, Vector3 avatarOffset, Action<ILuaActor> funcTriggerIn, Action<ILuaActor> funcTriggerOut, Action<ILuaActor> funcTriggerTick) {} // 0x0000000181F7FC20-0x0000000181F7FE10
		// [XID] // 0x00000001898EB8F0-0x00000001898EB910
		public void AddCommonTrigger(ILuaShapeData shapeData, Action<ILuaActor, uint, string> funcTriggerIn, Action<ILuaActor, uint, string> funcTriggerOut, Action<ILuaActor, uint, string> funcTriggerTick) {} // 0x0000000181F7F710-0x0000000181F7FC20
		// [XID] // 0x00000001898F3120-0x00000001898F3140
		public override void InitEntity(BaseEntity entity) {} // 0x0000000181F80030-0x0000000181F80100
		// [XID] // 0x00000001898FA7A0-0x00000001898FA7C0
		public void PostInitEntity() {} // 0x0000000181F80100-0x0000000181F802B0
		// [XID] // 0x0000000189902230-0x0000000189902250
		public override void Destroy(bool isActorOnly) {} // 0x0000000181F7FF50-0x0000000181F80030
	}
}
