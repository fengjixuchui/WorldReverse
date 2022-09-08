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
public class DebugBlletinInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14932
{
	// Fields
	private SimpleSafeUInt32 idRawNum; // 0x10
	private SimpleSafeUInt32 board_idRawNum; // 0x14
	private string _content; // 0x18
	private string _author; // 0x20
	private string _create_time; // 0x28

	// Properties
	public uint id { /* [XID] */ /* 0x00000001898BA7C0-0x00000001898BA7E0 */ get => default; /* [XID] */ /* 0x00000001898C1940-0x00000001898C1960 */ private set {} } // 0x00000001865729D0-0x0000000186572AA0 0x00000001865718D0-0x00000001865719B0
	public uint board_id { /* [XID] */ /* 0x00000001898C92C0-0x00000001898C92E0 */ get => default; /* [XID] */ /* 0x00000001898D0B20-0x00000001898D0B40 */ private set {} } // 0x0000000186572230-0x0000000186572300 0x0000000186570AE0-0x0000000186570BC0
	public string content { /* [XID] */ /* 0x00000001898D8200-0x00000001898D8220 */ get => default; /* [XID] */ /* 0x00000001898E00C0-0x00000001898E00E0 */ private set {} } // 0x0000000186571E80-0x0000000186571F20 0x0000000186572AA0-0x0000000186572B50
	public string author { /* [XID] */ /* 0x00000001898E7B70-0x00000001898E7B90 */ get => default; /* [XID] */ /* 0x00000001898EF240-0x00000001898EF260 */ private set {} } // 0x0000000186571780-0x0000000186571820 0x0000000186571820-0x00000001865718D0
	public string create_time { /* [XID] */ /* 0x00000001898F6B00-0x00000001898F6B20 */ get => default; /* [XID] */ /* 0x00000001898FE220-0x00000001898FE240 */ private set {} } // 0x0000000186571060-0x0000000186571100 0x000000018656FF50-0x0000000186570000

	// Constructors
	public DebugBlletinInfo(string content, string author) {} // 0x0000000186572C50-0x0000000186572CF0
	public DebugBlletinInfo() {} // 0x0000000186572BF0-0x0000000186572C50

	// Methods
	// [XID] // 0x0000000189905AE0-0x0000000189905B00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000186572730-0x0000000186572890
	// [XID] // 0x000000018990D390-0x000000018990D3B0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000186572120-0x0000000186572230
	// [XID] // 0x0000000189914B00-0x0000000189914B20
	public virtual DebugBlletinInfo Clone(bool useObjectPool = false /* Metadata: 0x00AEFA86 */) => default; // 0x0000000186571DA0-0x0000000186571E80
	// [XID] // 0x000000018991C840-0x000000018991C860
	public virtual int GetHashNum() => default; // 0x0000000186570A10-0x0000000186570AE0
	// [XID] // 0x0000000189923F40-0x0000000189923F60
	public virtual void InitEmpty() {} // 0x0000000186571650-0x0000000186571780
	[BlackList] // 0x000000018992B460-0x000000018992B4A0
	// [XID] // 0x000000018992B460-0x000000018992B4A0
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000186571100-0x0000000186571480
	// [XID] // 0x00000001899357D0-0x00000001899357F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000186570000-0x00000001865705B0
	[BlackList] // 0x000000018993D330-0x000000018993D370
	// [XID] // 0x000000018993D330-0x000000018993D370
	public static DebugBlletinInfo ParseFromJson(JSONNode node) => default; // 0x0000000186571F20-0x0000000186572120
	// [XID] // 0x00000001899476C0-0x00000001899476E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA87 */, bool useObjectPool = false /* Metadata: 0x00AEFA8B */) => default; // 0x0000000186571AA0-0x0000000186571DA0
	// [XID] // 0x000000018994EEE0-0x000000018994EF00
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA8C */, bool useObjectPool = false /* Metadata: 0x00AEFA90 */) => default; // 0x0000000186570BC0-0x0000000186571060
	// [XID] // 0x0000000189956560-0x0000000189956580
	public static DebugBlletinInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFA91 */, bool useObjectPool = false /* Metadata: 0x00AEFA95 */) => default; // 0x0000000186571480-0x0000000186571650
	[BlackList] // 0x000000018995DF70-0x000000018995DFB0
	// [XID] // 0x000000018995DF70-0x000000018995DFB0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001865705B0-0x0000000186570880
	// [XID] // 0x00000001899686A0-0x00000001899686C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000186572300-0x0000000186572730
	[BlackList] // 0x000000018996FBA0-0x000000018996FBE0
	// [XID] // 0x000000018996FBA0-0x000000018996FBE0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001865719B0-0x0000000186571AA0
	[BlackList] // 0x000000018997A8B0-0x000000018997A8F0
	// [XID] // 0x000000018997A8B0-0x000000018997A8F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000186570880-0x0000000186570920
	[BlackList] // 0x0000000189984C90-0x0000000189984CD0
	// [XID] // 0x0000000189984C90-0x0000000189984CD0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000186570920-0x0000000186570A10
	[BlackList] // 0x000000018998F900-0x000000018998F940
	// [XID] // 0x000000018998F900-0x000000018998F940
	public virtual void ReturnToObjectPool() {} // 0x0000000186572B50-0x0000000186572BF0
	[BlackList] // 0x000000018999A870-0x000000018999A8B0
	// [XID] // 0x000000018999A870-0x000000018999A8B0
	public virtual void OnPoolAllocated() {} // 0x0000000186572930-0x00000001865729D0
	[BlackList] // 0x00000001899A4F70-0x00000001899A4FB0
	// [XID] // 0x00000001899A4F70-0x00000001899A4FB0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000186572890-0x0000000186572930
}

