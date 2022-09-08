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
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigLevelLayout : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14970
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigLevelBlock[] _blocks; // 0x10

	// Properties
	public ConfigLevelBlock[] blocks { /* [XID] */ /* 0x00000001897DD030-0x00000001897DD050 */ get => default; /* [XID] */ /* 0x00000001897E4950-0x00000001897E4970 */ private set {} } // 0x0000000185782EA0-0x0000000185782F40 0x0000000185783130-0x00000001857831E0

	// Constructors
	public ConfigLevelLayout() {} // 0x00000001857834A0-0x0000000185783500

	// Methods
	// [XID] // 0x00000001897D5950-0x00000001897D5970
	public ConfigLevelArea FindArea(Vector3 worldPosition) => default; // 0x0000000185782C30-0x0000000185782EA0
	// [XID] // 0x00000001897EC560-0x00000001897EC580
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001857831E0-0x00000001857832C0
	// [XID] // 0x00000001897F3ED0-0x00000001897F3EF0
	public void InitEmpty() {} // 0x0000000185782860-0x0000000185782930
	[BlackList] // 0x00000001897FB830-0x00000001897FB870
	// [XID] // 0x00000001897FB830-0x00000001897FB870
	public bool FromJson(JSONNode node) => default; // 0x00000001857824E0-0x0000000185782860
	// [XID] // 0x00000001898058B0-0x00000001898058D0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185781CE0-0x0000000185781EC0
	// [XID] // 0x000000018980CFD0-0x000000018980CFF0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCBA */, bool useObjectPool = false /* Metadata: 0x00AEFCBE */) => default; // 0x0000000185782930-0x0000000185782C30
	// [XID] // 0x0000000189814790-0x00000001898147B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFCBF */, bool useObjectPool = false /* Metadata: 0x00AEFCC3 */) => default; // 0x00000001857822D0-0x00000001857824E0
	[BlackList] // 0x000000018981C1C0-0x000000018981C200
	// [XID] // 0x000000018981C1C0-0x000000018981C200
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185781EC0-0x0000000185782190
	// [XID] // 0x0000000189826850-0x0000000189826870
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185782F40-0x0000000185783130
	[BlackList] // 0x000000018982DF80-0x000000018982DFC0
	// [XID] // 0x000000018982DF80-0x000000018982DFC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185782190-0x0000000185782230
	[BlackList] // 0x0000000189838560-0x00000001898385A0
	// [XID] // 0x0000000189838560-0x00000001898385A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185782230-0x00000001857822D0
	[BlackList] // 0x0000000189842C20-0x0000000189842C60
	// [XID] // 0x0000000189842C20-0x0000000189842C60
	public virtual void ReturnToObjectPool() {} // 0x0000000185783400-0x00000001857834A0
	[BlackList] // 0x000000018984D040-0x000000018984D080
	// [XID] // 0x000000018984D040-0x000000018984D080
	public virtual void OnPoolAllocated() {} // 0x0000000185783360-0x0000000185783400
	[BlackList] // 0x0000000189857160-0x00000001898571A0
	// [XID] // 0x0000000189857160-0x00000001898571A0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001857832C0-0x0000000185783360
}

