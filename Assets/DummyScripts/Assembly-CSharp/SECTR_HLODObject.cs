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

[fiInspectorOnly] // 0x00000001896865F0-0x0000000189686630
[RecycleType] // 0x00000001896865F0-0x0000000189686630
public sealed class SECTR_HLODObject : SECTR_BaseObject, IAutoAllocRecycleJobThread, ISECTR_LODLoader, ISECTR_ThreadCB // TypeDefIndex: 20259
{
	// Fields
	private static List<int> HLodCheckList; // 0x00
	public int curHLod; // 0x68
	public int loadingHLod; // 0x6C
	public int curLoadedObjCount; // 0x70
	public const int Default_LOD = 0; // Metadata: 0x00AFD4B7
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	private List<HLODRecord> recordStateList; // 0x78
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private HLODState _state; // 0x80
	[InspectorCollapsedFoldout] // 0x00000001896D0840-0x00000001896D0880
	[InspectorCollectionShowItemDropdown] // 0x00000001896D0840-0x00000001896D0880
	[ShowInInspector] // 0x00000001896D0840-0x00000001896D0880
	public SECTR_HLODFinInfo hlodInfo; // 0x88
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	private SECTR_LODQualityInfo quality; // 0x90
	[InspectorCollapsedFoldout] // 0x000000018979CFE0-0x000000018979D020
	[InspectorCollectionShowItemDropdown] // 0x000000018979CFE0-0x000000018979D020
	[ShowInInspector] // 0x000000018979CFE0-0x000000018979D020
	private SECTR_LODPattern pattern; // 0x98
	[InspectorCollapsedFoldout] // 0x000000018976B560-0x000000018976B5A0
	[InspectorCollectionShowItemDropdown] // 0x000000018976B560-0x000000018976B5A0
	[ShowInInspector] // 0x000000018976B560-0x000000018976B5A0
	private SECTR_LinkedListNode<ISECTR_LODLoader> _hlodNode; // 0xA0
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private AssetJobPriority _priority; // 0xA8
	// [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
	private SECTR_Manager.LoadGameObjectCallBack _hlodLoadCB; // 0xB0
	[InspectorCollapsedFoldout] // 0x00000001896D0840-0x00000001896D0880
	[InspectorCollectionShowItemDropdown] // 0x00000001896D0840-0x00000001896D0880
	[ShowInInspector] // 0x00000001896D0840-0x00000001896D0880
	private List<SECTR_GUID> lodGuid0; // 0xB8
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	private List<SECTR_GUID> lodGuid1; // 0xC0
	[InspectorCollapsedFoldout] // 0x0000000189B32380-0x0000000189B323C0
	[InspectorCollectionShowItemDropdown] // 0x0000000189B32380-0x0000000189B323C0
	[ShowInInspector] // 0x0000000189B32380-0x0000000189B323C0
	private List<SECTR_GUID> lodGuid2; // 0xC8
	[InspectorCollapsedFoldout] // 0x0000000189B4ED50-0x0000000189B4ED90
	[InspectorCollectionShowItemDropdown] // 0x0000000189B4ED50-0x0000000189B4ED90
	[ShowInInspector] // 0x0000000189B4ED50-0x0000000189B4ED90
	private List<SECTR_GUID> lodGuid3; // 0xD0

	// Properties
	private HLODState state { /* [XID] */ /* 0x0000000189769DB0-0x0000000189769DD0 */ get => default; /* [XID] */ /* 0x00000001897713A0-0x00000001897713C0 */ set {} } // 0x00000001842D9830-0x00000001842D98D0 0x00000001842D84B0-0x00000001842D85F0

	// Nested types
	public enum HLODState // TypeDefIndex: 20260
	{
		Unload = 0,
		Unloading = 1,
		Init = 2,
		Loading = 3,
		Loaded = 4
	}

	public struct HLODRecord // TypeDefIndex: 20261
	{
		// Fields
		public HLODState state; // 0x00
		public int curHLod; // 0x04
		public int loadingHLod; // 0x08
		public int curLoadedObjCount; // 0x0C
	}

	// Constructors
	public SECTR_HLODObject() {} // 0x00000001842DBD40-0x00000001842DBE20
	static SECTR_HLODObject() {} // 0x00000001842DBC60-0x00000001842DBD40

	// Methods
	[BlackList] // 0x000000018974AE00-0x000000018974AE40
	// [XID] // 0x000000018974AE00-0x000000018974AE40
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001842D8760-0x00000001842D8810
	[BlackList] // 0x0000000189755200-0x0000000189755240
	// [XID] // 0x0000000189755200-0x0000000189755240
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001842D8810-0x00000001842D8920
	[BlackList] // 0x000000018975F7F0-0x000000018975F830
	// [XID] // 0x000000018975F7F0-0x000000018975F830
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001842DBBB0-0x00000001842DBC60
	// [XID] // 0x0000000189778C00-0x0000000189778C20
	private void AddHLODGUID(int lod, SECTR_GUID guid) {} // 0x00000001842D9C80-0x00000001842D9DB0
	// [XID] // 0x00000001897801C0-0x00000001897801E0
	private List<SECTR_GUID> GetHLODGUID(int lod) => default; // 0x00000001842D9B90-0x00000001842D9C80
	// [XID] // 0x0000000189787AC0-0x0000000189787AE0
	private bool ContainHLODGUID(int lod) => default; // 0x00000001842DB6D0-0x00000001842DB7F0
	// [XID] // 0x000000018978F0A0-0x000000018978F0C0
	private void HLODGUIDClear(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842DB040-0x00000001842DB3A0
	// [XID] // 0x00000001897968D0-0x00000001897968F0
	public override void OnPoolAllocated(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001842DB9E0-0x00000001842DBB30
	// [XID] // 0x000000018979E9F0-0x000000018979EA10
	public override void OnBeforePoolRecycled(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001842DB7F0-0x00000001842DB9E0
	// [XID] // 0x00000001897A6100-0x00000001897A6120
	public uint GetGroupId() => default; // 0x00000001842D9610-0x00000001842D96B0
	// [XID] // 0x00000001897AD5B0-0x00000001897AD5D0
	public override void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842D8FD0-0x00000001842D9610
	// [XID] // 0x00000001897B5690-0x00000001897B56B0
	private void RegisterLODLoader() {} // 0x00000001842D9F80-0x00000001842DA070
	// [XID] // 0x00000001897BD2D0-0x00000001897BD2F0
	private void UnregisterLODLoader() {} // 0x00000001842DA400-0x00000001842DA540
	// [XID] // 0x00000001897C4600-0x00000001897C4620
	public void RefreshLODPattern() {} // 0x00000001842DA230-0x00000001842DA400
	// [XID] // 0x00000001897CBE10-0x00000001897CBE30
	public override void UnLoad(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842DAEB0-0x00000001842DAFC0
	// [XID] // 0x00000001897D3840-0x00000001897D3860
	public void LoadObj(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842DABF0-0x00000001842DAD10
	// [XID] // 0x00000001897DB2D0-0x00000001897DB2F0
	public void UnLoadObj(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842DAD10-0x00000001842DAEB0
	// [XID] // 0x00000001897E29A0-0x00000001897E29C0
	public void OnUnityThreadCallBack() {} // 0x00000001842D9730-0x00000001842D9830
	// [XID] // 0x00000001897EA100-0x00000001897EA120
	public void RealUnLoadObj(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842D85F0-0x00000001842D8760
	// [XID] // 0x00000001897F1D70-0x00000001897F1D90
	public override void SetActive(bool isActive) {} // 0x00000001842DB5A0-0x00000001842DB6D0
	// [XID] // 0x00000001897F9630-0x00000001897F9650
	public void SelectLOD(Vector3 pos, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842D98D0-0x00000001842D9B10
	// [XID] // 0x0000000189800B50-0x0000000189800B70
	public float GetDistanceToCamera(Vector3 pos, SECTR_ThreadContext context) => default; // 0x00000001842DA930-0x00000001842DAB10
	// [XID] // 0x00000001898080E0-0x0000000189808100
	private int GetBestLod(Vector3 pos, SECTR_ThreadContext context, bool bFromUnityThread) => default; // 0x00000001842D8B00-0x00000001842D8FD0
	// [XID] // 0x000000018980FAF0-0x000000018980FB10
	private void ActivateHLOD(int lod, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842D9DB0-0x00000001842D9F80
	// [XID] // 0x00000001898170C0-0x00000001898170E0
	private void ResetCurHLOD(int setActiveLod, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842DB430-0x00000001842DB5A0
	// [XID] // 0x000000018981E9D0-0x000000018981E9F0
	private void LoadHlodObjectCB(SECTR_GUID guid, GameObject obj) {} // 0x00000001842DA5C0-0x00000001842DA930
	// [XID] // 0x0000000189825EA0-0x0000000189825EC0
	public void ForceActiveLOD(int bestLOD, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001842D8920-0x00000001842D8B00
	// [XID] // 0x000000018982D560-0x000000018982D580
	private int GetMinLOD() => default; // 0x00000001842DA0F0-0x00000001842DA230
	// [XID] // 0x0000000189834CB0-0x0000000189834CD0
	private void ComputeHLODCount(bool enable) {} // 0x00000001842D83A0-0x00000001842D84B0
}

