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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class GadgetExcelConfig : EntityExcelConfig, IAutoAllocRecycle // TypeDefIndex: 15637
{
	// Fields
	protected EntityType _type; // 0x48
	protected string _jsonName; // 0x50
	protected bool _hasMove; // 0x58
	protected bool _hasAudio; // 0x59
	protected bool _isEquip; // 0x5A
	protected bool _isInteractive; // 0x5B
	protected VisionLevelType _visionLevel; // 0x5C
	protected string[] _tags; // 0x60
	protected byte _clientScriptHashPre; // 0x68
	protected uint _clientScriptHashSuffix; // 0x6C
	protected string _itemJsonName; // 0x70
	protected byte _itemPrefabPathHashPre; // 0x78
	protected uint _itemPrefabPathHashSuffix; // 0x7C
	protected SimpleSafeUInt32 radarHintIDRawNum; // 0x80
	protected string _inteeIconName; // 0x88
	protected SimpleSafeUInt32 landSoundIDRawNum; // 0x90
	protected SimpleSafeUInt32 mpPropIDRawNum; // 0x94
	protected uint _interactNameTextMapHash; // 0x98

	// Properties
	public EntityType type { /* [XID] */ /* 0x00000001899149E0-0x0000000189914A00 */ get => default; /* [XID] */ /* 0x000000018991C5E0-0x000000018991C600 */ protected set {} } // 0x00000001854B0740-0x00000001854B07E0 0x00000001854B0310-0x00000001854B03C0
	public string jsonName { /* [XID] */ /* 0x00000001895EFE90-0x00000001895EFEB0 */ get => default; /* [XID] */ /* 0x000000018992B3A0-0x000000018992B3C0 */ protected set {} } // 0x00000001854B0130-0x00000001854B01D0 0x00000001854AE800-0x00000001854AE8B0
	public bool hasMove { /* [XID] */ /* 0x0000000189BC51A0-0x0000000189BC51C0 */ get => default; /* [XID] */ /* 0x000000018993A4B0-0x000000018993A4D0 */ protected set {} } // 0x00000001854B0880-0x00000001854B0920 0x00000001854ABF60-0x00000001854AC010
	public bool hasAudio { /* [XID] */ /* 0x00000001899414E0-0x0000000189941500 */ get => default; /* [XID] */ /* 0x0000000189949040-0x0000000189949060 */ protected set {} } // 0x00000001854AE370-0x00000001854AE410 0x00000001854AEA90-0x00000001854AEB40
	public bool isEquip { /* [XID] */ /* 0x0000000189950830-0x0000000189950850 */ get => default; /* [XID] */ /* 0x0000000189957E20-0x0000000189957E40 */ protected set {} } // 0x00000001854AC200-0x00000001854AC2A0 0x00000001854AE4E0-0x00000001854AE590
	public bool isInteractive { /* [XID] */ /* 0x000000018996BB20-0x000000018996BB40 */ get => default; /* [XID] */ /* 0x0000000189966F50-0x0000000189966F70 */ protected set {} } // 0x00000001854AE2D0-0x00000001854AE370 0x00000001854ABEB0-0x00000001854ABF60
	public VisionLevelType visionLevel { /* [XID] */ /* 0x000000018996E2A0-0x000000018996E2C0 */ get => default; /* [XID] */ /* 0x0000000189975E30-0x0000000189975E50 */ protected set {} } // 0x00000001854B0920-0x00000001854B09C0 0x00000001854B03C0-0x00000001854B0470
	public string[] tags { /* [XID] */ /* 0x000000018997CF70-0x000000018997CF90 */ get => default; /* [XID] */ /* 0x0000000189984B90-0x0000000189984BB0 */ protected set {} } // 0x00000001854AE590-0x00000001854AE630 0x00000001854AC010-0x00000001854AC0C0
	public byte clientScriptHashPre { /* [XID] */ /* 0x0000000189A5CAA0-0x0000000189A5CAC0 */ get => default; /* [XID] */ /* 0x00000001899944D0-0x00000001899944F0 */ protected set {} } // 0x00000001854AE760-0x00000001854AE800 0x00000001854B0080-0x00000001854B0130
	public uint clientScriptHashSuffix { /* [XID] */ /* 0x0000000189A64410-0x0000000189A64430 */ get => default; /* [XID] */ /* 0x00000001899A3510-0x00000001899A3530 */ protected set {} } // 0x00000001854AE630-0x00000001854AE6D0 0x00000001854AFFD0-0x00000001854B0080
	public ulong clientScriptHash { /* [XID] */ /* 0x00000001899AB000-0x00000001899AB020 */ get => default; } // 0x00000001854AE910-0x00000001854AE9E0 
	public string itemJsonName { /* [XID] */ /* 0x00000001899B2A70-0x00000001899B2A90 */ get => default; /* [XID] */ /* 0x00000001899B9BD0-0x00000001899B9BF0 */ protected set {} } // 0x00000001854B07E0-0x00000001854B0880 0x00000001854ABA00-0x00000001854ABAB0
	public byte itemPrefabPathHashPre { /* [XID] */ /* 0x0000000189BC3CB0-0x0000000189BC3CD0 */ get => default; /* [XID] */ /* 0x00000001899C8C60-0x00000001899C8C80 */ protected set {} } // 0x00000001854AC2A0-0x00000001854AC340 0x00000001854B0690-0x00000001854B0740
	public uint itemPrefabPathHashSuffix { /* [XID] */ /* 0x00000001899D0690-0x00000001899D06B0 */ get => default; /* [XID] */ /* 0x00000001899D7B70-0x00000001899D7B90 */ protected set {} } // 0x00000001854B0470-0x00000001854B0510 0x00000001854AC340-0x00000001854AC3F0
	public ulong itemPrefabPathHash { /* [XID] */ /* 0x0000000189B886E0-0x0000000189B88700 */ get => default; } // 0x00000001854AB860-0x00000001854AB930 
	public uint radarHintID { /* [XID] */ /* 0x0000000189AD5690-0x0000000189AD56B0 */ get => default; /* [XID] */ /* 0x00000001899EE1C0-0x00000001899EE1E0 */ protected set {} } // 0x00000001854AB790-0x00000001854AB860 0x00000001854AC120-0x00000001854AC200
	public string inteeIconName { /* [XID] */ /* 0x00000001899F59D0-0x00000001899F59F0 */ get => default; /* [XID] */ /* 0x00000001899FD150-0x00000001899FD170 */ protected set {} } // 0x00000001854AE9E0-0x00000001854AEA90 0x00000001854AB6E0-0x00000001854AB790
	public uint landSoundID { /* [XID] */ /* 0x0000000189A86B00-0x0000000189A86B20 */ get => default; /* [XID] */ /* 0x0000000189A0BE30-0x0000000189A0BE50 */ protected set {} } // 0x00000001854AB930-0x00000001854ABA00 0x00000001854B0230-0x00000001854B0310
	public uint mpPropID { /* [XID] */ /* 0x0000000189A136C0-0x0000000189A136E0 */ get => default; /* [XID] */ /* 0x0000000189A1A810-0x0000000189A1A830 */ protected set {} } // 0x00000001854AE410-0x00000001854AE4E0 0x00000001854B05B0-0x00000001854B0690
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint interactNameTextMapHash { /* [XID] */ /* 0x0000000189A22090-0x0000000189A220B0 */ get => default; /* [XID] */ /* 0x0000000189A29540-0x0000000189A29560 */ protected set {} } // 0x00000001854B0510-0x00000001854B05B0 0x00000001854AFF20-0x00000001854AFFD0
	public string interactName { /* [XID] */ /* 0x0000000189A30A50-0x0000000189A30A70 */ get => default; } // 0x00000001854ABC90-0x00000001854ABE10 

	// Constructors
	public GadgetExcelConfig() {} // 0x00000001854B0A60-0x00000001854B0AC0

	// Methods
	// [IDTag] // 0x0000000189A384D0-0x0000000189A38510
	// [XID] // 0x0000000189A384D0-0x0000000189A38510
	public virtual bool ParseFromLine(string line) => default; // 0x00000001854AD390-0x00000001854AE2D0
	// [IDTag] // 0x0000000189A42CF0-0x0000000189A42D30
	// [XID] // 0x0000000189A42CF0-0x0000000189A42D30
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001854AC3F0-0x00000001854AD390
	// [XID] // 0x0000000189A4D300-0x0000000189A4D320
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2152 */, bool useObjectPool = false /* Metadata: 0x00AF2156 */) => default; // 0x00000001854AEB40-0x00000001854AFF20
	[BlackList] // 0x0000000189A54A50-0x0000000189A54A90
	// [XID] // 0x0000000189A54A50-0x0000000189A54A90
	public override void AutoAllocTypeFields() {} // 0x00000001854ABAB0-0x00000001854ABB50
	[BlackList] // 0x0000000189A5F3B0-0x0000000189A5F3F0
	// [XID] // 0x0000000189A5F3B0-0x0000000189A5F3F0
	public override void AutoRecycleTypeFields() {} // 0x00000001854ABB50-0x00000001854ABC90
	[BlackList] // 0x0000000189A69F50-0x0000000189A69F90
	// [XID] // 0x0000000189A69F50-0x0000000189A69F90
	public override void ReturnToObjectPool() {} // 0x00000001854B09C0-0x00000001854B0A60
}

