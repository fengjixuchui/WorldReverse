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
public class ConfigSceneArea : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18912
{
	// Fields
	private SceneAreaType _type; // 0x10
	private bool _unlocked; // 0x14

	// Properties
	public SceneAreaType type { /* [XID] */ /* 0x00000001898248C0-0x00000001898248E0 */ get => default; /* [XID] */ /* 0x000000018982C390-0x000000018982C3B0 */ private set {} } // 0x00000001851E2A20-0x00000001851E2AC0 0x00000001851E24E0-0x00000001851E2590
	public bool unlocked { /* [XID] */ /* 0x0000000189833880-0x00000001898338A0 */ get => default; /* [XID] */ /* 0x000000018983ADA0-0x000000018983ADC0 */ private set {} } // 0x00000001851E1A20-0x00000001851E1AC0 0x00000001851E2430-0x00000001851E24E0

	// Constructors
	public ConfigSceneArea() {} // 0x00000001851E2B60-0x00000001851E2BC0

	// Methods
	// [XID] // 0x0000000189842400-0x0000000189842420
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851E27D0-0x00000001851E28E0
	// [XID] // 0x0000000189849870-0x0000000189849890
	public void InitEmpty() {} // 0x00000001851E2090-0x00000001851E2130
	[BlackList] // 0x0000000189851030-0x0000000189851070
	// [XID] // 0x0000000189851030-0x0000000189851070
	public bool FromJson(JSONNode node) => default; // 0x00000001851E1D10-0x00000001851E2090
	// [XID] // 0x000000018985B430-0x000000018985B450
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001851E1370-0x00000001851E1610
	// [XID] // 0x00000001898629D0-0x00000001898629F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB371 */, bool useObjectPool = false /* Metadata: 0x00AFB375 */) => default; // 0x00000001851E2130-0x00000001851E2430
	// [XID] // 0x0000000189A5E310-0x0000000189A5E330
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB376 */, bool useObjectPool = false /* Metadata: 0x00AFB37A */) => default; // 0x00000001851E1AC0-0x00000001851E1D10
	[BlackList] // 0x0000000189871190-0x00000001898711D0
	// [XID] // 0x0000000189871190-0x00000001898711D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001851E1610-0x00000001851E18E0
	// [XID] // 0x000000018987BAC0-0x000000018987BAE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851E2590-0x00000001851E27D0
	[BlackList] // 0x0000000189882BF0-0x0000000189882C30
	// [XID] // 0x0000000189882BF0-0x0000000189882C30
	public virtual void AutoAllocTypeFields() {} // 0x00000001851E18E0-0x00000001851E1980
	[BlackList] // 0x000000018988D220-0x000000018988D260
	// [XID] // 0x000000018988D220-0x000000018988D260
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851E1980-0x00000001851E1A20
	[BlackList] // 0x0000000189897660-0x00000001898976A0
	// [XID] // 0x0000000189897660-0x00000001898976A0
	public virtual void ReturnToObjectPool() {} // 0x00000001851E2AC0-0x00000001851E2B60
	[BlackList] // 0x00000001898A1C40-0x00000001898A1C80
	// [XID] // 0x00000001898A1C40-0x00000001898A1C80
	public virtual void OnPoolAllocated() {} // 0x00000001851E2980-0x00000001851E2A20
	[BlackList] // 0x00000001898AC2C0-0x00000001898AC300
	// [XID] // 0x00000001898AC2C0-0x00000001898AC300
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851E28E0-0x00000001851E2980
}

