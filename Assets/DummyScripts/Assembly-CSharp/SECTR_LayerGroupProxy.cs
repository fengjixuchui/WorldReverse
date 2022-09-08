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

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class SECTR_LayerGroupProxy : IAutoAllocRecycle, ISECTR_BaseGroup // TypeDefIndex: 20262
{
	// Fields
	public SECTR_DebugLayerGroupProxy debugMono; // 0x10
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private GroupState _state; // 0x18
	[InspectorCollapsedFoldout] // 0x000000018984AEB0-0x000000018984AF10
	[InspectorCollectionShowItemDropdown] // 0x000000018984AEB0-0x000000018984AF10
	// [PooledField] // 0x000000018984AEB0-0x000000018984AF10
	[ShowInInspector] // 0x000000018984AEB0-0x000000018984AF10
	private List<SECTR_BaseLayerProxy> layerProxyList; // 0x20
	[InspectorCollapsedFoldout] // 0x0000000189A49A00-0x0000000189A49A60
	[InspectorCollectionShowItemDropdown] // 0x0000000189A49A00-0x0000000189A49A60
	// [PooledField] // 0x0000000189A49A00-0x0000000189A49A60
	[ShowInInspector] // 0x0000000189A49A00-0x0000000189A49A60
	private List<SECTR_BaseLayerProxy> persistenceLayerProxyList; // 0x28
	[InspectorCollapsedFoldout] // 0x000000018976B560-0x000000018976B5A0
	[InspectorCollectionShowItemDropdown] // 0x000000018976B560-0x000000018976B5A0
	[ShowInInspector] // 0x000000018976B560-0x000000018976B5A0
	public SECTR_LayerGroup groupInfo; // 0x30
	public bool debugMode; // 0x38
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public bool _isActive; // 0x39
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public int _curActiveIndex; // 0x3C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public int _initObjNum; // 0x40
	public Transform _cacheTransform; // 0x48
	private uint _runtimeID; // 0x50

	// Properties
	[InspectorCollapsedFoldout] // 0x0000000189BA6080-0x0000000189BA60B0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BA6080-0x0000000189BA60B0
	public SECTR_StreamLayer[] layerInfos { /* [XID] */ /* 0x00000001898ADB90-0x00000001898ADBB0 */ get => default; } // 0x0000000183A6D710-0x0000000183A6D7C0 

	// Nested types
	private enum GroupState // TypeDefIndex: 20263
	{
		Activing = 0,
		Active = 1
	}

	// Constructors
	public SECTR_LayerGroupProxy() {} // 0x0000000183A6F120-0x0000000183A6F1A0

	// Methods
	[BlackList] // 0x000000018988E720-0x000000018988E760
	// [XID] // 0x000000018988E720-0x000000018988E760
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A6D150-0x0000000183A6D230
	[BlackList] // 0x0000000189898F50-0x0000000189898F90
	// [XID] // 0x0000000189898F50-0x0000000189898F90
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A6D230-0x0000000183A6D320
	[BlackList] // 0x00000001898A3300-0x00000001898A3340
	// [XID] // 0x00000001898A3300-0x00000001898A3340
	public virtual void ReturnToObjectPool() {} // 0x0000000183A6F080-0x0000000183A6F120
	// [XID] // 0x00000001898B50A0-0x00000001898B50C0
	public uint GetRuntimeID() => default; // 0x0000000183A6EA30-0x0000000183A6EAD0
	// [XID] // 0x00000001898BCB90-0x00000001898BCBB0
	public virtual void OnPoolAllocated() {} // 0x0000000183A6EB70-0x0000000183A6EC10
	// [XID] // 0x00000001898C42E0-0x00000001898C4300
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A6EAD0-0x0000000183A6EB70
	// [XID] // 0x00000001898CB8D0-0x00000001898CB8F0
	public List<SECTR_BaseLayerProxy> GetProxyLayers() => default; // 0x0000000183A6D320-0x0000000183A6D430
	// [XID] // 0x00000001898D2FB0-0x00000001898D2FD0
	public void Init(SECTR_LayerGroup info, Transform trans, ISECTR_BaseProxy proxy) {} // 0x0000000183A6D9B0-0x0000000183A6DB60
	// [XID] // 0x00000001898DA960-0x00000001898DA980
	private bool IsPersisitenceLayer(SECTR_StreamLayer layer) => default; // 0x0000000183A6E910-0x0000000183A6EA30
	// [XID] // 0x00000001898E27C0-0x00000001898E27E0
	private bool IsLayerValid(SECTR_StreamLayer layer) => default; // 0x0000000183A6E180-0x0000000183A6E290
	// [XID] // 0x00000001898EA2D0-0x00000001898EA2F0
	private void InitNormalLayer(int i, SECTR_StreamLayer layer) {} // 0x0000000183A6DB60-0x0000000183A6DD70
	// [XID] // 0x00000001898F1AB0-0x00000001898F1AD0
	private void InitPersistenceLayer(SECTR_StreamLayer layer) {} // 0x0000000183A6DFD0-0x0000000183A6E180
	// [XID] // 0x00000001898F9210-0x00000001898F9230
	public void InitGroup(bool loadAll = true /* Metadata: 0x00AFD4CF */) {} // 0x0000000183A6E290-0x0000000183A6E440
	// [XID] // 0x0000000189900B90-0x0000000189900BB0
	public void ReleaseGroup() {} // 0x0000000183A6ED40-0x0000000183A6EFD0
	// [XID] // 0x0000000189908350-0x0000000189908370
	public void ResetGroup(SECTR_ThreadContext context, bool bFromUnityThread, bool loadAll = true /* Metadata: 0x00AFD4D0 */) {} // 0x0000000183A6D7C0-0x0000000183A6D9B0
	// [XID] // 0x000000018990FAD0-0x000000018990FAF0
	public void ClearGroup() {} // 0x0000000183A6EC10-0x0000000183A6ED40
	// [XID] // 0x0000000189917540-0x0000000189917560
	public void SetActive(bool active, SECTR_ThreadContext tool, bool bFromUnityThread) {} // 0x0000000183A6E440-0x0000000183A6E810
	// [XID] // 0x000000018991EBC0-0x000000018991EBE0
	public string ReportLog() => default; // 0x0000000183A6EFD0-0x0000000183A6F080
	// [XID] // 0x0000000189926460-0x0000000189926480
	private bool ActiveUpdateWithUnloadLayer(SliceFrameWatch activeSW) => default; // 0x0000000183A6D430-0x0000000183A6D710
	// [XID] // 0x000000018992DB10-0x000000018992DB30
	private bool ActiveUpdateWithoutUnloadLayer(SliceFrameWatch activeSW) => default; // 0x0000000183A6DD70-0x0000000183A6DFD0
	// [XID] // 0x0000000189934FB0-0x0000000189934FD0
	public bool ActiveUpdate(SliceFrameWatch activeSW) => default; // 0x0000000183A6E810-0x0000000183A6E910
}

