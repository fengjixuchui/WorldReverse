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

public sealed class EvtAvatarAppear : BaseLevelEvent, IAutoAllocRecycle // TypeDefIndex: 20057
{
	// Fields
	public uint appearEntityId; // 0x30
	public VisionType appearAvatarType; // 0x34
	public bool remoteAvatarAppear; // 0x38

	// Constructors
	public EvtAvatarAppear() {} // 0x00000001817DF980-0x00000001817DF9F0

	// Methods
	[BlackList] // 0x0000000189B5C730-0x0000000189B5C770
	// [XID] // 0x0000000189B5C730-0x0000000189B5C770
	public override void AutoAllocTypeFields() {} // 0x00000001817DF3C0-0x00000001817DF460
	[BlackList] // 0x0000000189B66F60-0x0000000189B66FA0
	// [XID] // 0x0000000189B66F60-0x0000000189B66FA0
	public override void AutoRecycleTypeFields() {} // 0x00000001817DF460-0x00000001817DF510
	[BlackList] // 0x0000000189B714B0-0x0000000189B714F0
	// [XID] // 0x0000000189B714B0-0x0000000189B714F0
	public override void ReturnToObjectPool() {} // 0x00000001817DF7A0-0x00000001817DF840
	// [XID] // 0x0000000189B7B810-0x0000000189B7B830
	public void Init(uint appearId, VisionType appearType = VisionType.VisionNone /* Metadata: 0x00AFD1F8 */, bool remoteAppear = false /* Metadata: 0x00AFD1FC */) {} // 0x00000001817DF5E0-0x00000001817DF6E0
	// [XID] // 0x0000000189B831C0-0x0000000189B831E0
	public override string ToString() => default; // 0x00000001817DF840-0x00000001817DF980
}

