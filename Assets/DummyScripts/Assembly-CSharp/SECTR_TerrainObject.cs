/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x0000000189ADEFB0-0x0000000189ADEFD0
public sealed class SECTR_TerrainObject : SECTR_BaseObject, IAutoAllocRecycleJobThread // TypeDefIndex: 20310
{
	// Fields
	private SECTR_GUID _terrainGuid; // 0x68
	private SECTR_TerrainLayerProxy _terrainLayer; // 0x70
	// [PooledField] // 0x0000000189757FB0-0x0000000189757FD0
	private SECTR_Manager.LoadGameObjectCallBack _terrainLoadCB; // 0x78

	// Constructors
	public SECTR_TerrainObject() {} // 0x0000000181A982D0-0x0000000181A98370

	// Methods
	[BlackList] // 0x00000001895FDBE0-0x00000001895FDC20
	// [XID] // 0x00000001895FDBE0-0x00000001895FDC20
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000181A97660-0x0000000181A97710
	[BlackList] // 0x0000000189608810-0x0000000189608850
	// [XID] // 0x0000000189608810-0x0000000189608850
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000181A97710-0x0000000181A977D0
	[BlackList] // 0x0000000189612D60-0x0000000189612DA0
	// [XID] // 0x0000000189612D60-0x0000000189612DA0
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000181A98220-0x0000000181A982D0
	// [XID] // 0x000000018961D530-0x000000018961D550
	public override void Load(SECTR_StreamObject info, ISECTR_BaseProxy layer, bool isActive, Transform trans, int cellIndex, AssetJobPriority priority, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000181A977D0-0x0000000181A979E0
	// [XID] // 0x0000000189624A30-0x0000000189624A50
	public override void SetActive(bool isActive) {} // 0x0000000181A98050-0x0000000181A98120
	// [XID] // 0x000000018962C190-0x000000018962C1B0
	public override void UnLoad(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x0000000181A97E20-0x0000000181A97F40
	// [XID] // 0x0000000189633CF0-0x0000000189633D10
	private void LoadTerrainObjectCB(SECTR_GUID guid, GameObject obj) {} // 0x0000000181A97B70-0x0000000181A97CC0
	// [XID] // 0x000000018963B4F0-0x000000018963B510
	protected override void SetStreamObjectActive(GameObject obj, bool active) {} // 0x0000000181A98120-0x0000000181A98220
}

