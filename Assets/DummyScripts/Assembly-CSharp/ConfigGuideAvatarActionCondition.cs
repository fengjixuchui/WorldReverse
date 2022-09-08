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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigGuideAvatarActionCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18238
{
	// Fields
	private GuideAvatarAction _action; // 0x20
	private Vector3 _curPos; // 0x24

	// Properties
	public GuideAvatarAction action { /* [XID] */ /* 0x0000000189951B90-0x0000000189951BB0 */ get => default; /* [XID] */ /* 0x0000000189959010-0x0000000189959030 */ private set {} } // 0x0000000182CE09A0-0x0000000182CE0A40 0x0000000182CE12B0-0x0000000182CE1360

	// Constructors
	public ConfigGuideAvatarActionCondition() {} // 0x0000000182CE2640-0x0000000182CE26A0

	// Methods
	// [XID] // 0x00000001899608A0-0x00000001899608C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182CE24B0-0x0000000182CE25A0
	// [XID] // 0x00000001899680C0-0x00000001899680E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182CE2180-0x0000000182CE2230
	// [XID] // 0x000000018996F4E0-0x000000018996F500
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9133 */) => default; // 0x0000000182CE1D90-0x0000000182CE1E70
	// [XID] // 0x0000000189977100-0x0000000189977120
	public override int GetHashNum() => default; // 0x0000000182CE0870-0x0000000182CE0940
	// [XID] // 0x000000018997E420-0x000000018997E440
	public override void InitEmpty() {} // 0x0000000182CE1820-0x0000000182CE18C0
	[BlackList] // 0x0000000189985EB0-0x0000000189985EF0
	// [XID] // 0x0000000189985EB0-0x0000000189985EF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182CE0F30-0x0000000182CE12B0
	// [XID] // 0x0000000189990BB0-0x0000000189990BD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182CE0100-0x0000000182CE0320
	[BlackList] // 0x0000000189998670-0x00000001899986B0
	// [XID] // 0x0000000189998670-0x00000001899986B0
	public static new ConfigGuideAvatarActionCondition ParseFromJson(JSONNode node) => default; // 0x0000000182CE1ED0-0x0000000182CE2120
	// [XID] // 0x00000001899A2F50-0x00000001899A2F70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9134 */, bool useObjectPool = false /* Metadata: 0x00AF9138 */) => default; // 0x0000000182CE1A90-0x0000000182CE1D90
	// [XID] // 0x00000001899AAA40-0x00000001899AAA60
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9139 */, bool useObjectPool = false /* Metadata: 0x00AF913D */) => default; // 0x0000000182CE0AC0-0x0000000182CE0CF0
	// [XID] // 0x00000001899B2430-0x00000001899B2450
	public static new ConfigGuideAvatarActionCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF913E */, bool useObjectPool = false /* Metadata: 0x00AF9142 */) => default; // 0x0000000182CE1360-0x0000000182CE1580
	[BlackList] // 0x00000001899B9750-0x00000001899B9790
	// [XID] // 0x00000001899B9750-0x00000001899B9790
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182CE0320-0x0000000182CE05F0
	// [XID] // 0x00000001899C4360-0x00000001899C4380
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182CE22B0-0x0000000182CE24B0
	[BlackList] // 0x00000001899CBAE0-0x00000001899CBB20
	// [XID] // 0x00000001899CBAE0-0x00000001899CBB20
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182CE19A0-0x0000000182CE1A90
	// [XID] // 0x00000001899D5FB0-0x00000001899D5FD0
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000182CE0DF0-0x0000000182CE0F30
	// [XID] // 0x00000001899DD420-0x00000001899DD440
	public override bool Ready(object body = null) => default; // 0x0000000182CE15F0-0x0000000182CE17A0
	[BlackList] // 0x00000001899E5120-0x00000001899E5160
	// [XID] // 0x00000001899E5120-0x00000001899E5160
	public override void AutoAllocTypeFields() {} // 0x0000000182CE05F0-0x0000000182CE0690
	[BlackList] // 0x00000001899EF3F0-0x00000001899EF430
	// [XID] // 0x00000001899EF3F0-0x00000001899EF430
	public override void AutoRecycleTypeFields() {} // 0x0000000182CE0690-0x0000000182CE0750
	[BlackList] // 0x00000001899F9C30-0x00000001899F9C70
	// [XID] // 0x00000001899F9C30-0x00000001899F9C70
	public override void ReturnToObjectPool() {} // 0x0000000182CE25A0-0x0000000182CE2640
}

