/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NpcEntity : GadgetEntity, IAutoAllocRecycle // TypeDefIndex: 19881
{
	// Fields
	private Transform _bip; // 0x558
	private static Mesh[] meshes; // 0x00
	private bool _isInTalk; // 0x560
	public static uint lastSpawnedNPCID; // 0x08

	// Properties
	public override bool isAuthority { /* [XID] */ /* 0x0000000189B7E660-0x0000000189B7E680 */ get => default; } // 0x000000018263B860-0x000000018263B900 

	// Constructors
	public NpcEntity() {} // 0x000000018263DCD0-0x000000018263DD60
	static NpcEntity() {} // 0x000000018263DC30-0x000000018263DCD0

	// Methods
	// [XID] // 0x0000000189B77010-0x0000000189B77030
	protected override EntityPreloader GetPreloder(ConfigPreloadType preloadType, bool withCreate = false /* Metadata: 0x00AFCFD8 */) => default; // 0x000000018263C6C0-0x000000018263C820
	// [XID] // 0x0000000189B862B0-0x0000000189B862D0
	public override bool CanReuseEntity() => default; // 0x000000018263C090-0x000000018263C130
	public override bool SetToBeRemoved<T>(ref T entityFieldToClear, bool checkSyncFromAuthority, bool isRecoverFromServer = false /* Metadata: 0x00AFCFD9 */) => default;
	// [XID] // 0x0000000189B8D390-0x0000000189B8D3B0
	public override void OnEntityReady() {} // 0x000000018263C820-0x000000018263CCE0
	// [XID] // 0x0000000189B94A50-0x0000000189B94A70
	public override Vector3 GetAbsolutePosition() => default; // 0x000000018263C130-0x000000018263C3D0
	// [XID] // 0x0000000189B9C120-0x0000000189B9C140
	public override Vector3 GetRelativePosition() => default; // 0x000000018263BE40-0x000000018263C090
	// [XID] // 0x0000000189BA3870-0x0000000189BA3890
	public override Vector3 GetEulerAngles() => default; // 0x000000018263D4F0-0x000000018263D820
	// [XID] // 0x0000000189BAAC60-0x0000000189BAAC80
	public override Quaternion GetRotation() => default; // 0x000000018263BBB0-0x000000018263BD30
	// [XID] // 0x0000000189BB2250-0x0000000189BB2270
	protected override void OnSetLightActive(bool active) {} // 0x000000018263B900-0x000000018263B9C0
	// [XID] // 0x0000000189BB9620-0x0000000189BB9640
	public override void SetIsInTalk(bool isInTalk) {} // 0x000000018263D370-0x000000018263D420
	// [XID] // 0x0000000189BC1560-0x0000000189BC1580
	public override bool IsInTalk() => default; // 0x000000018263BD90-0x000000018263BE40
	// [XID] // 0x0000000189BC8CA0-0x0000000189BC8CC0
	public override bool OnEvent(BaseEvent e) => default; // 0x000000018263D0E0-0x000000018263D220
	// [XID] // 0x0000000189BD0480-0x0000000189BD04A0
	public static ulong GetNPCPrefabPath(uint configID) => default; // 0x000000018263B7A0-0x000000018263B860
	// [XID] // 0x0000000189BD79B0-0x0000000189BD79D0
	public static BaseEntity BenchmarkSpawn(uint configID, Vector3 initPos, Quaternion rot, bool bNeedDefaultBehaviour = true /* Metadata: 0x00AFCFDA */) => default; // 0x000000018263CCE0-0x000000018263D0E0
	// [XID] // 0x0000000189BDF580-0x0000000189BDF5A0
	public static BaseEntity BenchmarkSpawnByTransform(uint configID, Transform npcLookAtTransform, Vector3 npcPosOffset, Quaternion npcRotation) => default; // 0x000000018263D8A0-0x000000018263DB00
	[BlackList] // 0x00000001895EC0D0-0x00000001895EC110
	// [XID] // 0x00000001895EC0D0-0x00000001895EC110
	public override void AutoAllocTypeFields() {} // 0x000000018263B9C0-0x000000018263BA60
	[BlackList] // 0x00000001895F6880-0x00000001895F68C0
	// [XID] // 0x00000001895F6880-0x00000001895F68C0
	public override void AutoRecycleTypeFields() {} // 0x000000018263BA60-0x000000018263BB20
	[BlackList] // 0x0000000189600F20-0x0000000189600F60
	// [XID] // 0x0000000189600F20-0x0000000189600F60
	public override void ReturnToObjectPool() {} // 0x000000018263DB90-0x000000018263DC30
}

