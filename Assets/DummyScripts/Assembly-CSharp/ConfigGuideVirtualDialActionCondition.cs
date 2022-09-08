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
public sealed class ConfigGuideVirtualDialActionCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18268
{
	// Fields
	private GuideVirtualDialAction _virtualDialAction; // 0x20
	private NotifyTypes[] _curNotifyList; // 0x28
	private bool _isChecked; // 0x30

	// Properties
	public GuideVirtualDialAction virtualDialAction { /* [XID] */ /* 0x0000000189BA96E0-0x0000000189BA9700 */ get => default; /* [XID] */ /* 0x0000000189BB0EF0-0x0000000189BB0F10 */ private set {} } // 0x00000001847870E0-0x0000000184787180 0x0000000184785180-0x0000000184785230

	// Constructors
	public ConfigGuideVirtualDialActionCondition() {} // 0x0000000184787310-0x00000001847873D0

	// Methods
	// [XID] // 0x0000000189BB8100-0x0000000189BB8120
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184787180-0x0000000184787270
	// [XID] // 0x0000000189BBF810-0x0000000189BBF830
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184786DB0-0x0000000184786E60
	// [XID] // 0x0000000189BC7420-0x0000000189BC7440
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF924F */) => default; // 0x00000001847869E0-0x0000000184786AD0
	// [XID] // 0x0000000189BCF150-0x0000000189BCF170
	public override int GetHashNum() => default; // 0x0000000184785770-0x0000000184785840
	// [XID] // 0x0000000189BD64A0-0x0000000189BD64C0
	public override void InitEmpty() {} // 0x0000000184786470-0x0000000184786510
	[BlackList] // 0x0000000189BDDFC0-0x0000000189BDE000
	// [XID] // 0x0000000189BDDFC0-0x0000000189BDE000
	public override bool FromJson(JSONNode node) => default; // 0x0000000184785D10-0x0000000184786090
	// [XID] // 0x00000001895EDA50-0x00000001895EDA70
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184784F60-0x0000000184785180
	[BlackList] // 0x00000001895F5290-0x00000001895F52D0
	// [XID] // 0x00000001895F5290-0x00000001895F52D0
	public static new ConfigGuideVirtualDialActionCondition ParseFromJson(JSONNode node) => default; // 0x0000000184786B30-0x0000000184786D50
	// [XID] // 0x00000001895FF850-0x00000001895FF870
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9250 */, bool useObjectPool = false /* Metadata: 0x00AF9254 */) => default; // 0x00000001847866E0-0x00000001847869E0
	// [XID] // 0x0000000189606FC0-0x0000000189606FE0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9255 */, bool useObjectPool = false /* Metadata: 0x00AF9259 */) => default; // 0x0000000184785920-0x0000000184785B50
	// [XID] // 0x000000018960E9A0-0x000000018960E9C0
	public static new ConfigGuideVirtualDialActionCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF925A */, bool useObjectPool = false /* Metadata: 0x00AF925E */) => default; // 0x0000000184786090-0x0000000184786280
	[BlackList] // 0x0000000189615FC0-0x0000000189616000
	// [XID] // 0x0000000189615FC0-0x0000000189616000
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184785230-0x0000000184785500
	// [XID] // 0x0000000189620840-0x0000000189620860
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184786EE0-0x00000001847870E0
	[BlackList] // 0x0000000189627D10-0x0000000189627D50
	// [XID] // 0x0000000189627D10-0x0000000189627D50
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001847865F0-0x00000001847866E0
	// [XID] // 0x0000000189632600-0x0000000189632620
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000184785C50-0x0000000184785D10
	// [XID] // 0x000000018963A070-0x000000018963A090
	public override bool Ready(object body = null) => default; // 0x00000001847862F0-0x00000001847863F0
	[BlackList] // 0x00000001896415E0-0x0000000189641620
	// [XID] // 0x00000001896415E0-0x0000000189641620
	public override void AutoAllocTypeFields() {} // 0x0000000184785500-0x00000001847855A0
	[BlackList] // 0x000000018964BF90-0x000000018964BFD0
	// [XID] // 0x000000018964BF90-0x000000018964BFD0
	public override void AutoRecycleTypeFields() {} // 0x00000001847855A0-0x0000000184785650
	[BlackList] // 0x00000001896565D0-0x0000000189656610
	// [XID] // 0x00000001896565D0-0x0000000189656610
	public override void ReturnToObjectPool() {} // 0x0000000184787270-0x0000000184787310
}

