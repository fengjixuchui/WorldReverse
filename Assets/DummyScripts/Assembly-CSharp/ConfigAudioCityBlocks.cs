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
public class ConfigAudioCityBlocks : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17563
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigWwiseString> _musicSubStates; // 0x10

	// Properties
	public Dictionary<string, ConfigWwiseString> musicSubStates { /* [XID] */ /* 0x00000001896FA230-0x00000001896FA250 */ get => default; /* [XID] */ /* 0x00000001897019A0-0x00000001897019C0 */ private set {} } // 0x00000001813661C0-0x0000000181366260 0x00000001813667F0-0x00000001813668A0

	// Constructors
	public ConfigAudioCityBlocks() {} // 0x0000000181367270-0x00000001813672D0

	// Methods
	// [XID] // 0x00000001897092C0-0x00000001897092E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181366E60-0x0000000181366F40
	// [XID] // 0x0000000189710BD0-0x0000000189710BF0
	public void InitEmpty() {} // 0x00000001813668A0-0x0000000181366970
	[BlackList] // 0x0000000189717E50-0x0000000189717E90
	// [XID] // 0x0000000189717E50-0x0000000189717E90
	public bool FromJson(JSONNode node) => default; // 0x0000000181366470-0x00000001813667F0
	// [XID] // 0x00000001897225E0-0x0000000189722600
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181365BB0-0x0000000181365D90
	// [XID] // 0x0000000189729CC0-0x0000000189729CE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7307 */, bool useObjectPool = false /* Metadata: 0x00AF730B */) => default; // 0x0000000181366970-0x0000000181366C70
	// [XID] // 0x0000000189731380-0x00000001897313A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF730C */, bool useObjectPool = false /* Metadata: 0x00AF7310 */) => default; // 0x0000000181366260-0x0000000181366470
	[BlackList] // 0x0000000189738B70-0x0000000189738BB0
	// [XID] // 0x0000000189738B70-0x0000000189738BB0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181365D90-0x0000000181366060
	// [XID] // 0x0000000189743570-0x0000000189743590
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181366C70-0x0000000181366E60
	// [XID] // 0x000000018974B200-0x000000018974B220
	public uint GetBlockSubStateValue(string blockName, uint defaultState) => default; // 0x0000000181367080-0x00000001813671D0
	[BlackList] // 0x00000001897522D0-0x0000000189752310
	// [XID] // 0x00000001897522D0-0x0000000189752310
	public virtual void AutoAllocTypeFields() {} // 0x0000000181366060-0x0000000181366100
	[BlackList] // 0x000000018975C890-0x000000018975C8D0
	// [XID] // 0x000000018975C890-0x000000018975C8D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181366100-0x00000001813661C0
	[BlackList] // 0x00000001897671E0-0x0000000189767220
	// [XID] // 0x00000001897671E0-0x0000000189767220
	public virtual void ReturnToObjectPool() {} // 0x00000001813671D0-0x0000000181367270
	[BlackList] // 0x00000001897718F0-0x0000000189771930
	// [XID] // 0x00000001897718F0-0x0000000189771930
	public virtual void OnPoolAllocated() {} // 0x0000000181366FE0-0x0000000181367080
	[BlackList] // 0x000000018977BE80-0x000000018977BEC0
	// [XID] // 0x000000018977BE80-0x000000018977BEC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181366F40-0x0000000181366FE0
}

