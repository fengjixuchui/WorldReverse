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
public class ConfigHomeworldFurnitureSet : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18345
{
	// Fields
	private SimpleSafeFloat radiusRawNum; // 0x10
	private SimpleSafeFloat heightRawNum; // 0x14
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigHomeworldFurnitureUnit[] _furnitureUnits; // 0x18

	// Properties
	public float radius { /* [XID] */ /* 0x00000001897D3AA0-0x00000001897D3AC0 */ get => default; /* [XID] */ /* 0x00000001897DB4F0-0x00000001897DB510 */ private set {} } // 0x0000000182A88B40-0x0000000182A88C20 0x0000000182A89260-0x0000000182A89340
	public float height { /* [XID] */ /* 0x00000001897E2BC0-0x00000001897E2BE0 */ get => default; /* [XID] */ /* 0x00000001897EA3A0-0x00000001897EA3C0 */ private set {} } // 0x0000000182A88F20-0x0000000182A89000 0x0000000182A889C0-0x0000000182A88AA0
	public ConfigHomeworldFurnitureUnit[] furnitureUnits { /* [XID] */ /* 0x00000001897F20D0-0x00000001897F20F0 */ get => default; /* [XID] */ /* 0x00000001897F9860-0x00000001897F9880 */ private set {} } // 0x0000000182A88AA0-0x0000000182A88B40 0x0000000182A88910-0x0000000182A889C0

	// Constructors
	public ConfigHomeworldFurnitureSet() {} // 0x0000000182A893E0-0x0000000182A89440

	// Methods
	// [XID] // 0x0000000189800D80-0x0000000189800DA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A89000-0x0000000182A89120
	// [XID] // 0x00000001898082E0-0x0000000189808300
	public void InitEmpty() {} // 0x0000000182A88500-0x0000000182A88610
	[BlackList] // 0x000000018980FCF0-0x000000018980FD30
	// [XID] // 0x000000018980FCF0-0x000000018980FD30
	public bool FromJson(JSONNode node) => default; // 0x0000000182A88180-0x0000000182A88500
	// [XID] // 0x000000018981A5C0-0x000000018981A5E0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182A87590-0x0000000182A879C0
	// [XID] // 0x0000000189821D70-0x0000000189821D90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF94DB */, bool useObjectPool = false /* Metadata: 0x00AF94DF */) => default; // 0x0000000182A88610-0x0000000182A88910
	// [XID] // 0x0000000189829210-0x0000000189829230
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF94E0 */, bool useObjectPool = false /* Metadata: 0x00AF94E4 */) => default; // 0x0000000182A87E20-0x0000000182A88180
	[BlackList] // 0x0000000189830840-0x0000000189830880
	// [XID] // 0x0000000189830840-0x0000000189830880
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A879C0-0x0000000182A87C90
	// [XID] // 0x000000018983AEA0-0x000000018983AEC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A88C20-0x0000000182A88F20
	[BlackList] // 0x0000000189842540-0x0000000189842580
	// [XID] // 0x0000000189842540-0x0000000189842580
	public virtual void AutoAllocTypeFields() {} // 0x0000000182A87C90-0x0000000182A87D30
	[BlackList] // 0x000000018984C960-0x000000018984C9A0
	// [XID] // 0x000000018984C960-0x000000018984C9A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182A87D30-0x0000000182A87E20
	[BlackList] // 0x0000000189856AA0-0x0000000189856AE0
	// [XID] // 0x0000000189856AA0-0x0000000189856AE0
	public virtual void ReturnToObjectPool() {} // 0x0000000182A89340-0x0000000182A893E0
	[BlackList] // 0x0000000189860EB0-0x0000000189860EF0
	// [XID] // 0x0000000189860EB0-0x0000000189860EF0
	public virtual void OnPoolAllocated() {} // 0x0000000182A891C0-0x0000000182A89260
	[BlackList] // 0x000000018986B740-0x000000018986B780
	// [XID] // 0x000000018986B740-0x000000018986B780
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182A89120-0x0000000182A891C0
}

