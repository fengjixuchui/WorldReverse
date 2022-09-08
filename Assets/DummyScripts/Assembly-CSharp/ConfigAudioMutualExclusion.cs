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
public class ConfigAudioMutualExclusion : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17601
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioMutualExclusion[] _exclusionPairs; // 0x10
	private Dictionary<uint, List<AudioMutualExclusionItem>> _exclusionRules; // 0x18

	// Properties
	public AudioMutualExclusion[] exclusionPairs { /* [XID] */ /* 0x0000000189941180-0x00000001899411A0 */ get => default; /* [XID] */ /* 0x0000000189948C60-0x0000000189948C80 */ private set {} } // 0x000000018130CCE0-0x000000018130CD80 0x000000018130CA20-0x000000018130CAD0

	// Constructors
	public ConfigAudioMutualExclusion() {} // 0x000000018130DE90-0x000000018130DEF0

	// Methods
	// [XID] // 0x0000000189950430-0x0000000189950450
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018130DBD0-0x000000018130DCB0
	// [XID] // 0x00000001899579C0-0x00000001899579E0
	public void InitEmpty() {} // 0x000000018130D100-0x000000018130D1D0
	[BlackList] // 0x000000018995F1F0-0x000000018995F230
	// [XID] // 0x000000018995F1F0-0x000000018995F230
	public bool FromJson(JSONNode node) => default; // 0x000000018130CD80-0x000000018130D100
	// [XID] // 0x00000001899699A0-0x00000001899699C0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018130C420-0x000000018130C600
	// [XID] // 0x00000001899716E0-0x0000000189971700
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7459 */, bool useObjectPool = false /* Metadata: 0x00AF745D */) => default; // 0x000000018130D1D0-0x000000018130D4D0
	// [XID] // 0x0000000189979030-0x0000000189979050
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF745E */, bool useObjectPool = false /* Metadata: 0x00AF7462 */) => default; // 0x000000018130CAD0-0x000000018130CCE0
	[BlackList] // 0x0000000189980100-0x0000000189980140
	// [XID] // 0x0000000189980100-0x0000000189980140
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018130C600-0x000000018130C8D0
	// [XID] // 0x000000018998AD40-0x000000018998AD60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018130D800-0x000000018130D9F0
	// [XID] // 0x0000000189992610-0x0000000189992630
	public void BuildExclusionTable() {} // 0x000000018130D9F0-0x000000018130DBD0
	// [XID] // 0x000000018999A370-0x000000018999A390
	public List<AudioMutualExclusionItem> GetExclusionItemsForEvent(uint eventHashId) => default; // 0x000000018130D4D0-0x000000018130D5B0
	// [XID] // 0x00000001899A1A50-0x00000001899A1A70
	private void AddExclsionItem(string eventNameA, string eventNameB, AudioScope scope) {} // 0x000000018130D5B0-0x000000018130D800
	[BlackList] // 0x00000001899A92A0-0x00000001899A92E0
	// [XID] // 0x00000001899A92A0-0x00000001899A92E0
	public virtual void AutoAllocTypeFields() {} // 0x000000018130C8D0-0x000000018130C970
	[BlackList] // 0x00000001899B3D40-0x00000001899B3D80
	// [XID] // 0x00000001899B3D40-0x00000001899B3D80
	public virtual void AutoRecycleTypeFields() {} // 0x000000018130C970-0x000000018130CA20
	[BlackList] // 0x00000001899BE430-0x00000001899BE470
	// [XID] // 0x00000001899BE430-0x00000001899BE470
	public virtual void ReturnToObjectPool() {} // 0x000000018130DDF0-0x000000018130DE90
	[BlackList] // 0x00000001899C8980-0x00000001899C89C0
	// [XID] // 0x00000001899C8980-0x00000001899C89C0
	public virtual void OnPoolAllocated() {} // 0x000000018130DD50-0x000000018130DDF0
	[BlackList] // 0x00000001899D3190-0x00000001899D31D0
	// [XID] // 0x00000001899D3190-0x00000001899D31D0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018130DCB0-0x000000018130DD50
}

