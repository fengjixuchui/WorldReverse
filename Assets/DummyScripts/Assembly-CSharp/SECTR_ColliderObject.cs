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

[RecycleType] // 0x0000000189ADEFB0-0x0000000189ADEFD0
public abstract class SECTR_ColliderObject : SECTR_BaseObject, IAutoAllocRecycleJobThread, ISECTR_ColliderLoader // TypeDefIndex: 20247
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private ColliderState _colliderState; // 0x68
	[InspectorCollapsedFoldout] // 0x00000001896D0840-0x00000001896D0880
	[InspectorCollectionShowItemDropdown] // 0x00000001896D0840-0x00000001896D0880
	[ShowInInspector] // 0x00000001896D0840-0x00000001896D0880
	private SECTR_GUID _colliderGuid; // 0x70
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	private SECTR_LinkedListNode<ISECTR_ColliderLoader> _colliderNode; // 0x78
	// [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
	private SECTR_Manager.LoadGameObjectCallBack _colliderLoadCB; // 0x80

	// Properties
	public ColliderState colliderState { /* [XID] */ /* 0x0000000189909960-0x0000000189909980 */ get; } // 0x0000000181550190-0x0000000181550230 

	// Nested types
	public enum ColliderState // TypeDefIndex: 20248
	{
		Unload = 0,
		Init = 1,
		Loading = 2,
		Loaded = 3
	}

	// Constructors
	public SECTR_ColliderObject() {} // 0x0000000181550BF0-0x0000000181550CA0

	// Methods
	[BlackList] // 0x00000001898EA2F0-0x00000001898EA330
	// [XID] // 0x00000001898EA2F0-0x00000001898EA330
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018154F460-0x000000018154F510
	[BlackList] // 0x00000001898F4860-0x00000001898F48A0
	// [XID] // 0x00000001898F4860-0x00000001898F48A0
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018154F510-0x000000018154F5D0
	[BlackList] // 0x00000001898FF110-0x00000001898FF150
	// [XID] // 0x00000001898FF110-0x00000001898FF150
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000181550B40-0x0000000181550BF0
	protected abstract ulong GetColliderPath();
	// [XID] // 0x0000000189910FF0-0x0000000189911010
	public uint GetGroupId() => default; // 0x000000018154F7A0-0x000000018154F840
	// [XID] // 0x0000000189918B70-0x0000000189918B90
	public override void OnPoolAllocated(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000181550970-0x0000000181550A30
	// [XID] // 0x00000001899202B0-0x00000001899202D0
	public override void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018154F5D0-0x000000018154F7A0
	// [XID] // 0x0000000189927B10-0x0000000189927B30
	public override void UnLoad(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000181550510-0x0000000181550630
	// [XID] // 0x000000018992F320-0x000000018992F340
	protected void LoadColliderObjectCB(SECTR_GUID guid, GameObject obj) {} // 0x000000018154FDB0-0x00000001815500A0
	// [XID] // 0x00000001899366B0-0x00000001899366D0
	public void RefreshCollider(Vector3 pos, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000181550740-0x0000000181550970
	// [XID] // 0x000000018993E1B0-0x000000018993E1D0
	private bool IsUnderLimitControl(float distanceToCamera) => default; // 0x000000018154F9F0-0x000000018154FB40
	// [XID] // 0x0000000189945840-0x0000000189945860
	private void CheckLodCollider(float distanceToCamera, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018154FB40-0x000000018154FD30
	// [XID] // 0x000000018994CC90-0x000000018994CCB0
	private void RegisterColliderLoader() {} // 0x00000001815500A0-0x0000000181550190
	// [XID] // 0x00000001899544A0-0x00000001899544C0
	private void UnregisterColliderLoader() {} // 0x000000018154F8C0-0x000000018154F9F0
	// [XID] // 0x000000018995BD40-0x000000018995BD60
	public override string ReportLog() => default; // 0x0000000181550A30-0x0000000181550B40
	// [XID] // 0x0000000189963880-0x00000001899638A0
	private void ComputeColliderCount(bool addCount) {} // 0x0000000181550390-0x00000001815504A0
}

