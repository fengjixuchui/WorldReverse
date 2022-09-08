/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAvatarChanged : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20059
{
	// Fields
	public uint fromEntityId; // 0x30
	public uint toEntityId; // 0x34
	public VisionType changeAvatarType; // 0x38
	public bool remoteAvatarChanged; // 0x3C

	// Constructors
	public EvtAvatarChanged() {} // 0x0000000182557B00-0x0000000182557B70

	// Methods
	[BlackList] // 0x00000001895FC5B0-0x00000001895FC5F0
	// [XID] // 0x00000001895FC5B0-0x00000001895FC5F0
	public override void AutoAllocTypeFields() {} // 0x0000000182557550-0x00000001825575F0
	[BlackList] // 0x0000000189606DA0-0x0000000189606DE0
	// [XID] // 0x0000000189606DA0-0x0000000189606DE0
	public override void AutoRecycleTypeFields() {} // 0x00000001825575F0-0x00000001825576A0
	[BlackList] // 0x0000000189611820-0x0000000189611860
	// [XID] // 0x0000000189611820-0x0000000189611860
	public override void ReturnToObjectPool() {} // 0x0000000182557940-0x00000001825579E0
	// [XID] // 0x000000018961BE30-0x000000018961BE50
	public void Init(uint fromEntityId, uint toEntityId, VisionType changeAvatarType = VisionType.VisionNone /* Metadata: 0x00AFD1FD */, bool remoteChanged = false /* Metadata: 0x00AFD201 */) {} // 0x0000000182557770-0x0000000182557880
	// [XID] // 0x00000001896233C0-0x00000001896233E0
	public override string ToString() => default; // 0x00000001825579E0-0x0000000182557B00
}

