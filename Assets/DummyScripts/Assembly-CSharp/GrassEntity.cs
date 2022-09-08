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

public sealed class GrassEntity : ScenePropEntity, IComparable<GrassEntity>, IAutoAllocRecycle // TypeDefIndex: 19883
{
	// Fields
	private MassiveEntityProxy _massiveEntityProxy; // 0x5A8

	// Properties
	public override bool isAuthority { /* [XID] */ /* 0x0000000189662180-0x00000001896621A0 */ get => default; /* [XID] */ /* 0x0000000189669D40-0x0000000189669D60 */ set {} } // 0x0000000184C49320-0x0000000184C49400 0x0000000184C49BE0-0x0000000184C49CA0
	public override float balanceTickDeltaTime { /* [XID] */ /* 0x00000001896719E0-0x0000000189671A00 */ get => default; } // 0x0000000184C4ACE0-0x0000000184C4ADE0 
	public MiHoYoGrassInfo grassInfo { /* [XID] */ /* 0x00000001896A5DC0-0x00000001896A5E00 */ get; /* [XID] */ /* 0x00000001896B0070-0x00000001896B00B0 */ private set; } // 0x0000000184C4A9A0-0x0000000184C4AA20 0x0000000184C49AF0-0x0000000184C49B70
	public override MassiveEntityProxy massiveEntityProxy { /* [XID] */ /* 0x00000001896F7090-0x00000001896F70B0 */ get => default; } // 0x0000000184C4A540-0x0000000184C4A5F0 

	// Constructors
	public GrassEntity() {} // 0x0000000184C4AC50-0x0000000184C4ACE0

	// Methods
	// [XID] // 0x0000000189679170-0x0000000189679190
	private void InitLightweight(uint inRuntimeID, uint inConfigID = 0 /* Metadata: 0x00AFCFE6 */) {} // 0x0000000184C49EB0-0x0000000184C4A0B0
	// [XID] // 0x00000001896808B0-0x00000001896808D0
	public override void Init(uint runtimeID, uint configID = 0 /* Metadata: 0x00AFCFEA */) {} // 0x0000000184C499E0-0x0000000184C49AF0
	// [XID] // 0x0000000189688480-0x00000001896884A0
	private void RemoveLightWeight() {} // 0x0000000184C4A110-0x0000000184C4A200
	// [XID] // 0x000000018968FCE0-0x000000018968FD00
	public override void RealSetToBeRemoved() {} // 0x0000000184C4A690-0x0000000184C4A770
	// [XID] // 0x00000001896976A0-0x00000001896976C0
	protected override void AllocatedAbilityProxy() {} // 0x0000000184C4A770-0x0000000184C4A870
	// [XID] // 0x000000018969EB90-0x000000018969EBB0
	protected override void DeallocatedAbilityProxy() {} // 0x0000000184C4A5F0-0x0000000184C4A690
	// [XID] // 0x00000001896BA710-0x00000001896BA730
	public void SetGrassInfo(MiHoYoGrassInfo info) {} // 0x0000000184C49190-0x0000000184C49320
	// [XID] // 0x00000001896C17E0-0x00000001896C1800
	public override long GetScenePropID() => default; // 0x0000000184C49DD0-0x0000000184C49EB0
	// [XID] // 0x00000001896C8F20-0x00000001896C8F40
	public override float GetBoundsMagnitude() => default; // 0x0000000184C4A360-0x0000000184C4A4E0
	// [XID] // 0x00000001896D08E0-0x00000001896D0900
	public int CompareTo(GrassEntity other) => default; // 0x0000000184C497E0-0x0000000184C49980
	[BlackList] // 0x00000001896D7DF0-0x00000001896D7E30
	// [XID] // 0x00000001896D7DF0-0x00000001896D7E30
	public override void AutoAllocTypeFields() {} // 0x0000000184C494F0-0x0000000184C49590
	[BlackList] // 0x00000001896E26E0-0x00000001896E2720
	// [XID] // 0x00000001896E26E0-0x00000001896E2720
	public override void AutoRecycleTypeFields() {} // 0x0000000184C49590-0x0000000184C496B0
	[BlackList] // 0x00000001896EC880-0x00000001896EC8C0
	// [XID] // 0x00000001896EC880-0x00000001896EC8C0
	public override void ReturnToObjectPool() {} // 0x0000000184C4ABB0-0x0000000184C4AC50
	// [XID] // 0x00000001896FEA40-0x00000001896FEA60
	protected override void InitMassiveProxy() {} // 0x0000000184C4AA90-0x0000000184C4AB50
	// [XID] // 0x0000000189705D60-0x0000000189705D80
	protected override void DestroyMassiveProxy() {} // 0x0000000184C4A8F0-0x0000000184C4A9A0
	// [XID] // 0x000000018970D6B0-0x000000018970D6D0
	protected override void SwitchScenePropId(long scenePropId) {} // 0x0000000184C4A280-0x0000000184C4A360
}

