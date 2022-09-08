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
public class ConfigCrowdSpawnInfos : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17775
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCrowdSpawnInfo[] _crowdSpawnInfos; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigCrowdGroupColliderInfo[] _crowdGroupColliderInfos; // 0x18

	// Properties
	public ConfigCrowdSpawnInfo[] crowdSpawnInfos { /* [XID] */ /* 0x0000000189747D00-0x0000000189747D20 */ get => default; /* [XID] */ /* 0x000000018974F4B0-0x000000018974F4D0 */ private set {} } // 0x0000000185138010-0x00000001851380B0 0x0000000185136EE0-0x0000000185136F90
	public ConfigCrowdGroupColliderInfo[] crowdGroupColliderInfos { /* [XID] */ /* 0x0000000189756AE0-0x0000000189756B00 */ get => default; /* [XID] */ /* 0x000000018975DF90-0x000000018975DFB0 */ private set {} } // 0x0000000185137310-0x00000001851373B0 0x0000000185136F90-0x0000000185137040

	// Constructors
	public ConfigCrowdSpawnInfos() {} // 0x0000000185138150-0x00000001851381B0

	// Methods
	// [XID] // 0x0000000189765710-0x0000000189765730
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185137DC0-0x0000000185137ED0
	// [XID] // 0x000000018976CFA0-0x000000018976CFC0
	public void InitEmpty() {} // 0x0000000185137730-0x0000000185137820
	[BlackList] // 0x0000000189774410-0x0000000189774450
	// [XID] // 0x0000000189774410-0x0000000189774450
	public bool FromJson(JSONNode node) => default; // 0x00000001851373B0-0x0000000185137730
	// [XID] // 0x000000018977ECE0-0x000000018977ED00
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001851367F0-0x0000000185136AC0
	// [XID] // 0x00000001897866C0-0x00000001897866E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BC3 */, bool useObjectPool = false /* Metadata: 0x00AF7BC7 */) => default; // 0x0000000185137820-0x0000000185137B20
	// [XID] // 0x000000018978DD10-0x000000018978DD30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7BC8 */, bool useObjectPool = false /* Metadata: 0x00AF7BCC */) => default; // 0x0000000185137040-0x0000000185137310
	[BlackList] // 0x0000000189795340-0x0000000189795380
	// [XID] // 0x0000000189795340-0x0000000189795380
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185136AC0-0x0000000185136D90
	// [XID] // 0x00000001897A0310-0x00000001897A0330
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185137B20-0x0000000185137DC0
	[BlackList] // 0x00000001897A7880-0x00000001897A78C0
	// [XID] // 0x00000001897A7880-0x00000001897A78C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000185136D90-0x0000000185136E30
	[BlackList] // 0x00000001897B21D0-0x00000001897B2210
	// [XID] // 0x00000001897B21D0-0x00000001897B2210
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185136E30-0x0000000185136EE0
	[BlackList] // 0x00000001897BD620-0x00000001897BD660
	// [XID] // 0x00000001897BD620-0x00000001897BD660
	public virtual void ReturnToObjectPool() {} // 0x00000001851380B0-0x0000000185138150
	[BlackList] // 0x00000001897C7F70-0x00000001897C7FB0
	// [XID] // 0x00000001897C7F70-0x00000001897C7FB0
	public virtual void OnPoolAllocated() {} // 0x0000000185137F70-0x0000000185138010
	[BlackList] // 0x00000001897D22B0-0x00000001897D22F0
	// [XID] // 0x00000001897D22B0-0x00000001897D22F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185137ED0-0x0000000185137F70
}

