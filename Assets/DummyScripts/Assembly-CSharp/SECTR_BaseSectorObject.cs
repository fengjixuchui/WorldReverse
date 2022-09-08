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

[fiInspectorOnly] // 0x000000018987FF20-0x000000018987FF60
[RecycleType] // 0x000000018987FF20-0x000000018987FF60
public class SECTR_BaseSectorObject : SECTR_Base, IAutoAllocRecycle, ISECTR_LODLoader, ISECTR_ThreadCB // TypeDefIndex: 20243
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	protected SectorState hlodState; // 0x48
	public const int UNLOAD_MIN_DISTANCE_SQR = 200; // Metadata: 0x00AFD463
	public const int UNLOAD_MAX_DISTANCE_SQR = 6000; // Metadata: 0x00AFD467
	public static float UNLOAD_REGION; // 0x00
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public float curDistance; // 0x4C
	private bool _isControlled; // 0x50
	[InspectorCollapsedFoldout] // 0x000000018974DB70-0x000000018974DBD0
	[InspectorCollectionShowItemDropdown] // 0x000000018974DB70-0x000000018974DBD0
	// [PooledField] // 0x000000018974DB70-0x000000018974DBD0
	[ShowInInspector] // 0x000000018974DB70-0x000000018974DBD0
	public List<SECTR_LayerGroupProxy> layerGroups; // 0x58
	private SECTR_LinkedListNode<ISECTR_LODLoader> _curNode; // 0x60
	public int groupId; // 0x68
	[InspectorCollapsedFoldout] // 0x0000000189B32380-0x0000000189B323C0
	[InspectorCollectionShowItemDropdown] // 0x0000000189B32380-0x0000000189B323C0
	[ShowInInspector] // 0x0000000189B32380-0x0000000189B323C0
	public SECTR_Sector sectorInfo; // 0x70
	[InspectorCollapsedFoldout] // 0x000000018976B560-0x000000018976B5A0
	[InspectorCollectionShowItemDropdown] // 0x000000018976B560-0x000000018976B5A0
	[ShowInInspector] // 0x000000018976B560-0x000000018976B5A0
	public SECTR_HLODObject hlodObjProxy; // 0x78
	[InspectorCollapsedFoldout] // 0x0000000189BC1460-0x0000000189BC14A0
	[InspectorCollectionShowItemDropdown] // 0x0000000189BC1460-0x0000000189BC14A0
	[ShowInInspector] // 0x0000000189BC1460-0x0000000189BC14A0
	public SECTR_StreamObject hlodObjInfo; // 0x80
	public Vector3 distanceScale; // 0x88
	private SECTR_SectorProxy _sectorProxy; // 0x98

	// Nested types
	protected enum SectorState // TypeDefIndex: 20244
	{
		Init = 0,
		HLODLoaded = 1,
		HLODUnloaded = 2,
		Release = 3
	}

	// Constructors
	public SECTR_BaseSectorObject() {} // 0x00000001831D7B90-0x00000001831D7C10
	static SECTR_BaseSectorObject() {} // 0x00000001831D7B30-0x00000001831D7B90

	// Methods
	[BlackList] // 0x00000001897862A0-0x00000001897862E0
	// [XID] // 0x00000001897862A0-0x00000001897862E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001831D5740-0x00000001831D5810
	[BlackList] // 0x0000000189790890-0x00000001897908D0
	// [XID] // 0x0000000189790890-0x00000001897908D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001831D5810-0x00000001831D5910
	[BlackList] // 0x000000018979B990-0x000000018979B9D0
	// [XID] // 0x000000018979B990-0x000000018979B9D0
	public virtual void ReturnToObjectPool() {} // 0x00000001831D7A90-0x00000001831D7B30
	// [XID] // 0x00000001897A6120-0x00000001897A6140
	public virtual void OnPoolAllocated() {} // 0x00000001831D79E0-0x00000001831D7A90
	// [XID] // 0x00000001897AD5D0-0x00000001897AD5F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001831D7930-0x00000001831D79E0
	// [XID] // 0x00000001897B56B0-0x00000001897B56D0
	public SECTR_SectorType GetSectorType() => default; // 0x00000001831D5690-0x00000001831D5740
	// [XID] // 0x00000001897BD2F0-0x00000001897BD310
	public virtual void Load(SECTR_Sector info, SECTR_SectorProxy sector, Transform trans, int gid, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831D5A10-0x00000001831D5E90
	// [XID] // 0x00000001897C4620-0x00000001897C4640
	public override void UnLoad(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831D7650-0x00000001831D7770
	// [XID] // 0x00000001897CBE30-0x00000001897CBE50
	public void Reset(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831D6520-0x00000001831D66B0
	// [XID] // 0x00000001897D3860-0x00000001897D3880
	public void Clear() {} // 0x00000001831D6D20-0x00000001831D6E40
	// [XID] // 0x00000001897DB2F0-0x00000001897DB310
	public uint GetGroupId() => default; // 0x00000001831D5FF0-0x00000001831D6090
	// [XID] // 0x00000001897E29C0-0x00000001897E29E0
	public void RefreshLODPattern() {} // 0x00000001831D6E40-0x00000001831D6EE0
	// [XID] // 0x00000001897EA120-0x00000001897EA140
	public void InitGroups(bool bFromUnityThread) {} // 0x00000001831D61A0-0x00000001831D6520
	// [XID] // 0x00000001897F1D90-0x00000001897F1DB0
	private void ReleaseGroups() {} // 0x00000001831D6EE0-0x00000001831D7140
	// [XID] // 0x00000001897F9650-0x00000001897F9670
	private void ResetGroups(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831D6920-0x00000001831D6AD0
	// [XID] // 0x0000000189800B70-0x0000000189800B90
	public void ClearGroups() {} // 0x00000001831D6C00-0x00000001831D6D20
	// [XID] // 0x0000000189808100-0x0000000189808120
	private void ShowGroups(bool enable, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831D5E90-0x00000001831D5FF0
	// [XID] // 0x000000018980FB10-0x000000018980FB30
	protected void InitLODControl() {} // 0x00000001831D7800-0x00000001831D7930
	// [XID] // 0x00000001898170E0-0x0000000189817100
	protected void RemoveLODControl() {} // 0x00000001831D6AD0-0x00000001831D6C00
	// [XID] // 0x000000018981E9F0-0x000000018981EA10
	public float GetDistanceToCamera(Vector3 pos, SECTR_ThreadContext context) => default; // 0x00000001831D7140-0x00000001831D7310
	// [XID] // 0x0000000189825EC0-0x0000000189825EE0
	public void SelectLOD(Vector3 pos, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831D66B0-0x00000001831D6920
	// [XID] // 0x000000018982D580-0x000000018982D5A0
	public void ForceActiveLOD(int lod, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831D5910-0x00000001831D5A10
	// [XID] // 0x0000000189834CD0-0x0000000189834CF0
	protected void LoadLodDetail(SectorState useHlod, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831D7430-0x00000001831D7650
	// [XID] // 0x000000018983C4B0-0x000000018983C4D0
	public void OnUnityThreadCallBack() {} // 0x00000001831D6090-0x00000001831D61A0
	// [XID] // 0x0000000189843A80-0x0000000189843AA0
	protected bool CheckWhiteBox() => default; // 0x00000001831D7310-0x00000001831D7430
}

