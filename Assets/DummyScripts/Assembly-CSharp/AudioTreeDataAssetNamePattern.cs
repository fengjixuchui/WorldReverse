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

public struct AudioTreeDataAssetNamePattern : IEmptyInitable, IHashable // TypeDefIndex: 17548
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x00
	private string _pattern; // 0x08

	// Properties
	public uint sceneId { /* [XID] */ /* 0x0000000189AA33E0-0x0000000189AA3400 */ get => default; /* [XID] */ /* 0x0000000189723C50-0x0000000189723C70 */ private set {} } // 0x0000000183938BF0-0x0000000183938F00 0x0000000183938FE0-0x0000000183939110
	public string pattern { /* [XID] */ /* 0x0000000189A50B20-0x0000000189A50B40 */ get => default; /* [XID] */ /* 0x0000000189732BA0-0x0000000189732BC0 */ private set {} } // 0x0000000183937A70-0x0000000183937D80 0x00000001839391E0-0x0000000183939460

	// Methods
	// [IDTag] // 0x000000018973A290-0x000000018973A2D0
	// [XID] // 0x000000018973A290-0x000000018973A2D0
	public bool Equals(AudioTreeDataAssetNamePattern otherVal) => default; // 0x0000000183939110-0x00000001839391E0
	// [IDTag] // 0x0000000189744B90-0x0000000189744BD0
	// [XID] // 0x0000000189744B90-0x0000000189744BD0
	public override bool Equals(object other) => default; // 0x00000001839384E0-0x0000000183938870
	// [XID] // 0x000000018974F4F0-0x000000018974F510
	public override int GetHashCode() => default; // 0x0000000183938950-0x0000000183938A00
	// [XID] // 0x0000000189756B80-0x0000000189756BA0
	public void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183939580-0x0000000183939590
	// [XID] // 0x000000018975E010-0x000000018975E030
	public void InitEmpty() {} // 0x0000000183938B10-0x0000000183938BF0
	[BlackList] // 0x00000001897657B0-0x00000001897657F0
	// [XID] // 0x00000001897657B0-0x00000001897657F0
	public bool FromJson(JSONNode node) => default; // 0x0000000183938870-0x0000000183938950
	// [XID] // 0x000000018976FE50-0x000000018976FE70
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183937D80-0x0000000183938060
	// [XID] // 0x0000000189777650-0x0000000189777670
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF727F */, bool useObjectPool = false /* Metadata: 0x00AF7283 */) => default; // 0x0000000183938F00-0x0000000183938FE0
	// [XID] // 0x000000018977ED40-0x000000018977ED60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7284 */, bool useObjectPool = false /* Metadata: 0x00AF7288 */) => default; // 0x00000001839383D0-0x00000001839384E0
	[BlackList] // 0x0000000189786780-0x00000001897867C0
	// [XID] // 0x0000000189786780-0x00000001897867C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183938060-0x0000000183938100
	// [XID] // 0x0000000189790BB0-0x0000000189790BD0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183939460-0x0000000183939580
}

