/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCAttackAttenuationPlugin : BaseComponentPlugin // TypeDefIndex: 12054
{
	// Fields
	private Dictionary<uint, Dictionary<string, Dictionary<string, AttackCount>>> _attacks; // 0x58

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B3D560-0x0000000189B3D580 */ get => default; } // 0x0000000182310230-0x00000001823102F0 

	// Nested types
	public class AttackCount // TypeDefIndex: 12055
	{
		// Fields
		public DateTime firstAttackTime; // 0x10
		public int attackCount; // 0x20
		public float firstAttackTimeNew; // 0x24

		// Constructors
		public AttackCount() {} // 0x0000000183182E70-0x0000000183182ED0
	}

	// Constructors
	public LCAttackAttenuationPlugin() {} // 0x00000001823101D0-0x0000000182310230

	// Methods
	// [XID] // 0x0000000189B453C0-0x0000000189B453E0
	public override void Init() {} // 0x0000000182310060-0x0000000182310100
	// [XID] // 0x0000000189B4CA10-0x0000000189B4CA30
	public override void Destroy() {} // 0x000000018230ED60-0x000000018230F210
	// [XID] // 0x0000000189B54160-0x0000000189B54180
	public uint CountAttackAttenuation(uint runtimeID, string group, string tag) => default; // 0x000000018230F890-0x0000000182310060
	// [XID] // 0x0000000189B5BBC0-0x0000000189B5BBE0
	private bool UseNewAttenuationTime() => default; // 0x000000018230F210-0x000000018230F2B0
	// [XID] // 0x0000000189B62FC0-0x0000000189B62FE0
	public float GetElemDurabilityAttenuation(uint runtimeID, string group, string tag, uint attackCount) => default; // 0x000000018230F2B0-0x000000018230F5A0
	// [XID] // 0x00000001896422F0-0x0000000189642310
	public float GetEnbreakAttenuation(uint runtimeID, string group, string tag, uint attackCount) => default; // 0x000000018230F5A0-0x000000018230F890
	// [XID] // 0x0000000189B721A0-0x0000000189B721C0
	public float GetDamageAttenuation(uint runtimeID, string group, string tag, uint attackCount) => default; // 0x000000018230EA70-0x000000018230ED60
}

