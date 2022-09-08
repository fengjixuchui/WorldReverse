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
public class AudioSettingSlider : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17620
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _rtpc; // 0x10
	private string _textMap; // 0x18
	private SimpleSafeUInt32 minValueRawNum; // 0x20
	private SimpleSafeUInt32 maxValueRawNum; // 0x24
	private SimpleSafeFloat[] _eachValues; // 0x28

	// Properties
	public ConfigWwiseString rtpc { /* [XID] */ /* 0x0000000189BC8F80-0x0000000189BC8FA0 */ get => default; /* [XID] */ /* 0x0000000189BD07B0-0x0000000189BD07D0 */ private set {} } // 0x00000001843107B0-0x0000000184310850 0x000000018430F240-0x000000018430F2F0
	public string textMap { /* [XID] */ /* 0x0000000189BD7D30-0x0000000189BD7D50 */ get => default; /* [XID] */ /* 0x0000000189BDF960-0x0000000189BDF980 */ private set {} } // 0x0000000184310E80-0x0000000184310F20 0x000000018430FF50-0x0000000184310000
	public uint minValue { /* [XID] */ /* 0x00000001895EC450-0x00000001895EC470 */ get => default; /* [XID] */ /* 0x00000001895F3890-0x00000001895F38B0 */ private set {} } // 0x00000001843106E0-0x00000001843107B0 0x000000018430F920-0x000000018430FA00
	public uint maxValue { /* [XID] */ /* 0x00000001895FB1D0-0x00000001895FB1F0 */ get => default; /* [XID] */ /* 0x0000000189602950-0x0000000189602970 */ private set {} } // 0x0000000184310000-0x00000001843100D0 0x000000018430F3C0-0x000000018430F4A0
	public SimpleSafeFloat[] eachValues { /* [XID] */ /* 0x000000018985AAF0-0x000000018985AB10 */ get => default; /* [XID] */ /* 0x0000000189611A60-0x0000000189611A80 */ private set {} } // 0x000000018430F1A0-0x000000018430F240 0x000000018430F0F0-0x000000018430F1A0

	// Constructors
	public AudioSettingSlider() {} // 0x0000000184311860-0x0000000184311900

	// Methods
	// [XID] // 0x00000001896193A0-0x00000001896193C0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184311510-0x0000000184311680
	// [XID] // 0x00000001896209A0-0x00000001896209C0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184310D70-0x0000000184310E80
	// [XID] // 0x0000000189627EB0-0x0000000189627ED0
	public virtual AudioSettingSlider Clone(bool useObjectPool = false /* Metadata: 0x00AF7501 */) => default; // 0x0000000184310600-0x00000001843106E0
	// [XID] // 0x000000018962F7C0-0x000000018962F7E0
	public virtual int GetHashNum() => default; // 0x000000018430F2F0-0x000000018430F3C0
	// [XID] // 0x0000000189637360-0x0000000189637380
	public virtual void InitEmpty() {} // 0x00000001843100D0-0x0000000184310210
	[BlackList] // 0x000000018963E840-0x000000018963E880
	// [XID] // 0x000000018963E840-0x000000018963E880
	public virtual bool FromJson(JSONNode node) => default; // 0x000000018430FA00-0x000000018430FD80
	// [XID] // 0x0000000189649140-0x0000000189649160
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018430E660-0x000000018430EC00
	[BlackList] // 0x0000000189650770-0x00000001896507B0
	// [XID] // 0x0000000189650770-0x00000001896507B0
	public static AudioSettingSlider ParseFromJson(JSONNode node) => default; // 0x0000000184310850-0x0000000184310A50
	// [XID] // 0x000000018965B070-0x000000018965B090
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7502 */, bool useObjectPool = false /* Metadata: 0x00AF7506 */) => default; // 0x0000000184310300-0x0000000184310600
	// [XID] // 0x00000001896624E0-0x0000000189662500
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7507 */, bool useObjectPool = false /* Metadata: 0x00AF750B */) => default; // 0x000000018430F4A0-0x000000018430F920
	// [XID] // 0x000000018966A120-0x000000018966A140
	public static AudioSettingSlider ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF750C */, bool useObjectPool = false /* Metadata: 0x00AF7510 */) => default; // 0x000000018430FD80-0x000000018430FF50
	[BlackList] // 0x0000000189671D40-0x0000000189671D80
	// [XID] // 0x0000000189671D40-0x0000000189671D80
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018430EC00-0x000000018430EED0
	// [XID] // 0x000000018967C420-0x000000018967C440
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184311090-0x0000000184311510
	[BlackList] // 0x0000000189683A10-0x0000000189683A50
	// [XID] // 0x0000000189683A10-0x0000000189683A50
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184310210-0x0000000184310300
	// [IDTag] // 0x000000018968E890-0x000000018968E8D0
	// [XID] // 0x000000018968E890-0x000000018968E8D0
	public float GetValue(float index) => default; // 0x0000000184310C00-0x0000000184310D70
	// [IDTag] // 0x0000000189698FA0-0x0000000189698FE0
	// [XID] // 0x0000000189698FA0-0x0000000189698FE0
	public float GetValue(int index) => default; // 0x0000000184310A50-0x0000000184310C00
	// [XID] // 0x00000001896A3360-0x00000001896A3380
	public int GetIndex(float value) => default; // 0x0000000184310F20-0x0000000184311090
	[BlackList] // 0x00000001896AA830-0x00000001896AA870
	// [XID] // 0x00000001896AA830-0x00000001896AA870
	public virtual void AutoAllocTypeFields() {} // 0x000000018430EED0-0x000000018430EF70
	[BlackList] // 0x00000001896B4D30-0x00000001896B4D70
	// [XID] // 0x00000001896B4D30-0x00000001896B4D70
	public virtual void AutoRecycleTypeFields() {} // 0x000000018430EF70-0x000000018430F0F0
	[BlackList] // 0x00000001896BECD0-0x00000001896BED10
	// [XID] // 0x00000001896BECD0-0x00000001896BED10
	public virtual void ReturnToObjectPool() {} // 0x00000001843117C0-0x0000000184311860
	[BlackList] // 0x00000001896C9270-0x00000001896C92B0
	// [XID] // 0x00000001896C9270-0x00000001896C92B0
	public virtual void OnPoolAllocated() {} // 0x0000000184311720-0x00000001843117C0
	[BlackList] // 0x00000001896D35A0-0x00000001896D35E0
	// [XID] // 0x00000001896D35A0-0x00000001896D35E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184311680-0x0000000184311720
}

