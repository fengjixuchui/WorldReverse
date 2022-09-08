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
public class SECTR_RawObject : SECTR_BaseObject, IAutoAllocRecycleJobThread // TypeDefIndex: 20301
{
	// Fields
	private SECTR_GUID _rawGuid; // 0x68
	// [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
	private SECTR_Manager.LoadGameObjectCallBack _rawLoadCB; // 0x70

	// Constructors
	public SECTR_RawObject() {} // 0x0000000181C6C500-0x0000000181C6C5B0

	// Methods
	[BlackList] // 0x00000001899BE010-0x00000001899BE050
	// [XID] // 0x00000001899BE010-0x00000001899BE050
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000181C6BAE0-0x0000000181C6BB90
	[BlackList] // 0x00000001899C8510-0x00000001899C8550
	// [XID] // 0x00000001899C8510-0x00000001899C8550
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000181C6BB90-0x0000000181C6BC50
	[BlackList] // 0x00000001899D2C90-0x00000001899D2CD0
	// [XID] // 0x00000001899D2C90-0x00000001899D2CD0
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000181C6C450-0x0000000181C6C500
	// [XID] // 0x00000001899DD1C0-0x00000001899DD1E0
	public override void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000181C6BC50-0x0000000181C6BE40
	// [XID] // 0x00000001899E4DA0-0x00000001899E4DC0
	protected virtual void LoadRawObjectCB(SECTR_GUID guid, GameObject obj) {} // 0x0000000181C6BFC0-0x0000000181C6C090
	// [XID] // 0x00000001899EC230-0x00000001899EC250
	public override void SetActive(bool isActive) {} // 0x0000000181C6C380-0x0000000181C6C450
	// [XID] // 0x00000001899F3CD0-0x00000001899F3CF0
	public override void UnLoad(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000181C6C170-0x0000000181C6C270
}

