/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public sealed class SECTR_LODObject : SECTR_ColliderObject, IAutoAllocRecycleJobThread, ISECTR_LODLoader // TypeDefIndex: 20271
{
	// Fields
	private const float FADE_OUT_DURATION = 1500f; // Metadata: 0x00AFD506
	private static List<int> LodCheckList; // 0x00
	public int curLod; // 0x88
	public int loadingLod; // 0x8C
	[InspectorCollapsedFoldout] // 0x0000000189B4ED50-0x0000000189B4ED90
	[InspectorCollectionShowItemDropdown] // 0x0000000189B4ED50-0x0000000189B4ED90
	[ShowInInspector] // 0x0000000189B4ED50-0x0000000189B4ED90
	private List<LODRecord> recordStateList; // 0x90
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private LODState _state; // 0x98
	[InspectorCollapsedFoldout] // 0x000000018979CFE0-0x000000018979D020
	[InspectorCollectionShowItemDropdown] // 0x000000018979CFE0-0x000000018979D020
	[ShowInInspector] // 0x000000018979CFE0-0x000000018979D020
	public SECTR_LODFinInfo lodInfo; // 0xA0
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	private SECTR_LODQualityInfo quality; // 0xA8
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	private SECTR_LODPattern pattern; // 0xB0
	[InspectorCollapsedFoldout] // 0x00000001896D0840-0x00000001896D0880
	[InspectorCollectionShowItemDropdown] // 0x00000001896D0840-0x00000001896D0880
	[ShowInInspector] // 0x00000001896D0840-0x00000001896D0880
	private SECTR_LinkedListNode<ISECTR_LODLoader> _lodNode; // 0xB8
	private AssetJobPriority _priority; // 0xC0
	[InspectorCollapsedFoldout] // 0x0000000189B32380-0x0000000189B323C0
	[InspectorCollectionShowItemDropdown] // 0x0000000189B32380-0x0000000189B323C0
	[ShowInInspector] // 0x0000000189B32380-0x0000000189B323C0
	private GameObject _lodObject; // 0xC8
	[InspectorCollapsedFoldout] // 0x000000018976B560-0x000000018976B5A0
	[InspectorCollectionShowItemDropdown] // 0x000000018976B560-0x000000018976B5A0
	[ShowInInspector] // 0x000000018976B560-0x000000018976B5A0
	private int _beginLODIndex; // 0xD0
	private int _cacheLOD; // 0xD4
	private ulong _lastCacheTime; // 0xD8
	// [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
	private SECTR_Manager.LoadGameObjectCallBack _lodLoadCB; // 0xE0
	[InspectorCollapsedFoldout] // 0x0000000189B32380-0x0000000189B323C0
	[InspectorCollectionShowItemDropdown] // 0x0000000189B32380-0x0000000189B323C0
	[ShowInInspector] // 0x0000000189B32380-0x0000000189B323C0
	private SECTR_GUID lodGuid9; // 0xE8
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	private SECTR_GUID lodGuid0; // 0xF0
	[InspectorCollapsedFoldout] // 0x00000001896D0840-0x00000001896D0880
	[InspectorCollectionShowItemDropdown] // 0x00000001896D0840-0x00000001896D0880
	[ShowInInspector] // 0x00000001896D0840-0x00000001896D0880
	private SECTR_GUID lodGuid1; // 0xF8
	[InspectorCollapsedFoldout] // 0x0000000189B4ED50-0x0000000189B4ED90
	[InspectorCollectionShowItemDropdown] // 0x0000000189B4ED50-0x0000000189B4ED90
	[ShowInInspector] // 0x0000000189B4ED50-0x0000000189B4ED90
	private SECTR_GUID lodGuid2; // 0x100
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	private SECTR_GUID lodGuid3; // 0x108
	public static bool SHOW_MODEL_LOD; // 0x08
	private static MaterialPropertyBlock _mpb; // 0x10
	private static int _lodPropID; // 0x18
	private static Renderer[] _renderers; // 0x20

	// Properties
	public LODState state { /* [XID] */ /* 0x00000001895F3550-0x00000001895F3570 */ get => default; /* [XID] */ /* 0x00000001895FAE10-0x00000001895FAE30 */ set {} } // 0x0000000183128FC0-0x0000000183129060 0x0000000183127FC0-0x0000000183128100

	// Nested types
	public enum LODState // TypeDefIndex: 20272
	{
		Unload = 0,
		Init = 1,
		Loading = 2,
		Loaded = 3
	}

	public struct LODRecord // TypeDefIndex: 20273
	{
		// Fields
		public LODState state; // 0x00
		public int curLod; // 0x04
		public int loadingLod; // 0x08
	}

	// Constructors
	public SECTR_LODObject() {} // 0x000000018312C980-0x000000018312CA60
	static SECTR_LODObject() {} // 0x000000018312C840-0x000000018312C980

	// Methods
	[BlackList] // 0x0000000189BCEE20-0x0000000189BCEE60
	// [XID] // 0x0000000189BCEE20-0x0000000189BCEE60
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000183128100-0x00000001831281B0
	[BlackList] // 0x0000000189BD92F0-0x0000000189BD9330
	// [XID] // 0x0000000189BD92F0-0x0000000189BD9330
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001831281B0-0x00000001831282F0
	[BlackList] // 0x00000001895E8E30-0x00000001895E8E70
	// [XID] // 0x00000001895E8E30-0x00000001895E8E70
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018312C790-0x000000018312C840
	// [XID] // 0x00000001896026A0-0x00000001896026C0
	private void SetLODGUID(int lod, SECTR_GUID guid) {} // 0x0000000183129F80-0x000000018312A0B0
	// [XID] // 0x0000000189609F70-0x0000000189609F90
	private SECTR_GUID GetLODGUID(int lod) => default; // 0x000000018312C4F0-0x000000018312C610
	// [XID] // 0x0000000189611800-0x0000000189611820
	private bool ContainLODGUID(int lod) => default; // 0x000000018312B250-0x000000018312B380
	// [XID] // 0x00000001896190C0-0x00000001896190E0
	private void LODGUIDClear(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000183127BF0-0x0000000183127D80
	// [XID] // 0x00000001896205E0-0x0000000189620600
	public override void OnPoolAllocated(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018312C370-0x000000018312C470
	// [XID] // 0x0000000189627A70-0x0000000189627A90
	public override void OnBeforePoolRecycled(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018312C270-0x000000018312C370
	// [XID] // 0x000000018962F450-0x000000018962F470
	public override void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831289E0-0x0000000183128E40
	// [XID] // 0x0000000189636F00-0x0000000189636F20
	private int GetBeginLODIndex() => default; // 0x000000018312B000-0x000000018312B170
	// [XID] // 0x000000018963E460-0x000000018963E480
	public void RefreshLODPattern() {} // 0x000000018312A680-0x000000018312A840
	// [XID] // 0x0000000189645C60-0x0000000189645C80
	public override void UnLoad(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018312B790-0x000000018312B8D0
	// [XID] // 0x000000018964D540-0x000000018964D560
	protected override ulong GetColliderPath() => default; // 0x000000018312B6A0-0x000000018312B790
	// [XID] // 0x0000000189654DE0-0x0000000189654E00
	private void RegisterLODLoader() {} // 0x0000000183129E10-0x0000000183129F00
	// [XID] // 0x000000018965C370-0x000000018965C390
	private void UnregisterLODLoader() {} // 0x000000018312A9E0-0x000000018312AB20
	// [XID] // 0x0000000189663AE0-0x0000000189663B00
	public override void SetActive(bool isActive) {} // 0x000000018312BEB0-0x000000018312BFA0
	// [XID] // 0x000000018966B320-0x000000018966B340
	public void SelectLOD(Vector3 pos, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831290F0-0x0000000183129360
	// [XID] // 0x0000000189673040-0x0000000189673060
	public float GetDistanceToCamera(Vector3 pos, SECTR_ThreadContext tool) => default; // 0x000000018312ADD0-0x000000018312B000
	// [XID] // 0x000000018967A690-0x000000018967A6B0
	private int GetBestLod(Vector3 pos, SECTR_ThreadContext tool, bool bFromUnityThread) => default; // 0x00000001831284D0-0x00000001831289E0
	// [XID] // 0x0000000189681F70-0x0000000189681F90
	private void ActivateLOD(int lod, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018312A840-0x000000018312A9E0
	// [XID] // 0x00000001896899A0-0x00000001896899C0
	private bool NeedCheckCache() => default; // 0x0000000183128EC0-0x0000000183128FC0
	// [XID] // 0x0000000189691700-0x0000000189691720
	private void ClearCache(int curLod, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018312A3E0-0x000000018312A530
	// [XID] // 0x0000000189698D30-0x0000000189698D50
	private void ResetCurLOD(int setActiveLod, GameObject obj, bool fadeOut, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018312ABA0-0x000000018312ADD0
	// [XID] // 0x00000001896A01D0-0x00000001896A01F0
	private void LoadLodObjectCB(SECTR_GUID guid, GameObject obj) {} // 0x00000001831295F0-0x0000000183129CB0
	// [XID] // 0x00000001896A7560-0x00000001896A7580
	protected override void PostInitObjLoad(SECTR_ScenePropInfo info, GameObject obj) {} // 0x0000000183129CB0-0x0000000183129E10
	// [XID] // 0x00000001896AEA60-0x00000001896AEA80
	public override void SetObjectPos(Vector3 pos, bool force = false /* Metadata: 0x00AFD505 */) {} // 0x000000018312B380-0x000000018312B630
	// [XID] // 0x00000001896B6260-0x00000001896B6280
	public override string ReportLog() => default; // 0x000000018312C610-0x000000018312C790
	// [XID] // 0x00000001896BD480-0x00000001896BD4A0
	private int GetMinLOD() => default; // 0x000000018312A530-0x000000018312A680
	// [XID] // 0x00000001896C4AC0-0x00000001896C4AE0
	private LODType ClampLOD(LODType type) => default; // 0x000000018312A0B0-0x000000018312A280
	// [XID] // 0x00000001896CBF90-0x00000001896CBFB0
	public void ForceActiveLOD(int bestLOD, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831282F0-0x00000001831284D0
	// [XID] // 0x00000001896D32A0-0x00000001896D32C0
	public void ClearBeforeSave() {} // 0x000000018312A280-0x000000018312A3E0
	// [XID] // 0x00000001896DAE20-0x00000001896DAE40
	private void ComputeLODCount(int lod, bool addCount) {} // 0x000000018312BFA0-0x000000018312C270
	// [XID] // 0x00000001896E2620-0x00000001896E2640
	public static void ForceSetLODLevelInfo() {} // 0x0000000183129360-0x0000000183129570
	// [XID] // 0x00000001896E9B00-0x00000001896E9B20
	public static void ForceSetLOD(int level) {} // 0x0000000183127D80-0x0000000183127FC0
	// [XID] // 0x00000001896F0D00-0x00000001896F0D20
	public void SetLODLevelInfo() {} // 0x000000018312BA80-0x000000018312BEB0
}

