/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigSoundBankLookup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19008
{
	// Fields
	private float _defaultCooldown; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigSoundBankUnloadPolicy> _unloadPolicies; // 0x18
	private uint[] _plainEvents; // 0x20
	private uint[] _bankIds; // 0x28
	private uint[] _conditionals; // 0x30
	private double _bankReuseRate; // 0x38
	private string[] _switchGroupsAffectedByRtpcs; // 0x40
	private string[] _switchGroupsAffectedByEvents; // 0x48
	private string[] _stateGroupsAffectedByEvents; // 0x50

	// Properties
	public float defaultCooldown { /* [XID] */ /* 0x0000000189B75B30-0x0000000189B75B50 */ get => default; /* [XID] */ /* 0x0000000189B7D000-0x0000000189B7D020 */ private set {} } // 0x00000001840ECE10-0x00000001840ECEC0 0x00000001840ECC00-0x00000001840ECCB0
	public Dictionary<string, ConfigSoundBankUnloadPolicy> unloadPolicies { /* [XID] */ /* 0x0000000189B84E90-0x0000000189B84EB0 */ get => default; /* [XID] */ /* 0x0000000189B8BC60-0x0000000189B8BC80 */ private set {} } // 0x00000001840EBF00-0x00000001840EBFA0 0x00000001840EC5C0-0x00000001840EC670
	public uint[] plainEvents { /* [XID] */ /* 0x0000000189B93490-0x0000000189B934B0 */ get => default; /* [XID] */ /* 0x0000000189B9A980-0x0000000189B9A9A0 */ private set {} } // 0x00000001840EB610-0x00000001840EB6B0 0x00000001840EB560-0x00000001840EB610
	public uint[] bankIds { /* [XID] */ /* 0x0000000189BA20D0-0x0000000189BA20F0 */ get => default; /* [XID] */ /* 0x0000000189BA9580-0x0000000189BA95A0 */ private set {} } // 0x00000001840EBE60-0x00000001840EBF00 0x00000001840ED9C0-0x00000001840EDA70
	public uint[] conditionals { /* [XID] */ /* 0x0000000189BB0D50-0x0000000189BB0D70 */ get => default; /* [XID] */ /* 0x0000000189BB7EE0-0x0000000189BB7F00 */ private set {} } // 0x00000001840EC860-0x00000001840EC900 0x00000001840ECCB0-0x00000001840ECD60
	public double bankReuseRate { /* [XID] */ /* 0x0000000189BBF690-0x0000000189BBF6B0 */ get => default; /* [XID] */ /* 0x0000000189BC72A0-0x0000000189BC72C0 */ private set {} } // 0x00000001840EC460-0x00000001840EC510 0x00000001840ED910-0x00000001840ED9C0
	public string[] switchGroupsAffectedByRtpcs { /* [XID] */ /* 0x0000000189BCEFF0-0x0000000189BCF010 */ get => default; /* [XID] */ /* 0x0000000189BD6360-0x0000000189BD6380 */ private set {} } // 0x00000001840EB6B0-0x00000001840EB750 0x00000001840EC7B0-0x00000001840EC860
	public string[] switchGroupsAffectedByEvents { /* [XID] */ /* 0x0000000189BDDE60-0x0000000189BDDE80 */ get => default; /* [XID] */ /* 0x00000001895EAAB0-0x00000001895EAAD0 */ private set {} } // 0x00000001840EC040-0x00000001840EC0E0 0x00000001840ECD60-0x00000001840ECE10
	public string[] stateGroupsAffectedByEvents { /* [XID] */ /* 0x00000001895F1EF0-0x00000001895F1F10 */ get => default; /* [XID] */ /* 0x00000001895F98C0-0x00000001895F98E0 */ private set {} } // 0x00000001840EBFA0-0x00000001840EC040 0x00000001840EC510-0x00000001840EC5C0

	// Constructors
	public ConfigSoundBankLookup() {} // 0x00000001840EDB10-0x00000001840EDB70

	// Methods
	// [XID] // 0x0000000189601000-0x0000000189601020
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840ED610-0x00000001840ED7D0
	// [XID] // 0x0000000189608990-0x00000001896089B0
	public void InitEmpty() {} // 0x00000001840EC670-0x00000001840EC7B0
	[BlackList] // 0x0000000189610110-0x0000000189610150
	// [XID] // 0x0000000189610110-0x0000000189610150
	public bool FromJson(JSONNode node) => default; // 0x00000001840EC0E0-0x00000001840EC460
	// [XID] // 0x000000018961A720-0x000000018961A740
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001840EA890-0x00000001840EB110
	// [XID] // 0x0000000189621C60-0x0000000189621C80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB729 */, bool useObjectPool = false /* Metadata: 0x00AFB72D */) => default; // 0x00000001840EC900-0x00000001840ECC00
	// [XID] // 0x0000000189629610-0x0000000189629630
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB72E */, bool useObjectPool = false /* Metadata: 0x00AFB732 */) => default; // 0x00000001840EB750-0x00000001840EBE60
	[BlackList] // 0x0000000189630EC0-0x0000000189630F00
	// [XID] // 0x0000000189630EC0-0x0000000189630F00
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001840EB110-0x00000001840EB3E0
	// [XID] // 0x000000018963B620-0x000000018963B640
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840ECEC0-0x00000001840ED610
	[BlackList] // 0x0000000189642E80-0x0000000189642EC0
	// [XID] // 0x0000000189642E80-0x0000000189642EC0
	public virtual void AutoAllocTypeFields() {} // 0x00000001840EB3E0-0x00000001840EB480
	[BlackList] // 0x000000018964D620-0x000000018964D660
	// [XID] // 0x000000018964D620-0x000000018964D660
	public virtual void AutoRecycleTypeFields() {} // 0x00000001840EB480-0x00000001840EB560
	[BlackList] // 0x0000000189657D10-0x0000000189657D50
	// [XID] // 0x0000000189657D10-0x0000000189657D50
	public virtual void ReturnToObjectPool() {} // 0x00000001840EDA70-0x00000001840EDB10
	[BlackList] // 0x0000000189662280-0x00000001896622C0
	// [XID] // 0x0000000189662280-0x00000001896622C0
	public virtual void OnPoolAllocated() {} // 0x00000001840ED870-0x00000001840ED910
	[BlackList] // 0x000000018966CAA0-0x000000018966CAE0
	// [XID] // 0x000000018966CAA0-0x000000018966CAE0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001840ED7D0-0x00000001840ED870
}

