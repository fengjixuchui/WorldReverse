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
public class ConfigAbilityPropertyEntry : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14944
{
	// Fields
	private PropertyType _Type; // 0x10
	private SimpleSafeFloat DefaultValueRawNum; // 0x14
	private SimpleSafeFloat CeilingRawNum; // 0x18
	private SimpleSafeFloat FloorRawNum; // 0x1C
	private StackMethod _Stacking; // 0x20
	private bool _Succeed; // 0x24
	private bool _UseTag; // 0x25
	private SimpleSafeFloat LimitedTagCeilingRawNum; // 0x28
	private SimpleSafeFloat LimitedTagFloorRawNum; // 0x2C

	// Properties
	public PropertyType Type { /* [XID] */ /* 0x0000000189884CD0-0x0000000189884CF0 */ get => default; /* [XID] */ /* 0x000000018988C340-0x000000018988C360 */ private set {} } // 0x0000000182EF0400-0x0000000182EF04A0 0x0000000182EF3700-0x0000000182EF37B0
	public float DefaultValue { /* [XID] */ /* 0x00000001898938D0-0x00000001898938F0 */ get => default; /* [XID] */ /* 0x000000018989B010-0x000000018989B030 */ private set {} } // 0x0000000182EF2C40-0x0000000182EF2D20 0x0000000182EF3890-0x0000000182EF3970
	public float Ceiling { /* [XID] */ /* 0x00000001898DD1C0-0x00000001898DD1E0 */ get => default; /* [XID] */ /* 0x00000001898A9990-0x00000001898A99B0 */ private set {} } // 0x0000000182EF2A10-0x0000000182EF2AF0 0x0000000182EF37B0-0x0000000182EF3890
	public float Floor { /* [XID] */ /* 0x00000001898B1320-0x00000001898B1340 */ get => default; /* [XID] */ /* 0x00000001898B8C80-0x00000001898B8CA0 */ private set {} } // 0x0000000182EF1410-0x0000000182EF14F0 0x0000000182EF15A0-0x0000000182EF1680
	public StackMethod Stacking { /* [XID] */ /* 0x00000001897BAA50-0x00000001897BAA70 */ get => default; /* [XID] */ /* 0x00000001898C7C20-0x00000001898C7C40 */ private set {} } // 0x0000000182EF1370-0x0000000182EF1410 0x0000000182EF23A0-0x0000000182EF2450
	public bool Succeed { /* [XID] */ /* 0x000000018962D200-0x000000018962D220 */ get => default; /* [XID] */ /* 0x00000001898D6BA0-0x00000001898D6BC0 */ private set {} } // 0x0000000182EF2AF0-0x0000000182EF2B90 0x0000000182EF2B90-0x0000000182EF2C40
	public bool UseTag { /* [XID] */ /* 0x00000001898DE8A0-0x00000001898DE8C0 */ get => default; /* [XID] */ /* 0x00000001898E6060-0x00000001898E6080 */ private set {} } // 0x0000000182EF1680-0x0000000182EF1720 0x0000000182EF14F0-0x0000000182EF15A0
	public float LimitedTagCeiling { /* [XID] */ /* 0x00000001898FB460-0x00000001898FB480 */ get => default; /* [XID] */ /* 0x00000001898F52C0-0x00000001898F52E0 */ private set {} } // 0x0000000182EF1E00-0x0000000182EF1EE0 0x0000000182EF0DE0-0x0000000182EF0EC0
	public float LimitedTagFloor { /* [XID] */ /* 0x00000001898FC930-0x00000001898FC950 */ get => default; /* [XID] */ /* 0x00000001899043B0-0x00000001899043D0 */ private set {} } // 0x0000000182EF1720-0x0000000182EF1800 0x0000000182EF2D20-0x0000000182EF2E00

	// Constructors
	public ConfigAbilityPropertyEntry(PropertyType Type, float DefaultValue, StackMethod Stacking, float Floor, float Ceiling, bool Succeed, bool UseTag, float LimitedTagFloor, float LimitedTagCeiling) {} // 0x0000000182EF3A10-0x0000000182EF3BC0
	public ConfigAbilityPropertyEntry() {} // 0x0000000182EF3BC0-0x0000000182EF3CA0

	// Methods
	// [XID] // 0x000000018990B9F0-0x000000018990BA10
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182EF3400-0x0000000182EF35C0
	// [XID] // 0x0000000189913520-0x0000000189913540
	public void InitEmpty() {} // 0x0000000182EF25F0-0x0000000182EF2710
	[BlackList] // 0x000000018991ACF0-0x000000018991AD30
	// [XID] // 0x000000018991ACF0-0x000000018991AD30
	public bool FromJson(JSONNode node) => default; // 0x0000000182EF2020-0x0000000182EF23A0
	// [XID] // 0x00000001899254A0-0x00000001899254C0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182EF04A0-0x0000000182EF0DE0
	// [XID] // 0x00000001898881F0-0x0000000189888210
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB28 */, bool useObjectPool = false /* Metadata: 0x00AEFB2C */) => default; // 0x0000000182EF2710-0x0000000182EF2A10
	// [XID] // 0x0000000189934080-0x00000001899340A0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFB2D */, bool useObjectPool = false /* Metadata: 0x00AEFB31 */) => default; // 0x0000000182EF1800-0x0000000182EF1E00
	[BlackList] // 0x000000018993BD10-0x000000018993BD50
	// [XID] // 0x000000018993BD10-0x000000018993BD50
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182EF0EC0-0x0000000182EF1190
	// [XID] // 0x00000001899461E0-0x0000000189946200
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182EF2E00-0x0000000182EF3400
	// [XID] // 0x000000018994D730-0x000000018994D750
	public FixedFloatStack CreatePropertyStack() => default; // 0x0000000182EF1EE0-0x0000000182EF2020
	// [XID] // 0x000000018987E390-0x000000018987E3B0
	public FixedSafeFloatStack CreatePropertySafeStack() => default; // 0x0000000182EF2450-0x0000000182EF25F0
	[BlackList] // 0x000000018995C5C0-0x000000018995C600
	// [XID] // 0x000000018995C5C0-0x000000018995C600
	public virtual void AutoAllocTypeFields() {} // 0x0000000182EF1190-0x0000000182EF1230
	[BlackList] // 0x0000000189967090-0x00000001899670D0
	// [XID] // 0x0000000189967090-0x00000001899670D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182EF1230-0x0000000182EF1370
	[BlackList] // 0x0000000189971BE0-0x0000000189971C20
	// [XID] // 0x0000000189971BE0-0x0000000189971C20
	public virtual void ReturnToObjectPool() {} // 0x0000000182EF3970-0x0000000182EF3A10
	[BlackList] // 0x000000018997BD60-0x000000018997BDA0
	// [XID] // 0x000000018997BD60-0x000000018997BDA0
	public virtual void OnPoolAllocated() {} // 0x0000000182EF3660-0x0000000182EF3700
	[BlackList] // 0x00000001899864B0-0x00000001899864F0
	// [XID] // 0x00000001899864B0-0x00000001899864F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182EF35C0-0x0000000182EF3660
}

