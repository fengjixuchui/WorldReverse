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
public class ConfigGlobalShakeOff : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18104
{
	// Fields
	private SimpleSafeFloat reduceDurabilityRawNum; // 0x10
	private SimpleSafeFloat intervalRawNum; // 0x14
	private SimpleSafeFloat shakeLifeTimeRawNum; // 0x18
	private SimpleSafeFloat shakeValueRawNum; // 0x1C
	private SimpleSafeFloat shakePeriodRawNum; // 0x20
	private SimpleSafeFloat shakeSmoothRatioRawNum; // 0x24
	private SimpleSafeFloat shakeAlongAngleRawNum; // 0x28
	private SimpleSafeFloat shakeRotAngleRawNum; // 0x2C
	private SimpleSafeFloat shakeNoiseRatioRawNum; // 0x30
	private SimpleSafeFloat shakeDirRatioRawNum; // 0x34
	private SimpleSafeFloat shakeZRatioRawNum; // 0x38

	// Properties
	public float reduceDurability { /* [XID] */ /* 0x0000000189656650-0x0000000189656670 */ get => default; /* [XID] */ /* 0x000000018965DD30-0x000000018965DD50 */ private set {} } // 0x00000001822C8DC0-0x00000001822C8EA0 0x00000001822C95A0-0x00000001822C9680
	public float interval { /* [XID] */ /* 0x0000000189665450-0x0000000189665470 */ get => default; /* [XID] */ /* 0x000000018966CB80-0x000000018966CBA0 */ private set {} } // 0x00000001822CA030-0x00000001822CA110 0x00000001822C8CE0-0x00000001822C8DC0
	public float shakeLifeTime { /* [XID] */ /* 0x0000000189674990-0x00000001896749B0 */ get => default; /* [XID] */ /* 0x000000018967C2A0-0x000000018967C2C0 */ private set {} } // 0x00000001822CA1F0-0x00000001822CA2D0 0x00000001822C9760-0x00000001822C9840
	public float shakeValue { /* [XID] */ /* 0x0000000189AD9B80-0x0000000189AD9BA0 */ get => default; /* [XID] */ /* 0x000000018968B630-0x000000018968B650 */ private set {} } // 0x00000001822C9A90-0x00000001822C9B70 0x00000001822C6DA0-0x00000001822C6E80
	public float shakePeriod { /* [XID] */ /* 0x0000000189693220-0x0000000189693240 */ get => default; /* [XID] */ /* 0x000000018969A450-0x000000018969A470 */ private set {} } // 0x00000001822CA2D0-0x00000001822CA3B0 0x00000001822C93E0-0x00000001822C94C0
	public float shakeSmoothRatio { /* [XID] */ /* 0x00000001896A1D20-0x00000001896A1D40 */ get => default; /* [XID] */ /* 0x00000001896A9140-0x00000001896A9160 */ private set {} } // 0x00000001822C8270-0x00000001822C8350 0x00000001822C8350-0x00000001822C8430
	public float shakeAlongAngle { /* [XID] */ /* 0x00000001896B02F0-0x00000001896B0310 */ get => default; /* [XID] */ /* 0x00000001896B7BB0-0x00000001896B7BD0 */ private set {} } // 0x00000001822C9F50-0x00000001822CA030 0x00000001822C9E70-0x00000001822C9F50
	public float shakeRotAngle { /* [XID] */ /* 0x00000001896BEB70-0x00000001896BEB90 */ get => default; /* [XID] */ /* 0x00000001896C65B0-0x00000001896C65D0 */ private set {} } // 0x00000001822C8190-0x00000001822C8270 0x00000001822C80B0-0x00000001822C8190
	public float shakeNoiseRatio { /* [XID] */ /* 0x00000001896CDB10-0x00000001896CDB30 */ get => default; /* [XID] */ /* 0x00000001896D5100-0x00000001896D5120 */ private set {} } // 0x00000001822C9680-0x00000001822C9760 0x00000001822C94C0-0x00000001822C95A0
	public float shakeDirRatio { /* [XID] */ /* 0x00000001896DC6E0-0x00000001896DC700 */ get => default; /* [XID] */ /* 0x00000001896E3FF0-0x00000001896E4010 */ private set {} } // 0x00000001822C8EA0-0x00000001822C8F80 0x00000001822C9840-0x00000001822C9920
	public float shakeZRatio { /* [XID] */ /* 0x00000001896EB480-0x00000001896EB4A0 */ get => default; /* [XID] */ /* 0x00000001896F2790-0x00000001896F27B0 */ private set {} } // 0x00000001822CA110-0x00000001822CA1F0 0x00000001822C9300-0x00000001822C93E0

	// Constructors
	public ConfigGlobalShakeOff() {} // 0x00000001822CAEB0-0x00000001822CAF10

	// Methods
	// [XID] // 0x00000001896FA130-0x00000001896FA150
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822CAAD0-0x00000001822CACD0
	// [XID] // 0x00000001897018C0-0x00000001897018E0
	public void InitEmpty() {} // 0x00000001822C9920-0x00000001822C9A90
	[BlackList] // 0x0000000189709180-0x00000001897091C0
	// [XID] // 0x0000000189709180-0x00000001897091C0
	public bool FromJson(JSONNode node) => default; // 0x00000001822C8F80-0x00000001822C9300
	// [XID] // 0x0000000189713880-0x00000001897138A0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001822C6E80-0x00000001822C7BB0
	// [XID] // 0x000000018971B140-0x000000018971B160
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B27 */, bool useObjectPool = false /* Metadata: 0x00AF8B2B */) => default; // 0x00000001822C9B70-0x00000001822C9E70
	// [XID] // 0x00000001897224A0-0x00000001897224C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B2C */, bool useObjectPool = false /* Metadata: 0x00AF8B30 */) => default; // 0x00000001822C8430-0x00000001822C8CE0
	[BlackList] // 0x0000000189729B60-0x0000000189729BA0
	// [XID] // 0x0000000189729B60-0x0000000189729BA0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001822C7BB0-0x00000001822C7E80
	// [XID] // 0x0000000189734250-0x0000000189734270
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001822CA3B0-0x00000001822CAAD0
	[BlackList] // 0x000000018973BA90-0x000000018973BAD0
	// [XID] // 0x000000018973BA90-0x000000018973BAD0
	public virtual void AutoAllocTypeFields() {} // 0x00000001822C7E80-0x00000001822C7F20
	[BlackList] // 0x00000001897463A0-0x00000001897463E0
	// [XID] // 0x00000001897463A0-0x00000001897463E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001822C7F20-0x00000001822C80B0
	[BlackList] // 0x0000000189750B80-0x0000000189750BC0
	// [XID] // 0x0000000189750B80-0x0000000189750BC0
	public virtual void ReturnToObjectPool() {} // 0x00000001822CAE10-0x00000001822CAEB0
	[BlackList] // 0x000000018975AFC0-0x000000018975B000
	// [XID] // 0x000000018975AFC0-0x000000018975B000
	public virtual void OnPoolAllocated() {} // 0x00000001822CAD70-0x00000001822CAE10
	[BlackList] // 0x00000001897655F0-0x0000000189765630
	// [XID] // 0x00000001897655F0-0x0000000189765630
	public virtual void OnBeforePoolRecycled() {} // 0x00000001822CACD0-0x00000001822CAD70
}

