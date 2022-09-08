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
public class SECTR_BaseLayerProxy : IAutoAllocRecycleJobThread, ISECTR_BaseProxy // TypeDefIndex: 20239
{
	// Fields
	public SECTR_DebugLayerLoaderProxy debugMono; // 0x10
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private ChunkState loadState; // 0x18
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private int layerLoadCount; // 0x1C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private uint _runtimeID; // 0x20
	[InspectorCollapsedFoldout] // 0x000000018979CFE0-0x000000018979D020
	[InspectorCollectionShowItemDropdown] // 0x000000018979CFE0-0x000000018979D020
	[ShowInInspector] // 0x000000018979CFE0-0x000000018979D020
	protected SECTR_StreamLayer _layerInfo; // 0x28
	private SECTR_Manager.LoadByteArrayCallBack _loadByteArrayCallback; // 0x30
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float magitude; // 0x38
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public bool isActive; // 0x3C
	public Vector3 loadSize; // 0x40
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected float unloadBuffer; // 0x4C
	[InspectorCollapsedFoldout] // 0x0000000189B32380-0x0000000189B323C0
	[InspectorCollectionShowItemDropdown] // 0x0000000189B32380-0x0000000189B323C0
	[ShowInInspector] // 0x0000000189B32380-0x0000000189B323C0
	public List<SECTR_LayerLoaderProxy> layerLoaders; // 0x50
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private List<SECTR_GUID> layerLoaderGuids; // 0x58
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected bool hasReferenced; // 0x60
	private Transform _cachedTransform; // 0x68
	private Vector3 _cachedTransformPos; // 0x70
	public int indexWidth; // 0x7C
	public int indexHeight; // 0x80
	public int indexLongth; // 0x84
	public Bounds activeBounds; // 0x88
	public Bounds loadBounds; // 0xA0
	public Bounds unLoadBounds; // 0xB8
	public Bounds boundsOverride; // 0xD0
	public Vector3 realLoadSize; // 0xE8
	[InspectorCollapsedFoldout] // 0x0000000189B4ED50-0x0000000189B4ED90
	[InspectorCollectionShowItemDropdown] // 0x0000000189B4ED50-0x0000000189B4ED90
	[ShowInInspector] // 0x0000000189B4ED50-0x0000000189B4ED90
	public SECTR_LayerTree treeNode; // 0xF8
	public int treeLevel; // 0x100

	// Nested types
	public enum ChunkState // TypeDefIndex: 20240
	{
		Unloaded = 0,
		Loading = 1,
		Loaded = 2,
		Unloading = 3
	}

	// Constructors
	public SECTR_BaseLayerProxy() {} // 0x0000000182283CE0-0x0000000182283D70

	// Methods
	[BlackList] // 0x0000000189B5C6F0-0x0000000189B5C730
	// [XID] // 0x0000000189B5C6F0-0x0000000189B5C730
	public virtual void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018227FAE0-0x000000018227FB90
	[BlackList] // 0x0000000189B66EC0-0x0000000189B66F00
	// [XID] // 0x0000000189B66EC0-0x0000000189B66F00
	public virtual void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x000000018227FB90-0x000000018227FD50
	[BlackList] // 0x0000000189B713D0-0x0000000189B71410
	// [XID] // 0x0000000189B713D0-0x0000000189B71410
	public virtual void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000182283C30-0x0000000182283CE0
	// [XID] // 0x0000000189B7B770-0x0000000189B7B790
	public virtual void OnPoolAllocated(IObjectPoolCluster inObjPoolCluster) {} // 0x00000001822839A0-0x0000000182283A90
	// [XID] // 0x0000000189B83120-0x0000000189B83140
	public virtual void OnBeforePoolRecycled(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000182283880-0x00000001822839A0
	// [XID] // 0x0000000189B8A610-0x0000000189B8A630
	public uint GetRuntimeID() => default; // 0x00000001822837E0-0x0000000182283880
	// [XID] // 0x0000000189B91C20-0x0000000189B91C40
	public virtual void OnGameSceneLoadEnd() {} // 0x00000001822830A0-0x0000000182283140
	// [XID] // 0x0000000189B99100-0x0000000189B99120
	public Transform GetTransform() => default; // 0x0000000182283A90-0x0000000182283B30
	// [XID] // 0x0000000189BA0450-0x0000000189BA0470
	public uint GetGroupId() => default; // 0x0000000182280860-0x0000000182280930
	// [XID] // 0x0000000189BA7CD0-0x0000000189BA7CF0
	public Vector3 GetObjectPos() => default; // 0x0000000182282FC0-0x00000001822830A0
	// [XID] // 0x0000000189BAF100-0x0000000189BAF120
	public ulong GetHLodPath() => default; // 0x00000001822824C0-0x0000000182282570
	// [XID] // 0x0000000189BB6830-0x0000000189BB6850
	public Vector3 GetSectorSize() => default; // 0x0000000182280720-0x0000000182280860
	// [XID] // 0x0000000189BBDE00-0x0000000189BBDE20
	public SECTR_LayerType GetLayerType() => default; // 0x00000001822811A0-0x0000000182281250
	// [XID] // 0x0000000189BC5AE0-0x0000000189BC5B00
	public string GetLayerName() => default; // 0x0000000182280A90-0x0000000182280B40
	// [XID] // 0x0000000189BCD4E0-0x0000000189BCD500
	public string GetLayerFullName() => default; // 0x0000000182281F70-0x0000000182282020
	// [XID] // 0x0000000189BD4A70-0x0000000189BD4A90
	public SECTR_StreamLayer GetStreamLayer() => default; // 0x0000000182282960-0x0000000182282A00
	// [XID] // 0x0000000189BDC560-0x0000000189BDC580
	protected float GetRandLoadRatio() => default; // 0x0000000182282A00-0x0000000182282B10
	// [XID] // 0x00000001895E8E70-0x00000001895E8E90
	public virtual void Init(SECTR_StreamLayer layerInfo, Transform trans, ISECTR_BaseProxy groupProxy) {} // 0x0000000182282020-0x00000001822824C0
	// [XID] // 0x00000001895F06C0-0x00000001895F06E0
	private void AddGuidByInfo(SECTR_CombineStreamPathInfo info) {} // 0x0000000182282610-0x0000000182282860
	// [XID] // 0x00000001895F80D0-0x00000001895F80F0
	protected virtual void InitLoadSize() {} // 0x00000001822809F0-0x0000000182280A90
	// [XID] // 0x00000001895FF4F0-0x00000001895FF510
	public virtual void ResetLoadBounds() {} // 0x000000018227FD50-0x0000000182280290
	// [XID] // 0x0000000189606D80-0x0000000189606DA0
	public virtual void Release() {} // 0x0000000182282B10-0x0000000182282EE0
	// [XID] // 0x000000018960E6A0-0x000000018960E6C0
	public virtual void ClearLayer() {} // 0x000000018227F9E0-0x000000018227FAE0
	// [XID] // 0x0000000189615D60-0x0000000189615D80
	public virtual void SetActive(bool active, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001822834A0-0x00000001822836E0
	// [XID] // 0x000000018961D570-0x000000018961D590
	protected virtual bool IsLoaderActive() => default; // 0x0000000182282570-0x0000000182282610
	// [XID] // 0x0000000189624A70-0x0000000189624A90
	public bool AddReference(SECTR_ThreadContext context, bool bFromUnityThread) => default; // 0x00000001822836E0-0x00000001822837E0
	// [XID] // 0x000000018962C1D0-0x000000018962C1F0
	public bool RemoveReference(SECTR_ThreadContext context, bool bFromUnityThread) => default; // 0x0000000182282860-0x0000000182282960
	// [XID] // 0x0000000189633D30-0x0000000189633D50
	public void OnChunckLoaded(SECTR_GUID guid, ByteArray array) {} // 0x00000001822817D0-0x0000000182281F70
	// [XID] // 0x000000018963B530-0x000000018963B550
	private bool GetPlatformTypeAndAttachNameByHash(ulong hash, out SECTR_PlatformType type, out string attachName) {
		type = default;
		attachName = default;
		return default;
	} // 0x0000000182281250-0x00000001822817D0
	// [XID] // 0x0000000189642D80-0x0000000189642DA0
	protected void Load(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000182280520-0x0000000182280720
	// [XID] // 0x000000018964A3D0-0x000000018964A3F0
	private void LoadChunk(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000182280CF0-0x00000001822811A0
	// [XID] // 0x0000000189651B20-0x0000000189651B40
	protected void Unload(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000182282EE0-0x0000000182282FC0
	// [XID] // 0x00000001896593B0-0x00000001896593D0
	private void LoadingChunk(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000182283200-0x00000001822834A0
	// [XID] // 0x0000000189660A30-0x0000000189660A50
	private void UnloadChunk(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000182280B40-0x0000000182280CF0
	// [XID] // 0x0000000189668480-0x00000001896684A0
	protected virtual void SetupProxy(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000182283140-0x0000000182283200
	// [XID] // 0x000000018966FF30-0x000000018966FF50
	protected virtual void ClearProxy(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000182280930-0x00000001822809F0
	// [XID] // 0x0000000189677760-0x0000000189677780
	public void LoaderUnloaded(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000182280290-0x0000000182280520
	// [XID] // 0x000000018967ED00-0x000000018967ED20
	public virtual string ReportLog() => default; // 0x0000000182283B30-0x0000000182283C30
}

