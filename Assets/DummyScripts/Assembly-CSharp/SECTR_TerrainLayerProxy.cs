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
public sealed class SECTR_TerrainLayerProxy : SECTR_StaticModelLayerProxy, IAutoAllocRecycleJobThread, ISECTR_ThreadCB // TypeDefIndex: 20308
{
	// Fields
	private Terrain _terrain; // 0x108
	// [SECTR_ToolTip] // 0x0000000189B566E0-0x0000000189B56710
	public SECTR_TerrainLayerProxy TopTerrain; // 0x110
	// [SECTR_ToolTip] // 0x0000000189B5F7A0-0x0000000189B5F7D0
	public SECTR_TerrainLayerProxy BottomTerrain; // 0x118
	// [SECTR_ToolTip] // 0x0000000189B686B0-0x0000000189B686E0
	public SECTR_TerrainLayerProxy LeftTerrain; // 0x120
	// [SECTR_ToolTip] // 0x0000000189B713A0-0x0000000189B713D0
	public SECTR_TerrainLayerProxy RightTerrain; // 0x128
	private State _state; // 0x130

	// Nested types
	private enum State // TypeDefIndex: 20309
	{
		Invalid = 0,
		Init = 1,
		Loaded = 2,
		TryToUnload = 3,
		UnLoaded = 4
	}

	// Constructors
	public SECTR_TerrainLayerProxy() {} // 0x0000000183176F70-0x0000000183176FE0

	// Methods
	[BlackList] // 0x0000000189B7A0B0-0x0000000189B7A0F0
	// [XID] // 0x0000000189B7A0B0-0x0000000189B7A0F0
	public override void AutoAllocTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000183175A90-0x0000000183175B40
	[BlackList] // 0x0000000189B84D10-0x0000000189B84D50
	// [XID] // 0x0000000189B84D10-0x0000000189B84D50
	public override void AutoRecycleTypeFields(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000183175B40-0x0000000183175C20
	[BlackList] // 0x0000000189B8EAC0-0x0000000189B8EB00
	// [XID] // 0x0000000189B8EAC0-0x0000000189B8EB00
	public override void ReturnToObjectPool(IObjectPoolCluster inObjPoolCluster) {} // 0x0000000183176EC0-0x0000000183176F70
	// [XID] // 0x0000000189B990E0-0x0000000189B99100
	public override void Init(SECTR_StreamLayer layerInfo, Transform trans, ISECTR_BaseProxy groupProxy) {} // 0x0000000183176500-0x0000000183176680
	// [XID] // 0x0000000189BA0430-0x0000000189BA0450
	public override void Release() {} // 0x0000000183176700-0x00000001831767D0
	// [XID] // 0x0000000189BA7CB0-0x0000000189BA7CD0
	public void ConnectTerrainNeighbors() {} // 0x0000000183175890-0x0000000183175A00
	// [XID] // 0x0000000189BAF0E0-0x0000000189BAF100
	public void OnUnityThreadCallBack() {} // 0x0000000183175D30-0x00000001831762B0
	// [IDTag] // 0x0000000189BB67F0-0x0000000189BB6830
	// [XID] // 0x0000000189BB67F0-0x0000000189BB6830
	private static Terrain GetTerrain(SECTR_TerrainLayerProxy layer) => default; // 0x0000000183176450-0x0000000183176500
	// [IDTag] // 0x0000000189BC1420-0x0000000189BC1460
	// [XID] // 0x0000000189BC1420-0x0000000189BC1460
	private Terrain GetTerrain() => default; // 0x00000001831763A0-0x0000000183176450
	// [XID] // 0x0000000189BCBD60-0x0000000189BCBD80
	public void SetupTerrain(Terrain terrain) {} // 0x0000000183176A50-0x0000000183176BF0
	// [XID] // 0x0000000189BD3290-0x0000000189BD32B0
	public void ReleaseTerrain(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831768C0-0x00000001831769F0
	// [XID] // 0x0000000189BDAC00-0x0000000189BDAC20
	protected override void ClearProxy(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x00000001831762B0-0x00000001831763A0
	// [XID] // 0x00000001895E7510-0x00000001895E7530
	public override string ReportLog() => default; // 0x0000000183176BF0-0x0000000183176EC0
}

