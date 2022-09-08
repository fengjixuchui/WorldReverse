/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class BaseTalentMixin // TypeDefIndex: 14626
{
	// Fields
	[NonSerialized]
	public LCTalent actor; // 0x10
	[NonSerialized]
	public ActorTalent instancedTalent; // 0x18
	public bool forceRefreshWhenActive; // 0x20
	public ConfigTalentMixin config; // 0x28

	// Constructors
	public BaseTalentMixin() {} // 0x00000001840B7DF0-0x00000001840B7E50

	// Methods
	// [XID] // 0x00000001899BB8F0-0x00000001899BB910
	public virtual void Init(ActorTalent instancedTalent, ConfigTalentMixin config) {} // 0x00000001840B7D10-0x00000001840B7DF0
	// [XID] // 0x00000001899C3530-0x00000001899C3550
	public virtual void Destroy() {} // 0x00000001840B7B30-0x00000001840B7BD0
	// [XID] // 0x0000000189760600-0x0000000189760620
	public virtual void OnEnable() {} // 0x00000001840B7C70-0x00000001840B7D10
	// [XID] // 0x00000001899D1FD0-0x00000001899D1FF0
	public virtual void OnDisable() {} // 0x00000001840B7BD0-0x00000001840B7C70
	public static T CreateTalentMixin<T>(ActorTalent instancedTalent, ConfigTalentMixin config)
		where T : BaseTalentMixin, new() => default;
}

