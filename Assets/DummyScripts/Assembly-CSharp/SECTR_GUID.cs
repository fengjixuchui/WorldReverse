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

[fiInspectorOnly] // 0x0000000189A06FC0-0x0000000189A07000
[RecycleType] // 0x0000000189A06FC0-0x0000000189A07000
public class SECTR_GUID : IAutoAllocRecycle, ISECTR_Reuseable // TypeDefIndex: 20255
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public ulong pathHash; // 0x10
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public uint uid; // 0x18
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public uint handle; // 0x1C
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private bool isUsing; // 0x20
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private bool isLoading; // 0x21
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private AsyncJob loadJobHandle; // 0x28
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private EAsyncRequestStatus currentAsyncStatus; // 0x38
	private static uint GLOBAL_GUID_INDEX; // 0x00
	private static SECTR_ObjectPool<SECTR_GUID> _pool; // 0x08

	// Properties
	public EAsyncRequestStatus asyncStatus { /* [XID] */ /* 0x0000000189AF7180-0x0000000189AF71A0 */ get => default; } // 0x00000001846B5850-0x00000001846B58F0 
	public static SECTR_ObjectPool<SECTR_GUID> Pool { /* [XID] */ /* 0x0000000189B8BB20-0x0000000189B8BB40 */ get => default; } // 0x00000001846B5FC0-0x00000001846B6110 

	// Nested types
	public enum EAsyncRequestStatus // TypeDefIndex: 20256
	{
		EARS_None = 0,
		EARS_RequestLoad = 1,
		EARS_Loading = 2,
		EARS_Loaded = 3,
		EARS_RequestUnload = 4,
		EARS_Unloaded = 5,
		EARS_Recycled = 6
	}

	// Constructors
	public SECTR_GUID() {} // 0x00000001846B6610-0x00000001846B6680
	static SECTR_GUID() {} // 0x00000001846B65B0-0x00000001846B6610

	// Methods
	[BlackList] // 0x0000000189AD7540-0x0000000189AD7580
	// [XID] // 0x0000000189AD7540-0x0000000189AD7580
	public virtual void AutoAllocTypeFields() {} // 0x00000001846B52E0-0x00000001846B5380
	[BlackList] // 0x0000000189AE1E70-0x0000000189AE1EB0
	// [XID] // 0x0000000189AE1E70-0x0000000189AE1EB0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001846B5380-0x00000001846B5440
	[BlackList] // 0x0000000189AEC760-0x0000000189AEC7A0
	// [XID] // 0x0000000189AEC760-0x0000000189AEC7A0
	public virtual void ReturnToObjectPool() {} // 0x00000001846B6510-0x00000001846B65B0
	// [XID] // 0x0000000189AFE7B0-0x0000000189AFE7D0
	public void OnPoolAllocated() {} // 0x00000001846B6250-0x00000001846B62F0
	// [XID] // 0x0000000189B06020-0x0000000189B06040
	public void OnBeforePoolRecycled() {} // 0x00000001846B61B0-0x00000001846B6250
	// [XID] // 0x0000000189B0D750-0x0000000189B0D770
	public void OnRequestLoad() {} // 0x00000001846B5590-0x00000001846B5630
	// [XID] // 0x0000000189B14C50-0x0000000189B14C70
	public void OnStartLoading(AsyncJob inLoadJobHandle) {} // 0x00000001846B5B80-0x00000001846B5C40
	// [XID] // 0x0000000189B1C510-0x0000000189B1C530
	private void ClearLoadJobHandle() {} // 0x00000001846B5100-0x00000001846B51C0
	// [XID] // 0x0000000189B23B20-0x0000000189B23B40
	public void OnAsyncLoaded() {} // 0x00000001846B5AD0-0x00000001846B5B80
	// [XID] // 0x0000000189B2AE20-0x0000000189B2AE40
	public void OnLoaded() {} // 0x00000001846B54F0-0x00000001846B5590
	// [XID] // 0x0000000189B32360-0x0000000189B32380
	public void OnRequestUnLoad() {} // 0x00000001846B58F0-0x00000001846B5990
	// [XID] // 0x0000000189B39CD0-0x0000000189B39CF0
	public void OnUnloaded() {} // 0x00000001846B5630-0x00000001846B5710
	// [XID] // 0x0000000189B41550-0x0000000189B41570
	private void OnInited() {} // 0x00000001846B5D50-0x00000001846B5E00
	// [XID] // 0x0000000189B48F60-0x0000000189B48F80
	public void OnRecycled(GameObject obj) {} // 0x00000001846B62F0-0x00000001846B63C0
	// [XID] // 0x0000000189B50560-0x0000000189B50580
	public void Init(ulong p, ISECTR_Base b) {} // 0x00000001846B5990-0x00000001846B5AD0
	// [XID] // 0x0000000189B57E30-0x0000000189B57E50
	public void Recycle(GameObject obj) {} // 0x00000001846B5710-0x00000001846B5850
	// [XID] // 0x0000000189B5F7F0-0x0000000189B5F810
	public void BeginLoading() {} // 0x00000001846B6110-0x00000001846B61B0
	// [XID] // 0x0000000189B66EA0-0x0000000189B66EC0
	public bool EndLoading(GameObject obj) => default; // 0x00000001846B5C40-0x00000001846B5D50
	// [XID] // 0x0000000189B6E200-0x0000000189B6E220
	public void Dismiss(GameObject obj) {} // 0x00000001846B5E00-0x00000001846B5FC0
	// [XID] // 0x0000000189B75A30-0x0000000189B75A50
	public bool HasLoaded() => default; // 0x00000001846B5440-0x00000001846B54F0
	// [XID] // 0x0000000189B7CE70-0x0000000189B7CE90
	public static void ClearPool() {} // 0x00000001846B51C0-0x00000001846B52E0
	// [XID] // 0x0000000189B84D70-0x0000000189B84D90
	public string ReportLog() => default; // 0x00000001846B63C0-0x00000001846B6510
}

