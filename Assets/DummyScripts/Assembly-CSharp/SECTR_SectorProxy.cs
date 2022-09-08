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
public class SECTR_SectorProxy : IAutoAllocRecycle, ISECTR_BaseProxy // TypeDefIndex: 20302
{
	// Fields
	public SECTR_DebugSectorProxy debugMono; // 0x10
	public static readonly uint SectorSize; // 0x00
	public SECTR_BaseSectorObject sectorObj; // 0x18
	private uint _runtimeID; // 0x20
	public Vector3 distanceScale; // 0x24

	// Properties
	public List<SECTR_LayerGroupProxy> groupProxies { /* [XID] */ /* 0x0000000189A24730-0x0000000189A24750 */ get => default; } // 0x000000018273C890-0x000000018273C940 

	// Constructors
	public SECTR_SectorProxy() {} // 0x000000018273CD30-0x000000018273CDA0
	static SECTR_SectorProxy() {} // 0x000000018273CCD0-0x000000018273CD30

	// Methods
	[BlackList] // 0x0000000189A05AB0-0x0000000189A05AF0
	// [XID] // 0x0000000189A05AB0-0x0000000189A05AF0
	public virtual void AutoAllocTypeFields() {} // 0x000000018273BE80-0x000000018273BF20
	[BlackList] // 0x0000000189A0FCD0-0x0000000189A0FD10
	// [XID] // 0x0000000189A0FCD0-0x0000000189A0FD10
	public virtual void AutoRecycleTypeFields() {} // 0x000000018273BF20-0x000000018273BFE0
	[BlackList] // 0x0000000189A1A1D0-0x0000000189A1A210
	// [XID] // 0x0000000189A1A1D0-0x0000000189A1A210
	public virtual void ReturnToObjectPool() {} // 0x000000018273CC30-0x000000018273CCD0
	// [XID] // 0x0000000189A2BBF0-0x0000000189A2BC10
	public virtual void OnPoolAllocated() {} // 0x000000018273CA80-0x000000018273CB20
	// [XID] // 0x0000000189A33210-0x0000000189A33230
	public virtual void OnBeforePoolRecycled() {} // 0x000000018273C9E0-0x000000018273CA80
	// [XID] // 0x0000000189A3AAE0-0x0000000189A3AB00
	public uint GetRuntimeID() => default; // 0x000000018273C940-0x000000018273C9E0
	// [XID] // 0x0000000189A423B0-0x0000000189A423D0
	public void Init(SECTR_Sector sector, int groupId, Transform trans) {} // 0x000000018273C0C0-0x000000018273C6B0
	// [XID] // 0x0000000189A499E0-0x0000000189A49A00
	public void Release() {} // 0x000000018273C760-0x000000018273C890
	// [XID] // 0x0000000189A51370-0x0000000189A51390
	public void Reset(SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018273BFE0-0x000000018273C0C0
	// [XID] // 0x0000000189A58960-0x0000000189A58980
	public void Clear() {} // 0x000000018273C6B0-0x000000018273C760
	// [XID] // 0x0000000189A60480-0x0000000189A604A0
	public virtual string ReportLog() => default; // 0x000000018273CB20-0x000000018273CC30
}

