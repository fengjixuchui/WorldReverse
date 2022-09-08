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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x0000000189ADEFB0-0x0000000189ADEFD0
public sealed class SECTR_LODColliderObject : SECTR_ColliderObject, IAutoAllocRecycleJobThread // TypeDefIndex: 20270
{
	// Fields
	public SECTR_LODFinInfo lodInfo; // 0x88

	// Constructors
	public SECTR_LODColliderObject() {} // 0x00000001840DE480-0x00000001840DE4E0

	// Methods
	[BlackList] // 0x0000000189AE6880-0x0000000189AE68C0
	// [XID] // 0x0000000189AE6880-0x0000000189AE68C0
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001840DDD50-0x00000001840DDE00
	[BlackList] // 0x0000000189AF14D0-0x0000000189AF1510
	// [XID] // 0x0000000189AF14D0-0x0000000189AF1510
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001840DDE00-0x00000001840DDEC0
	[BlackList] // 0x0000000189AFB980-0x0000000189AFB9C0
	// [XID] // 0x0000000189AFB980-0x0000000189AFB9C0
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001840DE3D0-0x00000001840DE480
	// [XID] // 0x0000000189B06000-0x0000000189B06020
	public override void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001840DDEC0-0x00000001840DE0C0
	// [XID] // 0x0000000189B0D730-0x0000000189B0D750
	protected override ulong GetColliderPath() => default; // 0x00000001840DE2A0-0x00000001840DE350
}

