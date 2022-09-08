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
public class ConfigGuideMechanicusPickCardCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18292
{
	// Fields
	private SimpleSafeInt32 valueRawNum; // 0x20
	private bool _isSelect; // 0x24
	private TheatreMechanicusCardSelectionPageContext _baseContext; // 0x28
	private static NotifyTypes[] _curNotifyList; // 0x00

	// Properties
	public int value { /* [XID] */ /* 0x0000000189701880-0x00000001897018A0 */ get => default; /* [XID] */ /* 0x0000000189709100-0x0000000189709120 */ private set {} } // 0x0000000184201CD0-0x0000000184201DA0 0x0000000184201A80-0x0000000184201B60
	public bool isSelect { /* [XID] */ /* 0x00000001897109D0-0x00000001897109F0 */ get => default; /* [XID] */ /* 0x0000000189717D30-0x0000000189717D50 */ private set {} } // 0x00000001842023E0-0x0000000184202480 0x00000001842037B0-0x0000000184203860

	// Constructors
	public ConfigGuideMechanicusPickCardCondition() {} // 0x00000001842039D0-0x0000000184203A40
	static ConfigGuideMechanicusPickCardCondition() {} // 0x0000000184203900-0x00000001842039D0

	// Methods
	// [XID] // 0x000000018971F770-0x000000018971F790
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001842036A0-0x00000001842037B0
	// [XID] // 0x0000000189726D40-0x0000000189726D60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184203180-0x0000000184203230
	// [XID] // 0x000000018972E2F0-0x000000018972E310
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF930F */) => default; // 0x0000000184202D90-0x0000000184202E70
	// [XID] // 0x00000001897359A0-0x00000001897359C0
	public override int GetHashNum() => default; // 0x0000000184201570-0x0000000184201640
	// [XID] // 0x000000018973D530-0x000000018973D550
	public override void InitEmpty() {} // 0x00000001842027F0-0x00000001842028C0
	[BlackList] // 0x00000001897449B0-0x00000001897449F0
	// [XID] // 0x00000001897449B0-0x00000001897449F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184201DA0-0x0000000184202120
	// [XID] // 0x000000018974F3F0-0x000000018974F410
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184200CE0-0x0000000184201000
	[BlackList] // 0x0000000189756A20-0x0000000189756A60
	// [XID] // 0x0000000189756A20-0x0000000189756A60
	public static new ConfigGuideMechanicusPickCardCondition ParseFromJson(JSONNode node) => default; // 0x0000000184202ED0-0x0000000184203120
	// [XID] // 0x0000000189761350-0x0000000189761370
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9310 */, bool useObjectPool = false /* Metadata: 0x00AF9314 */) => default; // 0x0000000184202A90-0x0000000184202D90
	// [XID] // 0x00000001897686A0-0x00000001897686C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9315 */, bool useObjectPool = false /* Metadata: 0x00AF9319 */) => default; // 0x0000000184201720-0x0000000184201A00
	// [XID] // 0x000000018976FD30-0x000000018976FD50
	public static new ConfigGuideMechanicusPickCardCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF931A */, bool useObjectPool = false /* Metadata: 0x00AF931E */) => default; // 0x00000001842021C0-0x00000001842023E0
	[BlackList] // 0x00000001897774B0-0x00000001897774F0
	// [XID] // 0x00000001897774B0-0x00000001897774F0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184201000-0x00000001842012D0
	// [XID] // 0x0000000189782040-0x0000000189782060
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001842033E0-0x00000001842036A0
	[BlackList] // 0x00000001897893E0-0x0000000189789420
	// [XID] // 0x00000001897893E0-0x0000000189789420
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001842029A0-0x0000000184202A90
	// [XID] // 0x0000000189793920-0x0000000189793940
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000184201BE0-0x0000000184201CD0
	// [XID] // 0x000000018979BBD0-0x000000018979BBF0
	protected override void Finish(GuideManager manager) {} // 0x00000001842032B0-0x0000000184203360
	// [XID] // 0x00000001897A3040-0x00000001897A3060
	private void ReleaseCache() {} // 0x0000000184202120-0x00000001842021C0
	// [XID] // 0x00000001897AA640-0x00000001897AA660
	private void CheckCurPage() {} // 0x00000001842024F0-0x00000001842025F0
	// [XID] // 0x00000001897B2150-0x00000001897B2170
	public override bool Ready(object body = null) => default; // 0x00000001842025F0-0x0000000184202770
	[BlackList] // 0x00000001897B9B30-0x00000001897B9B70
	// [XID] // 0x00000001897B9B30-0x00000001897B9B70
	public override void AutoAllocTypeFields() {} // 0x00000001842012D0-0x0000000184201370
	[BlackList] // 0x00000001897C4960-0x00000001897C49A0
	// [XID] // 0x00000001897C4960-0x00000001897C49A0
	public override void AutoRecycleTypeFields() {} // 0x0000000184201370-0x0000000184201450
	[BlackList] // 0x00000001897CF230-0x00000001897CF270
	// [XID] // 0x00000001897CF230-0x00000001897CF270
	public override void ReturnToObjectPool() {} // 0x0000000184203860-0x0000000184203900
}

