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
public class ConfigGuideTeamMemberCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18212
{
	// Fields
	private SimpleSafeUInt32 configIDRawNum; // 0x20
	private bool _hasMember; // 0x24
	private NotifyTypes[] _curNotifyList; // 0x28

	// Properties
	public uint configID { /* [XID] */ /* 0x00000001897496A0-0x00000001897496C0 */ get => default; /* [XID] */ /* 0x0000000189750B60-0x0000000189750B80 */ private set {} } // 0x00000001849E44D0-0x00000001849E45A0 0x00000001849E3DB0-0x00000001849E3E90
	public bool hasMember { /* [XID] */ /* 0x0000000189757F10-0x0000000189757F30 */ get => default; /* [XID] */ /* 0x000000018975FAD0-0x000000018975FAF0 */ private set {} } // 0x00000001849E39F0-0x00000001849E3A90 0x00000001849E6280-0x00000001849E6330

	// Constructors
	public ConfigGuideTeamMemberCondition() {} // 0x00000001849E6740-0x00000001849E6800

	// Methods
	// [XID] // 0x0000000189767040-0x0000000189767060
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001849E6330-0x00000001849E6440
	// [XID] // 0x000000018976E5A0-0x000000018976E5C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001849E5E90-0x00000001849E5F40
	// [XID] // 0x0000000189775F80-0x0000000189775FA0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9063 */) => default; // 0x00000001849E5840-0x00000001849E5920
	// [XID] // 0x000000018977D620-0x000000018977D640
	public override int GetHashNum() => default; // 0x00000001849E4400-0x00000001849E44D0
	// [XID] // 0x0000000189784EC0-0x0000000189784EE0
	public override void InitEmpty() {} // 0x00000001849E52A0-0x00000001849E5370
	[BlackList] // 0x000000018978C3D0-0x000000018978C410
	// [XID] // 0x000000018978C3D0-0x000000018978C410
	public override bool FromJson(JSONNode node) => default; // 0x00000001849E4B20-0x00000001849E4EA0
	// [XID] // 0x0000000189796A70-0x0000000189796A90
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001849E3A90-0x00000001849E3DB0
	[BlackList] // 0x000000018979EBD0-0x000000018979EC10
	// [XID] // 0x000000018979EBD0-0x000000018979EC10
	public static new ConfigGuideTeamMemberCondition ParseFromJson(JSONNode node) => default; // 0x00000001849E5BE0-0x00000001849E5E30
	// [XID] // 0x00000001897A9040-0x00000001897A9060
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9064 */, bool useObjectPool = false /* Metadata: 0x00AF9068 */) => default; // 0x00000001849E5540-0x00000001849E5840
	// [XID] // 0x00000001897B08E0-0x00000001897B0900
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9069 */, bool useObjectPool = false /* Metadata: 0x00AF906D */) => default; // 0x00000001849E4680-0x00000001849E4960
	// [XID] // 0x00000001897B85A0-0x00000001897B85C0
	public static new ConfigGuideTeamMemberCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF906E */, bool useObjectPool = false /* Metadata: 0x00AF9072 */) => default; // 0x00000001849E4EA0-0x00000001849E50C0
	[BlackList] // 0x00000001897C0640-0x00000001897C0680
	// [XID] // 0x00000001897C0640-0x00000001897C0680
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001849E3E90-0x00000001849E4160
	// [XID] // 0x00000001897CAB90-0x00000001897CABB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849E5FC0-0x00000001849E6280
	[BlackList] // 0x00000001897D21D0-0x00000001897D2210
	// [XID] // 0x00000001897D21D0-0x00000001897D2210
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001849E5450-0x00000001849E5540
	// [XID] // 0x00000001897DC930-0x00000001897DC950
	protected override bool Prepare(GuideManager manager) => default; // 0x00000001849E4A60-0x00000001849E4B20
	// [XID] // 0x00000001897E43D0-0x00000001897E43F0
	private bool HasTeamMember(uint configID) => default; // 0x00000001849E6440-0x00000001849E66A0
	// [XID] // 0x00000001897EBF00-0x00000001897EBF20
	private bool NotHasTeamMember(uint configID) => default; // 0x00000001849E5920-0x00000001849E5B80
	// [XID] // 0x00000001897F3870-0x00000001897F3890
	public override bool Ready(object body = null) => default; // 0x00000001849E5130-0x00000001849E5220
	[BlackList] // 0x00000001897FB1D0-0x00000001897FB210
	// [XID] // 0x00000001897FB1D0-0x00000001897FB210
	public override void AutoAllocTypeFields() {} // 0x00000001849E4160-0x00000001849E4200
	[BlackList] // 0x0000000189805390-0x00000001898053D0
	// [XID] // 0x0000000189805390-0x00000001898053D0
	public override void AutoRecycleTypeFields() {} // 0x00000001849E4200-0x00000001849E42E0
	[BlackList] // 0x000000018980FD50-0x000000018980FD90
	// [XID] // 0x000000018980FD50-0x000000018980FD90
	public override void ReturnToObjectPool() {} // 0x00000001849E66A0-0x00000001849E6740
}

