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

[RecycleType] // 0x0000000189ADEFB0-0x0000000189ADEFD0
public class SECTR_LayerLoaderProxy : IAutoAllocRecycleJobThread, ISECTR_SetActive, ISECTR_LayerLoader // TypeDefIndex: 20264
{
	// Fields
	public SECTR_DebugSubLayerLoaderProxy debugMono; // 0x10
	public string festivalName; // 0x18
	public SECTR_PlatformType platType; // 0x20
	public int initObjNum; // 0x24
	public State state; // 0x28
	public ActiveState activeState; // 0x2C
	public SECTR_BaseLayerProxy layerProxy; // 0x30
	public bool isActive; // 0x38
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private int _curActiveIndex; // 0x3C
	private Transform _cachedTransform; // 0x40
	private SECTR_LayerLoader _layerLoaderInfo; // 0x48
	[InspectorCollapsedFoldout] // 0x0000000189B32380-0x0000000189B323C0
	[InspectorCollectionShowItemDropdown] // 0x0000000189B32380-0x0000000189B323C0
	[ShowInInspector] // 0x0000000189B32380-0x0000000189B323C0
	private List<SECTR_BaseObject> virtualObjectLoaders; // 0x50

	// Properties
	[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
	public SECTR_StreamObject[] virtualObjects { /* [XID] */ /* 0x0000000189983170-0x0000000189983190 */ get => default; } // 0x000000018495FF80-0x0000000184960030 

	// Nested types
	public enum State // TypeDefIndex: 20265
	{
		None = 0,
		Loading = 1,
		Loaded = 2,
		Unloading = 3
	}

	public enum ActiveState // TypeDefIndex: 20266
	{
		Active = 0,
		Activing = 1
	}

	public enum ObjectInfoType // TypeDefIndex: 20267
	{
		None = 0,
		Terrain = 1,
		LOD = 2,
		VO = 3,
		Other = 4
	}

	// Constructors
	public SECTR_LayerLoaderProxy() {} // 0x0000000184960430-0x00000001849604B0

	// Methods
	[BlackList] // 0x0000000189963840-0x0000000189963880
	// [XID] // 0x0000000189963840-0x0000000189963880
	public virtual void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018495DB00-0x000000018495DBB0
	[BlackList] // 0x000000018996DAD0-0x000000018996DB10
	// [XID] // 0x000000018996DAD0-0x000000018996DB10
	public virtual void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018495DBB0-0x000000018495DC80
	[BlackList] // 0x0000000189978B70-0x0000000189978BB0
	// [XID] // 0x0000000189978B70-0x0000000189978BB0
	public virtual void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000184960380-0x0000000184960430
	// [XID] // 0x000000018998A920-0x000000018998A940
	public virtual void OnPoolAllocated(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018495FEB0-0x000000018495FF80
	// [XID] // 0x00000001899921C0-0x00000001899921E0
	public virtual void OnBeforePoolRecycled(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018495FDC0-0x000000018495FEB0
	// [XID] // 0x000000018999A010-0x000000018999A030
	public void Init(SECTR_LayerLoader layerLoaderInfo, Transform trans) {} // 0x000000018495EF30-0x000000018495F0C0
	// [XID] // 0x00000001899A1610-0x00000001899A1630
	public void SharedUpdate(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495F1B0-0x000000018495F2B0
	// [XID] // 0x00000001899A9000-0x00000001899A9020
	public void Release() {} // 0x000000018495F6C0-0x000000018495F910
	// [XID] // 0x00000001899B0A70-0x00000001899B0A90
	private void DestroyObjects() {} // 0x0000000184960030-0x0000000184960380
	// [XID] // 0x00000001899B7D90-0x00000001899B7DB0
	private bool ActiveUpdateWithUnloadLayer(SliceFrameWatch activeSW) => default; // 0x000000018495E9B0-0x000000018495EC90
	// [XID] // 0x00000001899BF810-0x00000001899BF830
	private bool ActiveUpdateWithoutUnloadLayer(SliceFrameWatch activeSW) => default; // 0x000000018495F2B0-0x000000018495F470
	// [XID] // 0x00000001899C7170-0x00000001899C7190
	public bool ActiveUpdate(SliceFrameWatch activeSW) => default; // 0x000000018495FCC0-0x000000018495FDC0
	// [XID] // 0x00000001899CE690-0x00000001899CE6B0
	private void SetActiveWithUnloadObject(bool active, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495E1A0-0x000000018495E400
	// [XID] // 0x00000001899D5D70-0x00000001899D5D90
	private void SetActiveWithoutUnloadObject(bool active, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495E400-0x000000018495E670
	// [XID] // 0x00000001899DD1E0-0x00000001899DD200
	public void SetActive(bool active, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495FB90-0x000000018495FCC0
	// [XID] // 0x00000001899E4DC0-0x00000001899E4DE0
	public void InitVirtualObjects(SECTR_BaseLayerProxy layer) {} // 0x000000018495F0C0-0x000000018495F1B0
	// [XID] // 0x00000001899EC250-0x00000001899EC270
	public void LoadVirtualObjects(bool active, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495F910-0x000000018495FB90
	// [XID] // 0x00000001899F3CF0-0x00000001899F3D10
	private void LoadingVirtualObjects(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495E670-0x000000018495E810
	// [XID] // 0x00000001899FB570-0x00000001899FB590
	private void LoadVirtualObjectAt(int i, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495DC80-0x000000018495E1A0
	// [XID] // 0x0000000189A027D0-0x0000000189A027F0
	private void UnloadVirtualObjectAt(int i, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495EC90-0x000000018495EDC0
	// [XID] // 0x0000000189A09F60-0x0000000189A09F80
	private void UnloadingVirtualObjects(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495D990-0x000000018495DB00
	// [XID] // 0x0000000189A117C0-0x0000000189A117E0
	public void UnloadVirtualObjects(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495F470-0x000000018495F6C0
	// [XID] // 0x0000000189A18AF0-0x0000000189A18B10
	private void OnUnloaded(bool fromParent, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018495E810-0x000000018495E9B0
	// [XID] // 0x0000000189A201D0-0x0000000189A201F0
	protected void CheckComputeCount(bool enable) {} // 0x000000018495EDC0-0x000000018495EF30
}

