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
public class AIMoveKnowledge : IAutoAllocRecycle // TypeDefIndex: 19957
{
	// Fields
	public ConfigAIMove config; // 0x10
	public bool canFly; // 0x18
	public bool disableMoveTactic; // 0x19
	public bool inAir; // 0x1A
	public bool inWater; // 0x1B

	// Constructors
	public AIMoveKnowledge() {} // 0x0000000181956990-0x0000000181956A00

	// Methods
	[BlackList] // 0x0000000189884390-0x00000001898843D0
	// [XID] // 0x0000000189884390-0x00000001898843D0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181956310-0x00000001819563B0
	[BlackList] // 0x000000018988E7C0-0x000000018988E800
	// [XID] // 0x000000018988E7C0-0x000000018988E800
	public virtual void AutoRecycleTypeFields() {} // 0x00000001819563B0-0x0000000181956460
	[BlackList] // 0x0000000189898FD0-0x0000000189899010
	// [XID] // 0x0000000189898FD0-0x0000000189899010
	public virtual void ReturnToObjectPool() {} // 0x00000001819568F0-0x0000000181956990
	[BlackList] // 0x00000001898A3360-0x00000001898A33A0
	// [XID] // 0x00000001898A3360-0x00000001898A33A0
	public virtual void OnPoolAllocated() {} // 0x0000000181956750-0x00000001819567F0
	[BlackList] // 0x00000001898ADBB0-0x00000001898ADBF0
	// [XID] // 0x00000001898ADBB0-0x00000001898ADBF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001819566B0-0x0000000181956750
	// [XID] // 0x00000001898B82E0-0x00000001898B8300
	public void ReInitByConfigID(BaseEntity.ReInitReason reason) {} // 0x0000000181956600-0x00000001819566B0
	// [XID] // 0x0000000189921090-0x00000001899210B0
	public void InitMove(ConfigAIMove moveSetting) {} // 0x0000000181956460-0x0000000181956510
	// [XID] // 0x00000001898C7320-0x00000001898C7340
	public float GetAlmostReachDistance(AIMoveSpeedLevel speed) => default; // 0x0000000181956510-0x0000000181956600
	// [XID] // 0x00000001898CE8D0-0x00000001898CE8F0
	public bool ShouldUseNavMesh() => default; // 0x00000001819567F0-0x00000001819568F0
}

