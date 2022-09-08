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
public class ConfigGuideForceAvatarMoveAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18323
{
	// Fields
	private SimpleSafeFloat angleRawNum; // 0x18
	private SimpleSafeFloat moldRawNum; // 0x1C

	// Properties
	public float angle { /* [XID] */ /* 0x0000000189BB3C50-0x0000000189BB3C70 */ get => default; /* [XID] */ /* 0x0000000189BBB1F0-0x0000000189BBB210 */ private set {} } // 0x000000018111A1B0-0x000000018111A290 0x000000018111AF90-0x000000018111B070
	public float mold { /* [XID] */ /* 0x0000000189BC3070-0x0000000189BC3090 */ get => default; /* [XID] */ /* 0x0000000189BCA8D0-0x0000000189BCA8F0 */ private set {} } // 0x000000018111A7B0-0x000000018111A890 0x000000018111A890-0x000000018111A970

	// Constructors
	public ConfigGuideForceAvatarMoveAction() {} // 0x000000018111C070-0x000000018111C0D0

	// Methods
	// [XID] // 0x0000000189BD1EE0-0x0000000189BD1F00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018111BEC0-0x000000018111BFD0
	// [XID] // 0x0000000189BD9560-0x0000000189BD9580
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018111BAF0-0x000000018111BBA0
	// [XID] // 0x00000001895E6110-0x00000001895E6130
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF942B */) => default; // 0x000000018111B700-0x000000018111B7E0
	// [XID] // 0x00000001895EDA30-0x00000001895EDA50
	public override int GetHashNum() => default; // 0x000000018111A080-0x000000018111A150
	// [XID] // 0x00000001895F5270-0x00000001895F5290
	public override void InitEmpty() {} // 0x000000018111B0E0-0x000000018111B1C0
	[BlackList] // 0x00000001895FC810-0x00000001895FC850
	// [XID] // 0x00000001895FC810-0x00000001895FC850
	public override bool FromJson(JSONNode node) => default; // 0x000000018111A9F0-0x000000018111AD70
	// [XID] // 0x0000000189606FA0-0x0000000189606FC0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000181119760-0x0000000181119B00
	[BlackList] // 0x000000018960E920-0x000000018960E960
	// [XID] // 0x000000018960E920-0x000000018960E960
	public static new ConfigGuideForceAvatarMoveAction ParseFromJson(JSONNode node) => default; // 0x000000018111B840-0x000000018111BA90
	// [XID] // 0x00000001896192C0-0x00000001896192E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF942C */, bool useObjectPool = false /* Metadata: 0x00AF9430 */) => default; // 0x000000018111B400-0x000000018111B700
	// [XID] // 0x0000000189620820-0x0000000189620840
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9431 */, bool useObjectPool = false /* Metadata: 0x00AF9435 */) => default; // 0x000000018111A430-0x000000018111A730
	// [XID] // 0x0000000189627CF0-0x0000000189627D10
	public static new ConfigGuideForceAvatarMoveAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9436 */, bool useObjectPool = false /* Metadata: 0x00AF943A */) => default; // 0x000000018111AD70-0x000000018111AF90
	[BlackList] // 0x000000018962F620-0x000000018962F660
	// [XID] // 0x000000018962F620-0x000000018962F660
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000181119B00-0x0000000181119DD0
	// [XID] // 0x000000018963A010-0x000000018963A030
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018111BC20-0x000000018111BEC0
	[BlackList] // 0x0000000189641560-0x00000001896415A0
	// [XID] // 0x0000000189641560-0x00000001896415A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018111B310-0x000000018111B400
	// [XID] // 0x000000018964BF70-0x000000018964BF90
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x000000018111A310-0x000000018111A430
	// [XID] // 0x00000001896535C0-0x00000001896535E0
	protected override bool Stop() => default; // 0x0000000181119670-0x0000000181119760
	[BlackList] // 0x000000018965ADF0-0x000000018965AE30
	// [XID] // 0x000000018965ADF0-0x000000018965AE30
	public override void AutoAllocTypeFields() {} // 0x0000000181119DD0-0x0000000181119E70
	[BlackList] // 0x0000000189665390-0x00000001896653D0
	// [XID] // 0x0000000189665390-0x00000001896653D0
	public override void AutoRecycleTypeFields() {} // 0x0000000181119E70-0x0000000181119F60
	[BlackList] // 0x0000000189670130-0x0000000189670170
	// [XID] // 0x0000000189670130-0x0000000189670170
	public override void ReturnToObjectPool() {} // 0x000000018111BFD0-0x000000018111C070
}

