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
public class ConfigAIMixinSetControllerCondition : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17513
{
	// Fields
	private SimpleSafeInt32[] _poseIDs; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAIMixinSetControllerParameter[] _settings; // 0x18

	// Properties
	public SimpleSafeInt32[] poseIDs { /* [XID] */ /* 0x0000000189B57340-0x0000000189B57360 */ get => default; /* [XID] */ /* 0x00000001897EA5E0-0x00000001897EA600 */ private set {} } // 0x000000018414CE70-0x000000018414CF10 0x000000018414E190-0x000000018414E240
	public ConfigAIMixinSetControllerParameter[] settings { /* [XID] */ /* 0x0000000189B5ED50-0x0000000189B5ED70 */ get => default; /* [XID] */ /* 0x00000001897F9960-0x00000001897F9980 */ private set {} } // 0x000000018414DD40-0x000000018414DDE0 0x000000018414E0E0-0x000000018414E190

	// Constructors
	public ConfigAIMixinSetControllerCondition() {} // 0x000000018414E7D0-0x000000018414E830

	// Methods
	// [XID] // 0x0000000189800EA0-0x0000000189800EC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018414E4E0-0x000000018414E5F0
	// [XID] // 0x0000000189808380-0x00000001898083A0
	public void InitEmpty() {} // 0x000000018414DC50-0x000000018414DD40
	[BlackList] // 0x000000018980FE90-0x000000018980FED0
	// [XID] // 0x000000018980FE90-0x000000018980FED0
	public bool FromJson(JSONNode node) => default; // 0x000000018414D8D0-0x000000018414DC50
	// [XID] // 0x000000018981A680-0x000000018981A6A0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018414CF10-0x000000018414D1E0
	// [XID] // 0x0000000189821E70-0x0000000189821E90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7157 */, bool useObjectPool = false /* Metadata: 0x00AF715B */) => default; // 0x000000018414DDE0-0x000000018414E0E0
	// [XID] // 0x0000000189829350-0x0000000189829370
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF715C */, bool useObjectPool = false /* Metadata: 0x00AF7160 */) => default; // 0x000000018414D600-0x000000018414D8D0
	[BlackList] // 0x00000001898309C0-0x0000000189830A00
	// [XID] // 0x00000001898309C0-0x0000000189830A00
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018414D1E0-0x000000018414D4B0
	// [XID] // 0x000000018983AFA0-0x000000018983AFC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018414E240-0x000000018414E4E0
	[BlackList] // 0x00000001898427A0-0x00000001898427E0
	// [XID] // 0x00000001898427A0-0x00000001898427E0
	public virtual void AutoAllocTypeFields() {} // 0x000000018414D4B0-0x000000018414D550
	[BlackList] // 0x000000018984CB20-0x000000018984CB60
	// [XID] // 0x000000018984CB20-0x000000018984CB60
	public virtual void AutoRecycleTypeFields() {} // 0x000000018414D550-0x000000018414D600
	[BlackList] // 0x0000000189856C00-0x0000000189856C40
	// [XID] // 0x0000000189856C00-0x0000000189856C40
	public virtual void ReturnToObjectPool() {} // 0x000000018414E730-0x000000018414E7D0
	[BlackList] // 0x00000001898610B0-0x00000001898610F0
	// [XID] // 0x00000001898610B0-0x00000001898610F0
	public virtual void OnPoolAllocated() {} // 0x000000018414E690-0x000000018414E730
	[BlackList] // 0x000000018986B8C0-0x000000018986B900
	// [XID] // 0x000000018986B8C0-0x000000018986B900
	public virtual void OnBeforePoolRecycled() {} // 0x000000018414E5F0-0x000000018414E690
}

