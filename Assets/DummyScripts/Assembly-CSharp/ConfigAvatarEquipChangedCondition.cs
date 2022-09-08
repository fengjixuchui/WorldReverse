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
public sealed class ConfigAvatarEquipChangedCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18198
{
	// Fields
	private SimpleSafeUInt32 configIDRawNum; // 0x20
	private NotifyTypes[] _curNotifyList; // 0x28
	private bool isReady; // 0x30

	// Properties
	public uint configID { /* [XID] */ /* 0x00000001897E8C10-0x00000001897E8C30 */ get => default; /* [XID] */ /* 0x00000001897F0820-0x00000001897F0840 */ private set {} } // 0x0000000185190010-0x00000001851900E0 0x000000018518F8F0-0x000000018518F9D0

	// Constructors
	public ConfigAvatarEquipChangedCondition() {} // 0x0000000185191B70-0x0000000185191C30

	// Methods
	// [XID] // 0x00000001897F7F60-0x00000001897F7F80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851919E0-0x0000000185191AD0
	// [XID] // 0x00000001897FF5F0-0x00000001897FF610
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185191680-0x0000000185191730
	// [XID] // 0x0000000189806D50-0x0000000189806D70
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF8FF3 */) => default; // 0x00000001851912B0-0x00000001851913A0
	// [XID] // 0x000000018980E410-0x000000018980E430
	public override int GetHashNum() => default; // 0x000000018518FF40-0x0000000185190010
	// [XID] // 0x0000000189815B30-0x0000000189815B50
	public override void InitEmpty() {} // 0x0000000185190D10-0x0000000185190DE0
	[BlackList] // 0x000000018981D590-0x000000018981D5D0
	// [XID] // 0x000000018981D590-0x000000018981D5D0
	public override bool FromJson(JSONNode node) => default; // 0x00000001851905F0-0x0000000185190970
	// [XID] // 0x0000000189827CC0-0x0000000189827CE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018518F690-0x000000018518F8F0
	[BlackList] // 0x000000018982F000-0x000000018982F040
	// [XID] // 0x000000018982F000-0x000000018982F040
	public static new ConfigAvatarEquipChangedCondition ParseFromJson(JSONNode node) => default; // 0x0000000185191400-0x0000000185191620
	// [XID] // 0x0000000189839700-0x0000000189839720
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FF4 */, bool useObjectPool = false /* Metadata: 0x00AF8FF8 */) => default; // 0x0000000185190FB0-0x00000001851912B0
	// [XID] // 0x0000000189840CA0-0x0000000189840CC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FF9 */, bool useObjectPool = false /* Metadata: 0x00AF8FFD */) => default; // 0x00000001851901C0-0x0000000185190430
	// [XID] // 0x0000000189848100-0x0000000189848120
	public static new ConfigAvatarEquipChangedCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8FFE */, bool useObjectPool = false /* Metadata: 0x00AF9002 */) => default; // 0x0000000185190970-0x0000000185190B60
	[BlackList] // 0x000000018984F860-0x000000018984F8A0
	// [XID] // 0x000000018984F860-0x000000018984F8A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018518F9D0-0x000000018518FCA0
	// [XID] // 0x0000000189859E10-0x0000000189859E30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851917B0-0x00000001851919E0
	[BlackList] // 0x0000000189860EF0-0x0000000189860F30
	// [XID] // 0x0000000189860EF0-0x0000000189860F30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185190EC0-0x0000000185190FB0
	// [XID] // 0x000000018986B7A0-0x000000018986B7C0
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000185190530-0x00000001851905F0
	// [XID] // 0x0000000189872AB0-0x0000000189872AD0
	public override bool Ready(object body = null) => default; // 0x0000000185190BD0-0x0000000185190C90
	[BlackList] // 0x000000018987A730-0x000000018987A770
	// [XID] // 0x000000018987A730-0x000000018987A770
	public override void AutoAllocTypeFields() {} // 0x000000018518FCA0-0x000000018518FD40
	[BlackList] // 0x0000000189884570-0x00000001898845B0
	// [XID] // 0x0000000189884570-0x00000001898845B0
	public override void AutoRecycleTypeFields() {} // 0x000000018518FD40-0x000000018518FE20
	[BlackList] // 0x000000018988EAC0-0x000000018988EB00
	// [XID] // 0x000000018988EAC0-0x000000018988EB00
	public override void ReturnToObjectPool() {} // 0x0000000185191AD0-0x0000000185191B70
}

