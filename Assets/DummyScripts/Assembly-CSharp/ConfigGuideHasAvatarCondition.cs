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
public class ConfigGuideHasAvatarCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18250
{
	// Fields
	private GuideHasAvatarType _type; // 0x20
	private GuideHasAvatarConType _conType; // 0x24
	private SimpleSafeFloat valueRawNum; // 0x28

	// Properties
	public GuideHasAvatarType type { /* [XID] */ /* 0x00000001896885C0-0x00000001896885E0 */ get => default; /* [XID] */ /* 0x000000018968FEE0-0x000000018968FF00 */ private set {} } // 0x0000000182AECB30-0x0000000182AECBD0 0x0000000182AEC640-0x0000000182AEC6F0
	public GuideHasAvatarConType conType { /* [XID] */ /* 0x0000000189697860-0x0000000189697880 */ get => default; /* [XID] */ /* 0x000000018969ED10-0x000000018969ED30 */ private set {} } // 0x0000000182AE9CD0-0x0000000182AE9D70 0x0000000182AE9D70-0x0000000182AE9E20
	public float value { /* [XID] */ /* 0x00000001896A5FF0-0x00000001896A6010 */ get => default; /* [XID] */ /* 0x00000001896AD4D0-0x00000001896AD4F0 */ private set {} } // 0x0000000182AEAF60-0x0000000182AEB040 0x0000000182AEAD50-0x0000000182AEAE30

	// Constructors
	public ConfigGuideHasAvatarCondition() {} // 0x0000000182AECC70-0x0000000182AECCD0

	// Methods
	// [XID] // 0x00000001896B4BF0-0x00000001896B4C10
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182AECA00-0x0000000182AECB30
	// [XID] // 0x00000001896BBF60-0x00000001896BBF80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182AEC510-0x0000000182AEC5C0
	// [XID] // 0x00000001896C3420-0x00000001896C3440
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9183 */) => default; // 0x0000000182AEBF70-0x0000000182AEC050
	// [XID] // 0x00000001896CA990-0x00000001896CA9B0
	public override int GetHashNum() => default; // 0x0000000182AEA7C0-0x0000000182AEA890
	// [XID] // 0x00000001896D2060-0x00000001896D2080
	public override void InitEmpty() {} // 0x0000000182AEB9D0-0x0000000182AEBAA0
	[BlackList] // 0x00000001896D98F0-0x00000001896D9930
	// [XID] // 0x00000001896D98F0-0x00000001896D9930
	public override bool FromJson(JSONNode node) => default; // 0x0000000182AEB040-0x0000000182AEB3C0
	// [XID] // 0x00000001896E3F70-0x00000001896E3F90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182AE9E20-0x0000000182AEA250
	[BlackList] // 0x00000001896EB420-0x00000001896EB460
	// [XID] // 0x00000001896EB420-0x00000001896EB460
	public static new ConfigGuideHasAvatarCondition ParseFromJson(JSONNode node) => default; // 0x0000000182AEC260-0x0000000182AEC4B0
	// [XID] // 0x00000001896F5AA0-0x00000001896F5AC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9184 */, bool useObjectPool = false /* Metadata: 0x00AF9188 */) => default; // 0x0000000182AEBC70-0x0000000182AEBF70
	// [XID] // 0x00000001896FD270-0x00000001896FD290
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9189 */, bool useObjectPool = false /* Metadata: 0x00AF918D */) => default; // 0x0000000182AEA970-0x0000000182AEACD0
	// [XID] // 0x0000000189704750-0x0000000189704770
	public static new ConfigGuideHasAvatarCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF918E */, bool useObjectPool = false /* Metadata: 0x00AF9192 */) => default; // 0x0000000182AEB3C0-0x0000000182AEB5E0
	[BlackList] // 0x000000018970BF50-0x000000018970BF90
	// [XID] // 0x000000018970BF50-0x000000018970BF90
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182AEA250-0x0000000182AEA520
	// [XID] // 0x0000000189716580-0x00000001897165A0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182AEC6F0-0x0000000182AECA00
	[BlackList] // 0x000000018971DF60-0x000000018971DFA0
	// [XID] // 0x000000018971DF60-0x000000018971DFA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182AEBB80-0x0000000182AEBC70
	// [XID] // 0x00000001897284B0-0x00000001897284D0
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000182AEAEB0-0x0000000182AEAF60
	// [XID] // 0x000000018972FC30-0x000000018972FC50
	private bool CheckGuid(ulong guid) => default; // 0x0000000182AEC0B0-0x0000000182AEC260
	// [XID] // 0x0000000189737660-0x0000000189737680
	public override bool Ready(object body = null) => default; // 0x0000000182AEB650-0x0000000182AEB950
	[BlackList] // 0x000000018973F0E0-0x000000018973F120
	// [XID] // 0x000000018973F0E0-0x000000018973F120
	public override void AutoAllocTypeFields() {} // 0x0000000182AEA520-0x0000000182AEA5C0
	[BlackList] // 0x0000000189749640-0x0000000189749680
	// [XID] // 0x0000000189749640-0x0000000189749680
	public override void AutoRecycleTypeFields() {} // 0x0000000182AEA5C0-0x0000000182AEA6A0
	[BlackList] // 0x0000000189753940-0x0000000189753980
	// [XID] // 0x0000000189753940-0x0000000189753980
	public override void ReturnToObjectPool() {} // 0x0000000182AECBD0-0x0000000182AECC70
}

