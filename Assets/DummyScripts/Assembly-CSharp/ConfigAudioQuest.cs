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
public class ConfigAudioQuest : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17617
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAudioQuestOps[] _quests; // 0x10
	private Dictionary<uint, ConfigAudioQuestOps> _operationIndex; // 0x18

	// Properties
	public ConfigAudioQuestOps[] quests { /* [XID] */ /* 0x0000000189960A00-0x0000000189960A20 */ get => default; /* [XID] */ /* 0x00000001899681C0-0x00000001899681E0 */ private set {} } // 0x000000018496E930-0x000000018496E9D0 0x000000018496E2F0-0x000000018496E3A0

	// Constructors
	public ConfigAudioQuest() {} // 0x000000018496F4B0-0x000000018496F510

	// Methods
	// [XID] // 0x000000018996F5C0-0x000000018996F5E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018496F1F0-0x000000018496F2D0
	// [XID] // 0x0000000189977260-0x0000000189977280
	public void InitEmpty() {} // 0x000000018496E9D0-0x000000018496EAA0
	[BlackList] // 0x000000018997E5E0-0x000000018997E620
	// [XID] // 0x000000018997E5E0-0x000000018997E620
	public bool FromJson(JSONNode node) => default; // 0x000000018496E5B0-0x000000018496E930
	// [XID] // 0x0000000189989580-0x00000001899895A0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018496DCF0-0x000000018496DED0
	// [XID] // 0x0000000189990D90-0x0000000189990DB0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74E3 */, bool useObjectPool = false /* Metadata: 0x00AF74E7 */) => default; // 0x000000018496EAA0-0x000000018496EDA0
	// [XID] // 0x0000000189998850-0x0000000189998870
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF74E8 */, bool useObjectPool = false /* Metadata: 0x00AF74EC */) => default; // 0x000000018496E3A0-0x000000018496E5B0
	[BlackList] // 0x00000001899A0130-0x00000001899A0170
	// [XID] // 0x00000001899A0130-0x00000001899A0170
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018496DED0-0x000000018496E1A0
	// [XID] // 0x00000001899AAB60-0x00000001899AAB80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018496F000-0x000000018496F1F0
	// [XID] // 0x00000001899B24F0-0x00000001899B2510
	public void BuildOperationIndex() {} // 0x000000018496EE90-0x000000018496F000
	// [XID] // 0x00000001899B9850-0x00000001899B9870
	public ConfigAudioQuestOps GetConfigOpsById(uint questId) => default; // 0x000000018496EDA0-0x000000018496EE90
	[BlackList] // 0x00000001899C1370-0x00000001899C13B0
	// [XID] // 0x00000001899C1370-0x00000001899C13B0
	public virtual void AutoAllocTypeFields() {} // 0x000000018496E1A0-0x000000018496E240
	[BlackList] // 0x00000001899CBCC0-0x00000001899CBD00
	// [XID] // 0x00000001899CBCC0-0x00000001899CBD00
	public virtual void AutoRecycleTypeFields() {} // 0x000000018496E240-0x000000018496E2F0
	[BlackList] // 0x00000001899D6090-0x00000001899D60D0
	// [XID] // 0x00000001899D6090-0x00000001899D60D0
	public virtual void ReturnToObjectPool() {} // 0x000000018496F410-0x000000018496F4B0
	[BlackList] // 0x00000001899E0500-0x00000001899E0540
	// [XID] // 0x00000001899E0500-0x00000001899E0540
	public virtual void OnPoolAllocated() {} // 0x000000018496F370-0x000000018496F410
	[BlackList] // 0x00000001899EABC0-0x00000001899EAC00
	// [XID] // 0x00000001899EABC0-0x00000001899EAC00
	public virtual void OnBeforePoolRecycled() {} // 0x000000018496F2D0-0x000000018496F370
}

