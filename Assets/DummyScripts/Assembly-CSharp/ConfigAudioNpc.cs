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
public class ConfigAudioNpc : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17602
{
	// Fields
	private string _defaultVocalBoneName; // 0x10

	// Properties
	public string defaultVocalBoneName { /* [XID] */ /* 0x0000000189BC03E0-0x0000000189BC0400 */ get => default; /* [XID] */ /* 0x00000001899EC5D0-0x00000001899EC5F0 */ private set {} } // 0x0000000181F02980-0x0000000181F02A20 0x0000000181F02A20-0x0000000181F02AD0

	// Constructors
	public ConfigAudioNpc() {} // 0x0000000181F02F40-0x0000000181F02FA0

	// Methods
	// [XID] // 0x00000001899F4330-0x00000001899F4350
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181F02C80-0x0000000181F02D60
	// [XID] // 0x00000001899FB8B0-0x00000001899FB8D0
	public void InitEmpty() {} // 0x0000000181F025B0-0x0000000181F02680
	[BlackList] // 0x0000000189A02B90-0x0000000189A02BD0
	// [XID] // 0x0000000189A02B90-0x0000000189A02BD0
	public bool FromJson(JSONNode node) => default; // 0x0000000181F02230-0x0000000181F025B0
	// [XID] // 0x0000000189A0D240-0x0000000189A0D260
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181F01A30-0x0000000181F01C10
	// [XID] // 0x0000000189A14AE0-0x0000000189A14B00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7463 */, bool useObjectPool = false /* Metadata: 0x00AF7467 */) => default; // 0x0000000181F02680-0x0000000181F02980
	// [XID] // 0x0000000189A1BD30-0x0000000189A1BD50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7468 */, bool useObjectPool = false /* Metadata: 0x00AF746C */) => default; // 0x0000000181F02020-0x0000000181F02230
	[BlackList] // 0x0000000189A23520-0x0000000189A23560
	// [XID] // 0x0000000189A23520-0x0000000189A23560
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181F01C10-0x0000000181F01EE0
	// [XID] // 0x0000000189A2D610-0x0000000189A2D630
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181F02AD0-0x0000000181F02C80
	[BlackList] // 0x0000000189A350D0-0x0000000189A35110
	// [XID] // 0x0000000189A350D0-0x0000000189A35110
	public virtual void AutoAllocTypeFields() {} // 0x0000000181F01EE0-0x0000000181F01F80
	[BlackList] // 0x0000000189A3F820-0x0000000189A3F860
	// [XID] // 0x0000000189A3F820-0x0000000189A3F860
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181F01F80-0x0000000181F02020
	[BlackList] // 0x0000000189A49CE0-0x0000000189A49D20
	// [XID] // 0x0000000189A49CE0-0x0000000189A49D20
	public virtual void ReturnToObjectPool() {} // 0x0000000181F02EA0-0x0000000181F02F40
	[BlackList] // 0x0000000189A54590-0x0000000189A545D0
	// [XID] // 0x0000000189A54590-0x0000000189A545D0
	public virtual void OnPoolAllocated() {} // 0x0000000181F02E00-0x0000000181F02EA0
	[BlackList] // 0x0000000189A5F010-0x0000000189A5F050
	// [XID] // 0x0000000189A5F010-0x0000000189A5F050
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181F02D60-0x0000000181F02E00
}

