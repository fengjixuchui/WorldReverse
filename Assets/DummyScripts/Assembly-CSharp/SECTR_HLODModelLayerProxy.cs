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
public class SECTR_HLODModelLayerProxy : SECTR_StaticModelLayerProxy, IAutoAllocRecycleJobThread, ISECTR_LODLoader, ISECTR_ThreadCB // TypeDefIndex: 20257
{
	// Fields
	[InspectorCollapsedFoldout] // 0x0000000189B32380-0x0000000189B323C0
	[InspectorCollectionShowItemDropdown] // 0x0000000189B32380-0x0000000189B323C0
	[ShowInInspector] // 0x0000000189B32380-0x0000000189B323C0
	private SECTR_LinkedListNode<ISECTR_LODLoader> _curNode; // 0x108
	public int curLOD; // 0x110
	public static float unloadRegion; // 0x00
	public float curDistance; // 0x114
	public float distanceToChange; // 0x118
	public float curDistanceToChange; // 0x11C
	[InspectorCollapsedFoldout] // 0x00000001896D0840-0x00000001896D0880
	[InspectorCollectionShowItemDropdown] // 0x00000001896D0840-0x00000001896D0880
	[ShowInInspector] // 0x00000001896D0840-0x00000001896D0880
	protected GameObject loadObject; // 0x120
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected ulong gameObjectPathHash; // 0x128
	[InspectorCollapsedFoldout] // 0x000000018979CFE0-0x000000018979D020
	[InspectorCollectionShowItemDropdown] // 0x000000018979CFE0-0x000000018979D020
	[ShowInInspector] // 0x000000018979CFE0-0x000000018979D020
	protected SECTR_GUID obj_guid; // 0x130
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected Vector3 boundsOffset; // 0x138
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected Transform _cachedTransform; // 0x148
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected Vector3 _cachedTransformPos; // 0x150
	public bool initialized; // 0x15C
	private SECTR_Manager.LoadGameObjectCallBack _loadHlodCallback; // 0x160
	public HLODState curHlodState; // 0x168

	// Nested types
	public enum HLODState // TypeDefIndex: 20258
	{
		Preload = 0,
		Loading = 1,
		Loaded = 2,
		Unloaded = 3
	}

	// Constructors
	public SECTR_HLODModelLayerProxy() {} // 0x0000000184A88230-0x0000000184A882D0
	static SECTR_HLODModelLayerProxy() {} // 0x0000000184A881D0-0x0000000184A88230

	// Methods
	[BlackList] // 0x00000001895E5EB0-0x00000001895E5EF0
	// [XID] // 0x00000001895E5EB0-0x00000001895E5EF0
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000184A85AA0-0x0000000184A85B50
	[BlackList] // 0x00000001895F0680-0x00000001895F06C0
	// [XID] // 0x00000001895F0680-0x00000001895F06C0
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000184A85B50-0x0000000184A85C90
	[BlackList] // 0x00000001895FAE30-0x00000001895FAE70
	// [XID] // 0x00000001895FAE30-0x00000001895FAE70
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000184A88120-0x0000000184A881D0
	// [XID] // 0x00000001896053F0-0x0000000189605410
	public override void OnPoolAllocated(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000184A87EB0-0x0000000184A87FB0
	// [XID] // 0x000000018960CE00-0x000000018960CE20
	public override void OnBeforePoolRecycled(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000184A87E00-0x0000000184A87EB0
	// [XID] // 0x0000000189614390-0x00000001896143B0
	public override void Init(SECTR_StreamLayer layerInfo, Transform trans, ISECTR_BaseProxy groupProxy) {} // 0x0000000184A86190-0x0000000184A86290
	// [XID] // 0x000000018961BDF0-0x000000018961BE10
	public override void Release() {} // 0x0000000184A86E60-0x0000000184A86FA0
	// [XID] // 0x0000000189623360-0x0000000189623380
	protected void InitLODControl() {} // 0x0000000184A87BC0-0x0000000184A87E00
	// [XID] // 0x000000018962ABA0-0x000000018962ABC0
	public void RefreshLODPattern() {} // 0x0000000184A86990-0x0000000184A86A30
	// [XID] // 0x00000001896322E0-0x0000000189632300
	protected void RemoveLODControl() {} // 0x0000000184A86290-0x0000000184A86440
	// [XID] // 0x0000000189639DD0-0x0000000189639DF0
	public float GetDistanceToCamera(Vector3 pos, SECTR_ThreadContext context) => default; // 0x0000000184A86FA0-0x0000000184A87170
	// [XID] // 0x00000001896412A0-0x00000001896412C0
	public void SelectLOD(Vector3 pos, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000184A85F30-0x0000000184A86190
	// [XID] // 0x0000000189648C20-0x0000000189648C40
	public void ForceActiveLOD(int lod, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000184A85C90-0x0000000184A85D80
	// [XID] // 0x0000000189650280-0x00000001896502A0
	private void LoadLodDetail(int lod, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000184A87170-0x0000000184A872E0
	// [XID] // 0x0000000189657B90-0x0000000189657BB0
	public void OnUnityThreadCallBack() {} // 0x0000000184A85E00-0x0000000184A85EC0
	// [XID] // 0x000000018965F2A0-0x000000018965F2C0
	protected void ShowLOD(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000184A86AE0-0x0000000184A86CA0
	// [XID] // 0x0000000189666AB0-0x0000000189666AD0
	private void ShowLayerLoader(bool active, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000184A86D20-0x0000000184A86E60
	// [XID] // 0x000000018966E150-0x000000018966E170
	public override void SetActive(bool active, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000184A87AD0-0x0000000184A87BC0
	// [XID] // 0x0000000189675FA0-0x0000000189675FC0
	protected override bool IsLoaderActive() => default; // 0x0000000184A86A30-0x0000000184A86AE0
	// [XID] // 0x000000018967D880-0x000000018967D8A0
	protected void LoadObject(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000184A86710-0x0000000184A86990
	// [XID] // 0x0000000189684E80-0x0000000189684EA0
	private void DestroyHLODObject(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000184A86560-0x0000000184A86710
	// [XID] // 0x000000018968C9A0-0x000000018968C9C0
	protected void UnloadObject(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000184A88030-0x0000000184A88120
	// [XID] // 0x00000001896944D0-0x00000001896944F0
	protected void SetObjectActive(bool enable) {} // 0x0000000184A877F0-0x0000000184A87A70
	// [XID] // 0x000000018969BA90-0x000000018969BAB0
	public override void ClearLayer() {} // 0x0000000184A859A0-0x0000000184A85AA0
	// [XID] // 0x00000001896A3140-0x00000001896A3160
	protected void LoadHlodCB(SECTR_GUID guid, GameObject obj) {} // 0x0000000184A87340-0x0000000184A87770
	// [XID] // 0x00000001896AA570-0x00000001896AA590
	private void ComputeHLODCount(bool enable) {} // 0x0000000184A85800-0x0000000184A85910
}

