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
public class ConfigNpcTalkScheme : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18813
{
	// Fields
	private uint _npcId; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigTalkScheme[] _talks; // 0x18

	// Properties
	public uint npcId { /* [XID] */ /* 0x0000000189A543B0-0x0000000189A543D0 */ get => default; /* [XID] */ /* 0x0000000189A5BEA0-0x0000000189A5BEC0 */ private set {} } // 0x000000018438FEE0-0x000000018438FF80 0x0000000184390770-0x0000000184390820
	public ConfigTalkScheme[] talks { /* [XID] */ /* 0x0000000189A636F0-0x0000000189A63710 */ get => default; /* [XID] */ /* 0x0000000189A6B030-0x0000000189A6B050 */ private set {} } // 0x0000000184390300-0x00000001843903A0 0x0000000184390A90-0x0000000184390B40

	// Constructors
	public ConfigNpcTalkScheme() {} // 0x0000000184390E30-0x0000000184390E90

	// Methods
	// [XID] // 0x0000000189A727F0-0x0000000189A72810
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184390B40-0x0000000184390C50
	// [XID] // 0x0000000189A7A390-0x0000000189A7A3B0
	public void InitEmpty() {} // 0x00000001843903A0-0x0000000184390470
	[BlackList] // 0x0000000189A817D0-0x0000000189A81810
	// [XID] // 0x0000000189A817D0-0x0000000189A81810
	public bool FromJson(JSONNode node) => default; // 0x000000018438FF80-0x0000000184390300
	// [XID] // 0x0000000189A8C250-0x0000000189A8C270
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018438F570-0x000000018438F820
	// [XID] // 0x0000000189A936D0-0x0000000189A936F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD93 */, bool useObjectPool = false /* Metadata: 0x00AFAD97 */) => default; // 0x0000000184390470-0x0000000184390770
	// [XID] // 0x0000000189A9B320-0x0000000189A9B340
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD98 */, bool useObjectPool = false /* Metadata: 0x00AFAD9C */) => default; // 0x000000018438FC40-0x000000018438FEE0
	[BlackList] // 0x0000000189AA25A0-0x0000000189AA25E0
	// [XID] // 0x0000000189AA25A0-0x0000000189AA25E0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018438F820-0x000000018438FAF0
	// [XID] // 0x0000000189AACE80-0x0000000189AACEA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184390820-0x0000000184390A90
	[BlackList] // 0x0000000189AB4710-0x0000000189AB4750
	// [XID] // 0x0000000189AB4710-0x0000000189AB4750
	public virtual void AutoAllocTypeFields() {} // 0x000000018438FAF0-0x000000018438FB90
	[BlackList] // 0x0000000189ABF110-0x0000000189ABF150
	// [XID] // 0x0000000189ABF110-0x0000000189ABF150
	public virtual void AutoRecycleTypeFields() {} // 0x000000018438FB90-0x000000018438FC40
	[BlackList] // 0x0000000189AC99E0-0x0000000189AC9A20
	// [XID] // 0x0000000189AC99E0-0x0000000189AC9A20
	public virtual void ReturnToObjectPool() {} // 0x0000000184390D90-0x0000000184390E30
	[BlackList] // 0x0000000189AD4670-0x0000000189AD46B0
	// [XID] // 0x0000000189AD4670-0x0000000189AD46B0
	public virtual void OnPoolAllocated() {} // 0x0000000184390CF0-0x0000000184390D90
	[BlackList] // 0x0000000189ADF1B0-0x0000000189ADF1F0
	// [XID] // 0x0000000189ADF1B0-0x0000000189ADF1F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184390C50-0x0000000184390CF0
}

