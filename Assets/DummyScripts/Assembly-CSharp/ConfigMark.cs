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

public struct ConfigMark : IEmptyInitable, IHashable // TypeDefIndex: 18564
{
	// Fields
	private MarkOrder _markLayer; // 0x00
	private bool _raycastTarget; // 0x04
	private MarkVisibilityType _radarVisibility; // 0x08
	private MarkVisibilityType _mapVisibility; // 0x0C
	private bool _showHeight; // 0x10

	// Properties
	public MarkOrder markLayer { /* [XID] */ /* 0x000000018971C5A0-0x000000018971C5C0 */ get => default; /* [XID] */ /* 0x0000000189723AD0-0x0000000189723AF0 */ private set {} } // 0x000000018353D940-0x000000018353DA00 0x000000018353CDD0-0x000000018353CE90
	public bool raycastTarget { /* [XID] */ /* 0x000000018972B1D0-0x000000018972B1F0 */ get => default; /* [XID] */ /* 0x00000001897329C0-0x00000001897329E0 */ private set {} } // 0x000000018353E0A0-0x000000018353E210 0x000000018353E6C0-0x000000018353E830
	public MarkVisibilityType radarVisibility { /* [XID] */ /* 0x000000018973A150-0x000000018973A170 */ get => default; /* [XID] */ /* 0x0000000189741CE0-0x0000000189741D00 */ private set {} } // 0x000000018353DFF0-0x000000018353E0A0 0x000000018353DF40-0x000000018353DFF0
	public MarkVisibilityType mapVisibility { /* [XID] */ /* 0x0000000189749600-0x0000000189749620 */ get => default; /* [XID] */ /* 0x0000000189750AE0-0x0000000189750B00 */ private set {} } // 0x000000018353CD10-0x000000018353CDD0 0x000000018353CE90-0x000000018353CF30
	public bool showHeight { /* [XID] */ /* 0x0000000189757EB0-0x0000000189757ED0 */ get => default; /* [XID] */ /* 0x000000018975F9F0-0x000000018975FA10 */ private set {} } // 0x000000018353C980-0x000000018353CC60 0x000000018353DB70-0x000000018353DE80

	// Methods
	// [IDTag] // 0x0000000189766F40-0x0000000189766F80
	// [XID] // 0x0000000189766F40-0x0000000189766F80
	public bool Equals(ConfigMark otherVal) => default; // 0x000000018353E210-0x000000018353E600
	// [IDTag] // 0x00000001897716B0-0x00000001897716F0
	// [XID] // 0x00000001897716B0-0x00000001897716F0
	public override bool Equals(object other) => default; // 0x000000018353D420-0x000000018353D7B0
	// [XID] // 0x000000018977BC60-0x000000018977BC80
	public override int GetHashCode() => default; // 0x000000018353D890-0x000000018353D940
	// [XID] // 0x0000000189783650-0x0000000189783670
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018353E830-0x000000018353E890
	// [XID] // 0x000000018978ACA0-0x000000018978ACC0
	public void InitEmpty() {} // 0x000000018353DAB0-0x000000018353DB70
	[BlackList] // 0x00000001897922C0-0x0000000189792300
	// [XID] // 0x00000001897922C0-0x0000000189792300
	public bool FromJson(JSONNode node) => default; // 0x000000018353D7B0-0x000000018353D890
	// [XID] // 0x000000018979D570-0x000000018979D590
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018353C8D0-0x000000018353C980
	// [XID] // 0x00000001897A4870-0x00000001897A4890
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA40D */, bool useObjectPool = false /* Metadata: 0x00AFA411 */) => default; // 0x000000018353DE80-0x000000018353DF40
	// [XID] // 0x00000001897ABE20-0x00000001897ABE40
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA412 */, bool useObjectPool = false /* Metadata: 0x00AFA416 */) => default; // 0x000000018353D300-0x000000018353D420
	[BlackList] // 0x00000001897B3D90-0x00000001897B3DD0
	// [XID] // 0x00000001897B3D90-0x00000001897B3DD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018353CC60-0x000000018353CD10
	// [XID] // 0x00000001897BEE50-0x00000001897BEE70
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018353E600-0x000000018353E6C0
}

