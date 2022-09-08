/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class AITacticCondition : IAutoAllocRecycle // TypeDefIndex: 19978
{
	// Fields
	// [PooledField] // 0x00000001897FDA20-0x00000001897FDA40
	private AIPoseSelector _requiredPoses; // 0x10

	// Constructors
	public AITacticCondition() {} // 0x0000000183752200-0x0000000183752260

	// Methods
	[BlackList] // 0x00000001899712A0-0x00000001899712E0
	// [XID] // 0x00000001899712A0-0x00000001899712E0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183751CD0-0x0000000183751DA0
	[BlackList] // 0x000000018997B730-0x000000018997B770
	// [XID] // 0x000000018997B730-0x000000018997B770
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183751DA0-0x0000000183751E70
	[BlackList] // 0x0000000189985D10-0x0000000189985D50
	// [XID] // 0x0000000189985D10-0x0000000189985D50
	public virtual void ReturnToObjectPool() {} // 0x0000000183752160-0x0000000183752200
	[BlackList] // 0x0000000189990970-0x00000001899909B0
	// [XID] // 0x0000000189990970-0x00000001899909B0
	public virtual void OnPoolAllocated() {} // 0x00000001837520C0-0x0000000183752160
	[BlackList] // 0x000000018999B620-0x000000018999B660
	// [XID] // 0x000000018999B620-0x000000018999B660
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183752020-0x00000001837520C0
	// [XID] // 0x00000001899A6190-0x00000001899A61B0
	public void Init(ConfigAITacticCondition tacticCondition) {} // 0x0000000183751F50-0x0000000183752020
	// [XID] // 0x00000001899AD780-0x00000001899AD7A0
	public bool CheckPose(AIKnowledge knowledge) => default; // 0x0000000183751E70-0x0000000183751F50
}

