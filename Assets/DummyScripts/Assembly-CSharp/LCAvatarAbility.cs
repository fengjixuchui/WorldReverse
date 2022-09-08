/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCAvatarAbility : LCAbility // TypeDefIndex: 11695
{
	// Fields
	private List<Tuple<uint, string, string>> _toAddAbilities; // 0x188
	private List<Tuple<uint, string, string>> _toRemoveAbilities; // 0x190
	private List<Tuple<uint, string, string>> _appliedAbilities; // 0x198

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001898AE940-0x00000001898AE960 */ get => default; } // 0x0000000181E309E0-0x0000000181E30A80 

	// Constructors
	public LCAvatarAbility() {} // 0x0000000181E30980-0x0000000181E309E0

	// Methods
	// [XID] // 0x00000001896F7C60-0x00000001896F7C80
	public override void OnEntityReady() {} // 0x0000000181E30720-0x0000000181E30920
	// [XID] // 0x00000001898BD620-0x00000001898BD640
	private void AddAllServerAbilities() {} // 0x0000000181E2FD30-0x0000000181E30490
	// [XID] // 0x00000001898C4EC0-0x00000001898C4EE0
	protected override void AddAbilityActionAndMixins(bool addAbilities = false /* Metadata: 0x00AEA6EF */) {} // 0x0000000181E2DEF0-0x0000000181E2E120
	// [XID] // 0x00000001898CC3C0-0x00000001898CC3E0
	protected override void AddAllDynamicConfigAbilities() {} // 0x0000000181E2E1D0-0x0000000181E2E7B0
	// [XID] // 0x00000001898D3D10-0x00000001898D3D30
	private void AddAllSkillDepotExtraAbilities() {} // 0x0000000181E30490-0x0000000181E30720
	private void clearList<T>(ref List<T> list) {}
	// [XID] // 0x00000001898DB480-0x00000001898DB4A0
	private void refreshAppliedAbilities() {} // 0x0000000181E2F970-0x0000000181E2FBB0
	// [XID] // 0x00000001898E3100-0x00000001898E3120
	public void RefreshAbilities(AvatarDataItem avatarDataItem) {} // 0x0000000181E2E7B0-0x0000000181E2F870
	// [XID] // 0x0000000189908FE0-0x0000000189909000
	public override void OnAbilityChanged(AvatarDataItem avatarDataItem) {} // 0x0000000181E2E120-0x0000000181E2E1D0
	// [XID] // 0x00000001898F2600-0x00000001898F2620
	public override void ClearOnDisconnect() {} // 0x0000000181E2FC80-0x0000000181E2FD30
}

