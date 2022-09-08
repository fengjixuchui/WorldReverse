/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[fiInspectorOnly] // 0x0000000189B14C10-0x0000000189B14C50
[RecycleType] // 0x0000000189B14C10-0x0000000189B14C50
public sealed class SECTR_NormalObject : SECTR_ColliderObject, IAutoAllocRecycleJobThread // TypeDefIndex: 20297
{
	// Fields
	public SECTR_GUID objGuid; // 0x88
	public SECTR_VOFinInfo voInfo; // 0x90
	// [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
	private SECTR_Manager.LoadGameObjectCallBack _normalLoadCB; // 0x98

	// Constructors
	public SECTR_NormalObject() {} // 0x00000001848BF880-0x00000001848BF930

	// Methods
	[BlackList] // 0x00000001898DF800-0x00000001898DF840
	// [XID] // 0x00000001898DF800-0x00000001898DF840
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001848BECB0-0x00000001848BED60
	[BlackList] // 0x00000001898EA290-0x00000001898EA2D0
	// [XID] // 0x00000001898EA290-0x00000001898EA2D0
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001848BED60-0x00000001848BEE20
	[BlackList] // 0x00000001898F4820-0x00000001898F4860
	// [XID] // 0x00000001898F4820-0x00000001898F4860
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001848BF7D0-0x00000001848BF880
	// [XID] // 0x00000001898FF0D0-0x00000001898FF0F0
	public override void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001848BEE20-0x00000001848BF090
	// [XID] // 0x0000000189906850-0x0000000189906870
	private void LoadNormalObjectCB(SECTR_GUID guid, GameObject obj) {} // 0x00000001848BF190-0x00000001848BF290
	// [XID] // 0x000000018990E3B0-0x000000018990E3D0
	protected override ulong GetColliderPath() => default; // 0x00000001848BF3F0-0x00000001848BF4E0
	// [XID] // 0x0000000189915AC0-0x0000000189915AE0
	public override void SetActive(bool isActive) {} // 0x00000001848BF700-0x00000001848BF7D0
	// [XID] // 0x000000018991D490-0x000000018991D4B0
	public override void UnLoad(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001848BF4E0-0x00000001848BF5F0
}

