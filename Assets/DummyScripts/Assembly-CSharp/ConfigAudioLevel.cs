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
public class ConfigAudioLevel : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17589
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigWwiseString[] _teleportEvents; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _stateGroup; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigWwiseString> _dungeonEventMap; // 0x20

	// Properties
	public ConfigWwiseString[] teleportEvents { /* [XID] */ /* 0x0000000189BC18E0-0x0000000189BC1900 */ get => default; /* [XID] */ /* 0x0000000189BC8FA0-0x0000000189BC8FC0 */ private set {} } // 0x0000000185452DA0-0x0000000185452E40 0x0000000185452420-0x00000001854524D0
	public ConfigWwiseString stateGroup { /* [XID] */ /* 0x0000000189BD0810-0x0000000189BD0830 */ get => default; /* [XID] */ /* 0x0000000189BD7D50-0x0000000189BD7D70 */ private set {} } // 0x0000000185453410-0x00000001854534B0 0x0000000185452CF0-0x0000000185452DA0
	public Dictionary<string, ConfigWwiseString> dungeonEventMap { /* [XID] */ /* 0x0000000189940650-0x0000000189940670 */ get => default; /* [XID] */ /* 0x00000001895EC470-0x00000001895EC490 */ private set {} } // 0x0000000185452850-0x00000001854528F0 0x0000000185451EC0-0x0000000185451F70

	// Constructors
	public ConfigAudioLevel() {} // 0x0000000185453550-0x00000001854535B0

	// Methods
	// [XID] // 0x00000001895F38B0-0x00000001895F38D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185453190-0x00000001854532D0
	// [XID] // 0x00000001895FB1F0-0x00000001895FB210
	public void InitEmpty() {} // 0x00000001854528F0-0x00000001854529F0
	[BlackList] // 0x0000000189602970-0x00000001896029B0
	// [XID] // 0x0000000189602970-0x00000001896029B0
	public bool FromJson(JSONNode node) => default; // 0x00000001854524D0-0x0000000185452850
	// [XID] // 0x000000018960D200-0x000000018960D220
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185451630-0x00000001854519F0
	// [XID] // 0x0000000189614900-0x0000000189614920
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73ED */, bool useObjectPool = false /* Metadata: 0x00AF73F1 */) => default; // 0x00000001854529F0-0x0000000185452CF0
	// [XID] // 0x000000018961C240-0x000000018961C260
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF73F2 */, bool useObjectPool = false /* Metadata: 0x00AF73F6 */) => default; // 0x0000000185452090-0x0000000185452420
	[BlackList] // 0x0000000189623660-0x00000001896236A0
	// [XID] // 0x0000000189623660-0x00000001896236A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001854519F0-0x0000000185451CC0
	// [XID] // 0x000000018962DF50-0x000000018962DF70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185452E40-0x0000000185453190
	// [XID] // 0x0000000189635BF0-0x0000000189635C10
	public uint GetDungeonEvent(string eventName) => default; // 0x0000000185451F70-0x0000000185452090
	[BlackList] // 0x000000018963D2D0-0x000000018963D310
	// [XID] // 0x000000018963D2D0-0x000000018963D310
	public virtual void AutoAllocTypeFields() {} // 0x0000000185451CC0-0x0000000185451D60
	[BlackList] // 0x0000000189647850-0x0000000189647890
	// [XID] // 0x0000000189647850-0x0000000189647890
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185451D60-0x0000000185451EC0
	[BlackList] // 0x0000000189652000-0x0000000189652040
	// [XID] // 0x0000000189652000-0x0000000189652040
	public virtual void ReturnToObjectPool() {} // 0x00000001854534B0-0x0000000185453550
	[BlackList] // 0x000000018965C840-0x000000018965C880
	// [XID] // 0x000000018965C840-0x000000018965C880
	public virtual void OnPoolAllocated() {} // 0x0000000185453370-0x0000000185453410
	[BlackList] // 0x0000000189666FB0-0x0000000189666FF0
	// [XID] // 0x0000000189666FB0-0x0000000189666FF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001854532D0-0x0000000185453370
}

