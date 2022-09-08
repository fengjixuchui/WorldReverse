/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct ConfigMarkIcon : IEmptyInitable, IHashable // TypeDefIndex: 18567
{
	// Fields
	private string _iconName; // 0x00
	private SimpleSafeUInt32 materialIndexRawNum; // 0x08
	private MarkType _markType; // 0x0C
	private string _effectName; // 0x10
	private bool _ignoreRaycastOnMap; // 0x18
	private string _title; // 0x20
	private string _desc; // 0x28
	private MarkOrder _markLayer; // 0x30
	private OverrideMarkVisibilityType _radarVisibility; // 0x34
	private OverrideMarkVisibilityType _mapVisibility; // 0x38
	private OverrideShowHeight _showHeight; // 0x3C
	private bool _showOnLockedArea; // 0x40

	// Properties
	public string iconName { /* [XID] */ /* 0x000000018989ECA0-0x000000018989ECC0 */ get => default; /* [XID] */ /* 0x00000001898A66E0-0x00000001898A6700 */ private set {} } // 0x00000001840B07C0-0x00000001840B1000 0x00000001840B1470-0x00000001840B15E0
	public uint materialIndex { /* [XID] */ /* 0x00000001898ADE10-0x00000001898ADE30 */ get => default; /* [XID] */ /* 0x00000001898B5270-0x00000001898B5290 */ private set {} } // 0x00000001840AE270-0x00000001840AE330 0x00000001840B02F0-0x00000001840B03A0
	public MarkType markType { /* [XID] */ /* 0x00000001898BCD40-0x00000001898BCD60 */ get => default; /* [XID] */ /* 0x00000001898C4460-0x00000001898C4480 */ private set {} } // 0x00000001840AF160-0x00000001840AF4F0 0x00000001840AE630-0x00000001840AE700
	public string effectName { /* [XID] */ /* 0x00000001898CBA50-0x00000001898CBA70 */ get => default; /* [XID] */ /* 0x00000001898D3270-0x00000001898D3290 */ private set {} } // 0x00000001840B1170-0x00000001840B13B0 0x00000001840AD2F0-0x00000001840ADE00
	public bool ignoreRaycastOnMap { /* [XID] */ /* 0x00000001898DABA0-0x00000001898DABC0 */ get => default; /* [XID] */ /* 0x00000001898E2A20-0x00000001898E2A40 */ private set {} } // 0x00000001840AF770-0x00000001840AF820 0x00000001840AE330-0x00000001840AE3E0
	public string title { /* [XID] */ /* 0x00000001898EA4F0-0x00000001898EA510 */ get => default; /* [XID] */ /* 0x00000001898F1C90-0x00000001898F1CB0 */ private set {} } // 0x00000001840B03A0-0x00000001840B06D0 0x00000001840AF5B0-0x00000001840AF6C0
	public string desc { /* [XID] */ /* 0x00000001898F9490-0x00000001898F94B0 */ get => default; /* [XID] */ /* 0x0000000189900DD0-0x0000000189900DF0 */ private set {} } // 0x00000001840AF820-0x00000001840AF8D0 0x00000001840B10C0-0x00000001840B1170
	public MarkOrder markLayer { /* [XID] */ /* 0x0000000189908570-0x0000000189908590 */ get => default; /* [XID] */ /* 0x000000018990FC10-0x000000018990FC30 */ private set {} } // 0x00000001840AF8D0-0x00000001840AF9C0 0x00000001840AE4A0-0x00000001840AE560
	public OverrideMarkVisibilityType radarVisibility { /* [XID] */ /* 0x0000000189917700-0x0000000189917720 */ get => default; /* [XID] */ /* 0x000000018991ED40-0x000000018991ED60 */ private set {} } // 0x00000001840B0200-0x00000001840B02F0 0x00000001840B0090-0x00000001840B0150
	public OverrideMarkVisibilityType mapVisibility { /* [XID] */ /* 0x00000001899266A0-0x00000001899266C0 */ get => default; /* [XID] */ /* 0x000000018992DD70-0x000000018992DD90 */ private set {} } // 0x00000001840AE3E0-0x00000001840AE4A0 0x00000001840AE560-0x00000001840AE630
	public OverrideShowHeight showHeight { /* [XID] */ /* 0x0000000189935170-0x0000000189935190 */ get => default; /* [XID] */ /* 0x000000018993CCF0-0x000000018993CD10 */ private set {} } // 0x00000001840ADEB0-0x00000001840AE190 0x00000001840AFCB0-0x00000001840AFFD0
	public bool showOnLockedArea { /* [XID] */ /* 0x0000000189944360-0x0000000189944380 */ get => default; /* [XID] */ /* 0x000000018994B960-0x000000018994B980 */ private set {} } // 0x00000001840B0150-0x00000001840B0200 0x00000001840AFBF0-0x00000001840AFCB0

	// Methods
	// [IDTag] // 0x0000000189953110-0x0000000189953150
	// [XID] // 0x0000000189953110-0x0000000189953150
	public bool Equals(ConfigMarkIcon otherVal) => default; // 0x00000001840B06D0-0x00000001840B07C0
	// [IDTag] // 0x000000018995DA30-0x000000018995DA70
	// [XID] // 0x000000018995DA30-0x000000018995DA70
	public override bool Equals(object other) => default; // 0x00000001840AF0B0-0x00000001840AF160
	// [XID] // 0x0000000189968080-0x00000001899680A0
	public override int GetHashCode() => default; // 0x00000001840AF6C0-0x00000001840AF770
	// [XID] // 0x000000018996F440-0x000000018996F460
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001840B13B0-0x00000001840B1470
	// [XID] // 0x00000001899770C0-0x00000001899770E0
	public void InitEmpty() {} // 0x00000001840AFB30-0x00000001840AFBF0
	[BlackList] // 0x000000018997E380-0x000000018997E3C0
	// [XID] // 0x000000018997E380-0x000000018997E3C0
	public bool FromJson(JSONNode node) => default; // 0x00000001840AF4F0-0x00000001840AF5B0
	// [XID] // 0x0000000189989360-0x0000000189989380
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001840ADE00-0x00000001840ADEB0
	// [XID] // 0x0000000189990B70-0x0000000189990B90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA42B */, bool useObjectPool = false /* Metadata: 0x00AFA42F */) => default; // 0x00000001840AFFD0-0x00000001840B0090
	// [XID] // 0x00000001899985F0-0x0000000189998610
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA430 */, bool useObjectPool = false /* Metadata: 0x00AFA434 */) => default; // 0x00000001840AEF60-0x00000001840AF0B0
	[BlackList] // 0x000000018999FE50-0x000000018999FE90
	// [XID] // 0x000000018999FE50-0x000000018999FE90
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001840AE190-0x00000001840AE270
	// [XID] // 0x00000001899AA9C0-0x00000001899AA9E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001840B1000-0x00000001840B10C0
}

