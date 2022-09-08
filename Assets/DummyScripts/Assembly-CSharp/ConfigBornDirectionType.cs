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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigBornDirectionType : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17830
{
	// Fields
	private MoleMole.Config.Vector _angleOffset; // 0x10
	private MoleMole.Config.Vector _angleOffsetCorrect; // 0x1C
	private SimpleSafeFloat randomAngleHorRawNum; // 0x28
	private SimpleSafeFloat randomAngleVerRawNum; // 0x2C
	private DirectionAngleType _maxAngleType; // 0x30
	private SimpleSafeFloat maxAngleRawNum; // 0x34

	// Properties
	public MoleMole.Config.Vector angleOffset { /* [XID] */ /* 0x00000001898F6600-0x00000001898F6620 */ get => default; /* [XID] */ /* 0x00000001898FDD20-0x00000001898FDD40 */ private set {} } // 0x0000000183D3AAA0-0x0000000183D3AB80 0x0000000183D3C020-0x0000000183D3C0F0
	public MoleMole.Config.Vector angleOffsetCorrect { /* [XID] */ /* 0x0000000189905580-0x00000001899055A0 */ get => default; /* [XID] */ /* 0x000000018990CE10-0x000000018990CE30 */ private set {} } // 0x0000000183D3B770-0x0000000183D3B850 0x0000000183D3C940-0x0000000183D3CA10
	public float randomAngleHor { /* [XID] */ /* 0x0000000189914600-0x0000000189914620 */ get => default; /* [XID] */ /* 0x000000018991C160-0x000000018991C180 */ private set {} } // 0x0000000183D3B060-0x0000000183D3B140 0x0000000183D3A9C0-0x0000000183D3AAA0
	public float randomAngleVer { /* [XID] */ /* 0x00000001899237E0-0x0000000189923800 */ get => default; /* [XID] */ /* 0x000000018992AEA0-0x000000018992AEC0 */ private set {} } // 0x0000000183D3BF40-0x0000000183D3C020 0x0000000183D3B990-0x0000000183D3BA70
	public DirectionAngleType maxAngleType { /* [XID] */ /* 0x00000001899324E0-0x0000000189932500 */ get => default; /* [XID] */ /* 0x0000000189939F30-0x0000000189939F50 */ private set {} } // 0x0000000183D3A920-0x0000000183D3A9C0 0x0000000183D3C2F0-0x0000000183D3C3A0
	public float maxAngle { /* [XID] */ /* 0x0000000189941120-0x0000000189941140 */ get => default; /* [XID] */ /* 0x0000000189948C00-0x0000000189948C20 */ private set {} } // 0x0000000183D3B140-0x0000000183D3B220 0x0000000183D3CD10-0x0000000183D3CDF0

	// Constructors
	public ConfigBornDirectionType() {} // 0x0000000183D3CE90-0x0000000183D3CF30

	// Methods
	// [XID] // 0x0000000189950370-0x0000000189950390
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D3CA10-0x0000000183D3CBD0
	// [XID] // 0x0000000189957960-0x0000000189957980
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183D3C3A0-0x0000000183D3C450
	// [XID] // 0x000000018995F1D0-0x000000018995F1F0
	public virtual ConfigBornDirectionType Clone(bool useObjectPool = false /* Metadata: 0x00AF7E59 */) => default; // 0x0000000183D3BE60-0x0000000183D3BF40
	// [XID] // 0x0000000189966AD0-0x0000000189966AF0
	public virtual int GetHashNum() => default; // 0x0000000183D3A850-0x0000000183D3A920
	// [XID] // 0x000000018996DEA0-0x000000018996DEC0
	public virtual void InitEmpty() {} // 0x0000000183D3B850-0x0000000183D3B990
	[BlackList] // 0x0000000189975A10-0x0000000189975A50
	// [XID] // 0x0000000189975A10-0x0000000189975A50
	public virtual bool FromJson(JSONNode node) => default; // 0x0000000183D3B220-0x0000000183D3B5A0
	// [XID] // 0x00000001899800A0-0x00000001899800C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183D39CE0-0x0000000183D3A3C0
	[BlackList] // 0x0000000189987870-0x00000001899878B0
	// [XID] // 0x0000000189987870-0x00000001899878B0
	public static ConfigBornDirectionType ParseFromJson(JSONNode node) => default; // 0x0000000183D3C0F0-0x0000000183D3C2F0
	// [XID] // 0x00000001899925D0-0x00000001899925F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E5A */, bool useObjectPool = false /* Metadata: 0x00AF7E5E */) => default; // 0x0000000183D3BB60-0x0000000183D3BE60
	// [XID] // 0x000000018999A2F0-0x000000018999A310
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E5F */, bool useObjectPool = false /* Metadata: 0x00AF7E63 */) => default; // 0x0000000183D3AB80-0x0000000183D3B060
	// [XID] // 0x00000001899A19D0-0x00000001899A19F0
	public static ConfigBornDirectionType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7E64 */, bool useObjectPool = false /* Metadata: 0x00AF7E68 */) => default; // 0x0000000183D3B5A0-0x0000000183D3B770
	[BlackList] // 0x00000001899A9240-0x00000001899A9280
	// [XID] // 0x00000001899A9240-0x00000001899A9280
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D3A3C0-0x0000000183D3A690
	// [XID] // 0x00000001899B3CE0-0x00000001899B3D00
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D3C450-0x0000000183D3C940
	[BlackList] // 0x00000001899BB110-0x00000001899BB150
	// [XID] // 0x00000001899BB110-0x00000001899BB150
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183D3BA70-0x0000000183D3BB60
	[BlackList] // 0x00000001899C5BD0-0x00000001899C5C10
	// [XID] // 0x00000001899C5BD0-0x00000001899C5C10
	public virtual void AutoAllocTypeFields() {} // 0x0000000183D3A690-0x0000000183D3A730
	[BlackList] // 0x00000001899D02D0-0x00000001899D0310
	// [XID] // 0x00000001899D02D0-0x00000001899D0310
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183D3A730-0x0000000183D3A850
	[BlackList] // 0x00000001899DA660-0x00000001899DA6A0
	// [XID] // 0x00000001899DA660-0x00000001899DA6A0
	public virtual void ReturnToObjectPool() {} // 0x0000000183D3CDF0-0x0000000183D3CE90
	[BlackList] // 0x00000001899E5240-0x00000001899E5280
	// [XID] // 0x00000001899E5240-0x00000001899E5280
	public virtual void OnPoolAllocated() {} // 0x0000000183D3CC70-0x0000000183D3CD10
	[BlackList] // 0x00000001899EF4B0-0x00000001899EF4F0
	// [XID] // 0x00000001899EF4B0-0x00000001899EF4F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183D3CBD0-0x0000000183D3CC70
}

