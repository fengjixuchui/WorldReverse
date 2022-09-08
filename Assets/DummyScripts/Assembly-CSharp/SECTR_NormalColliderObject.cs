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
public sealed class SECTR_NormalColliderObject : SECTR_ColliderObject, IAutoAllocRecycleJobThread // TypeDefIndex: 20296
{
	// Fields
	public SECTR_VOFinInfo voInfo; // 0x88

	// Constructors
	public SECTR_NormalColliderObject() {} // 0x0000000185464730-0x0000000185464790

	// Methods
	[BlackList] // 0x000000018989E9A0-0x000000018989E9E0
	// [XID] // 0x000000018989E9A0-0x000000018989E9E0
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000185464000-0x00000001854640B0
	[BlackList] // 0x00000001898A9350-0x00000001898A9390
	// [XID] // 0x00000001898A9350-0x00000001898A9390
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001854640B0-0x0000000185464170
	[BlackList] // 0x00000001898B3860-0x00000001898B38A0
	// [XID] // 0x00000001898B3860-0x00000001898B38A0
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000185464680-0x0000000185464730
	// [XID] // 0x00000001898BE040-0x00000001898BE060
	public override void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000185464170-0x0000000185464370
	// [XID] // 0x00000001898C58F0-0x00000001898C5910
	protected override ulong GetColliderPath() => default; // 0x0000000185464550-0x0000000185464600
}

