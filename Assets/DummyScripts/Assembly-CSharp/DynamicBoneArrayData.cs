/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using VerletEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class DynamicBoneArrayData : ITaskData // TypeDefIndex: 26589
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 7; // Metadata: 0x00B0C5D0
	private int _uid; // 0x14
	private ThreadData_DynamicBoneArray[] _buffer; // 0x18
	private DynamicBoneArray _monoBone; // 0x20
	private int _frontIdx; // 0x28
	private bool _bShouldTick; // 0x2C
	private static DynamicBoneArrayDataDeferRemoveContext deferRemoveContext; // 0x08

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001896607C0-0x00000001896607E0 */ get => default; } // 0x0000000181CA4390-0x0000000181CA44C0 
	public int nodeIndex { /* [XID] */ /* 0x0000000189668120-0x0000000189668160 */ get; /* [XID] */ /* 0x0000000189672DB0-0x0000000189672DF0 */ set; } // 0x0000000181CA4900-0x0000000181CA4960 0x0000000181CA4AA0-0x0000000181CA4B00
	public int typeId { /* [XID] */ /* 0x000000018967D530-0x000000018967D550 */ get => default; } // 0x0000000181CA4960-0x0000000181CA4A00 
	public int uid { /* [XID] */ /* 0x000000018969B7D0-0x000000018969B7F0 */ get => default; } // 0x0000000181CA4A00-0x0000000181CA4AA0 
	private int _backIdx { /* [XID] */ /* 0x00000001896AA3C0-0x00000001896AA3E0 */ get => default; } // 0x0000000181CA3060-0x0000000181CA3110 
	public static Action<DynamicBoneArrayData> onRemoveData { /* [XID] */ /* 0x00000001896B1220-0x00000001896B1240 */ set {} } // 0x0000000181CA4140-0x0000000181CA4220

	// Nested types
	public class DynamicBoneArrayDataDeferRemoveContext // TypeDefIndex: 26590
	{
		// Fields
		public Action<DynamicBoneArrayData> onRemoveData; // 0x10
		private List<DynamicBoneArrayData> _toRemoveData; // 0x18

		// Constructors
		public DynamicBoneArrayDataDeferRemoveContext() {} // 0x0000000181C9C8E0-0x0000000181C9C970

		// Methods
		// [XID] // 0x00000001896FB600-0x00000001896FB620
		public void QueueToRemoveData(DynamicBoneArrayData inData) {} // 0x0000000181C9C5A0-0x0000000181C9C6C0
		// [XID] // 0x0000000189702C50-0x0000000189702C70
		public void PurgeAllToRemoveData() {} // 0x0000000181C9C6C0-0x0000000181C9C8E0
	}

	// Constructors
	public DynamicBoneArrayData() {} // 0x0000000181CA4860-0x0000000181CA4900
	static DynamicBoneArrayData() {} // 0x0000000181CA47C0-0x0000000181CA4860

	// Methods
	// [XID] // 0x0000000189684BC0-0x0000000189684BE0
	public void Init() {} // 0x0000000181CA4080-0x0000000181CA4140
	// [XID] // 0x000000018968C770-0x000000018968C790
	public void Write() {} // 0x0000000181CA4720-0x0000000181CA47C0
	// [XID] // 0x00000001896941C0-0x00000001896941E0
	public void Free() {} // 0x0000000181CA3F30-0x0000000181CA3FE0
	// [XID] // 0x00000001896A2F30-0x00000001896A2F50
	public void Clear() {} // 0x0000000181CA3FE0-0x0000000181CA4080
	// [XID] // 0x00000001896B8D70-0x00000001896B8D90
	public static void QueueToRemoveData(DynamicBoneArrayData inData) {} // 0x0000000181CA2F80-0x0000000181CA3060
	// [XID] // 0x00000001896BFF70-0x00000001896BFF90
	public static void PurgeAllToRemoveData() {} // 0x0000000181CA4650-0x0000000181CA4720
	// [XID] // 0x00000001896C7870-0x00000001896C7890
	public void BindWithMonoDynamicBoneArray(DynamicBoneArray inMonoBone) {} // 0x0000000181CA4220-0x0000000181CA4390
	// [XID] // 0x00000001896CF050-0x00000001896CF070
	private void InternalAppendChangeFromUnityMain(ref ThreadData_DynamicBoneArray inData, UnityThreadPendingChange_DynamicBoneArray inChangeDynamicBoneArray) {} // 0x0000000181CA3450-0x0000000181CA3510
	// [XID] // 0x00000001896D6410-0x00000001896D6430
	private void InitializeThreadDataWithMonoBone(ref ThreadData_DynamicBoneArray inData) {} // 0x0000000181CA44C0-0x0000000181CA4650
	// [XID] // 0x00000001896DDA90-0x00000001896DDAB0
	private void FlushCalculatedResults(ref ThreadData_DynamicBoneArray inData) {} // 0x0000000181CA3680-0x0000000181CA3F30
	// [XID] // 0x00000001896E5180-0x00000001896E51A0
	public void PreApplyCollectPendingChangeFromUnityThread() {} // 0x0000000181CA32B0-0x0000000181CA3450
	// [XID] // 0x00000001896EC5F0-0x00000001896EC610
	public void ApplyCalculateResultInUnityThread() {} // 0x0000000181CA3110-0x0000000181CA32B0
	// [XID] // 0x00000001896F3DF0-0x00000001896F3E10
	public void Tick(float dt, float updateTime) {} // 0x0000000181CA3510-0x0000000181CA3680
}

