/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class EntityTimer : NormalTimer // TypeDefIndex: 31445
{
	// Fields
	private BaseEntity _timeScaleEntity; // 0x30
	private bool _ignoreTimeScale; // 0x38

	// Constructors
	public EntityTimer() {} // 0x0000000184B4C270-0x0000000184B4C2E0

	// Methods
	// [IDTag] // 0x0000000189B9A020-0x0000000189B9A060
	// [XID] // 0x0000000189B9A020-0x0000000189B9A060
	public override void Init() {} // 0x0000000184B4BC10-0x0000000184B4BD60
	// [IDTag] // 0x0000000189BA4790-0x0000000189BA47D0
	// [XID] // 0x0000000189BA4790-0x0000000189BA47D0
	public override void Init(float timespan) {} // 0x0000000184B4BF70-0x0000000184B4C080
	// [IDTag] // 0x0000000189BAEA30-0x0000000189BAEA70
	// [XID] // 0x0000000189BAEA30-0x0000000189BAEA70
	public virtual void Init(float timespan, BaseEntity timeScaleEntity) {} // 0x0000000184B4BE90-0x0000000184B4BF70
	// [IDTag] // 0x0000000189BB8F50-0x0000000189BB8F90
	// [XID] // 0x0000000189BB8F50-0x0000000189BB8F90
	public virtual void Init(float timespan, BaseEntity timeScaleEntity, bool active) {} // 0x0000000184B4BD60-0x0000000184B4BE90
	// [XID] // 0x0000000189BC3E20-0x0000000189BC3E40
	public void SetIgnoreTimeScale(bool ignoreTimeScale) {} // 0x0000000184B4BB60-0x0000000184B4BC10
	// [XID] // 0x0000000189BCB720-0x0000000189BCB740
	public override void Clear() {} // 0x0000000184B4C080-0x0000000184B4C130
	// [XID] // 0x0000000189BD2D20-0x0000000189BD2D40
	protected override float GetCurrentDeltaTime(float deltaTime) => default; // 0x0000000184B4C130-0x0000000184B4C210
}

