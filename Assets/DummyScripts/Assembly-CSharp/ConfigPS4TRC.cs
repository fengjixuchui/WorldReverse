/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
public class ConfigPS4TRC : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18808
{
	// Fields
	private SimpleSafeInt32 defaultAgeRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigContentRestriction[] _contentRestrictionList; // 0x18

	// Properties
	public int defaultAge { /* [XID] */ /* 0x0000000189963960-0x0000000189963980 */ get => default; /* [XID] */ /* 0x000000018996AED0-0x000000018996AEF0 */ private set {} } // 0x0000000184242980-0x0000000184242A50 0x00000001842435F0-0x00000001842436D0
	public ConfigContentRestriction[] contentRestrictionList { /* [XID] */ /* 0x0000000189972A10-0x0000000189972A30 */ get => default; /* [XID] */ /* 0x000000018997A230-0x000000018997A250 */ private set {} } // 0x0000000184243250-0x00000001842432F0 0x00000001842430A0-0x0000000184243150

	// Constructors
	public ConfigPS4TRC() {} // 0x0000000184243C60-0x0000000184243CC0

	// Methods
	// [XID] // 0x00000001899819E0-0x0000000189981A00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184243970-0x0000000184243A80
	// [XID] // 0x00000001899892E0-0x0000000189989300
	public void InitEmpty() {} // 0x0000000184243150-0x0000000184243250
	[BlackList] // 0x0000000189990AB0-0x0000000189990AF0
	// [XID] // 0x0000000189990AB0-0x0000000189990AF0
	public bool FromJson(JSONNode node) => default; // 0x0000000184242D20-0x00000001842430A0
	// [XID] // 0x000000018999B760-0x000000018999B780
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184242230-0x0000000184242530
	// [XID] // 0x00000001899A2ED0-0x00000001899A2EF0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD61 */, bool useObjectPool = false /* Metadata: 0x00AFAD65 */) => default; // 0x00000001842432F0-0x00000001842435F0
	// [XID] // 0x00000001899AA960-0x00000001899AA980
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD66 */, bool useObjectPool = false /* Metadata: 0x00AFAD6A */) => default; // 0x0000000184242A50-0x0000000184242D20
	[BlackList] // 0x00000001899B2330-0x00000001899B2370
	// [XID] // 0x00000001899B2330-0x00000001899B2370
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184242530-0x0000000184242800
	// [XID] // 0x00000001899BC7F0-0x00000001899BC810
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842436D0-0x0000000184243970
	[BlackList] // 0x00000001899C41E0-0x00000001899C4220
	// [XID] // 0x00000001899C41E0-0x00000001899C4220
	public virtual void AutoAllocTypeFields() {} // 0x0000000184242800-0x00000001842428A0
	[BlackList] // 0x00000001899CE800-0x00000001899CE840
	// [XID] // 0x00000001899CE800-0x00000001899CE840
	public virtual void AutoRecycleTypeFields() {} // 0x00000001842428A0-0x0000000184242980
	[BlackList] // 0x00000001899D8D70-0x00000001899D8DB0
	// [XID] // 0x00000001899D8D70-0x00000001899D8DB0
	public virtual void ReturnToObjectPool() {} // 0x0000000184243BC0-0x0000000184243C60
	[BlackList] // 0x00000001899E3690-0x00000001899E36D0
	// [XID] // 0x00000001899E3690-0x00000001899E36D0
	public virtual void OnPoolAllocated() {} // 0x0000000184243B20-0x0000000184243BC0
	[BlackList] // 0x00000001899EDC40-0x00000001899EDC80
	// [XID] // 0x00000001899EDC40-0x00000001899EDC80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184243A80-0x0000000184243B20
}

