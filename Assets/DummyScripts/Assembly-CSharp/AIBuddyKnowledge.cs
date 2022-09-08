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
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public sealed class AIBuddyKnowledge : Switchable, IAutoAllocRecycle // TypeDefIndex: 19948
{
	// Fields
	public ConfigAIBuddySetting config; // 0x18
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	public List<BaseEntity> buddyEntities; // 0x20
	public float buddyDistanceMax; // 0x28

	// Constructors
	public AIBuddyKnowledge() {} // 0x00000001830617B0-0x00000001830618F0

	// Methods
	[BlackList] // 0x00000001899DBB10-0x00000001899DBB50
	// [XID] // 0x00000001899DBB10-0x00000001899DBB50
	public override void AutoAllocTypeFields() {} // 0x0000000183061290-0x0000000183061360
	[BlackList] // 0x00000001899E6590-0x00000001899E65D0
	// [XID] // 0x00000001899E6590-0x00000001899E65D0
	public override void AutoRecycleTypeFields() {} // 0x0000000183061360-0x0000000183061420
	[BlackList] // 0x00000001899F0A70-0x00000001899F0AB0
	// [XID] // 0x00000001899F0A70-0x00000001899F0AB0
	public override void ReturnToObjectPool() {} // 0x0000000183061710-0x00000001830617B0
	// [XID] // 0x00000001899FB590-0x00000001899FB5B0
	public void InitBuddySystem(ConfigAIBuddySetting buddySetting) {} // 0x0000000183061540-0x0000000183061640
	// [XID] // 0x0000000189A02830-0x0000000189A02850
	public void ReInitByConfigID(BaseEntity.ReInitReason reason) {} // 0x0000000183061640-0x0000000183061710
}

