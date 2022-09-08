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
public class ConfigLevelActionPoint : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18466
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigActionPoint[] _actionPoints; // 0x18

	// Properties
	public uint sceneId { /* [XID] */ /* 0x00000001896D3460-0x00000001896D3480 */ get => default; /* [XID] */ /* 0x00000001896DB020-0x00000001896DB040 */ private set {} } // 0x0000000181831330-0x0000000181831400 0x0000000181831700-0x00000001818317E0
	public ConfigActionPoint[] actionPoints { /* [XID] */ /* 0x00000001896E2820-0x00000001896E2840 */ get => default; /* [XID] */ /* 0x00000001896E9DC0-0x00000001896E9DE0 */ private set {} } // 0x0000000181831A80-0x0000000181831B20 0x0000000181830B30-0x0000000181830BE0

	// Constructors
	public ConfigLevelActionPoint() {} // 0x0000000181831E10-0x0000000181831E70

	// Methods
	// [XID] // 0x00000001896F0E80-0x00000001896F0EA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181831B20-0x0000000181831C30
	// [XID] // 0x00000001896F86C0-0x00000001896F86E0
	public void InitEmpty() {} // 0x0000000181831230-0x0000000181831330
	[BlackList] // 0x0000000189700020-0x0000000189700060
	// [XID] // 0x0000000189700020-0x0000000189700060
	public bool FromJson(JSONNode node) => default; // 0x0000000181830EB0-0x0000000181831230
	// [XID] // 0x000000018970A720-0x000000018970A740
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001818303E0-0x00000001818306E0
	// [XID] // 0x00000001897121D0-0x00000001897121F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9E7B */, bool useObjectPool = false /* Metadata: 0x00AF9E7F */) => default; // 0x0000000181831400-0x0000000181831700
	// [XID] // 0x0000000189719850-0x0000000189719870
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9E80 */, bool useObjectPool = false /* Metadata: 0x00AF9E84 */) => default; // 0x0000000181830BE0-0x0000000181830EB0
	[BlackList] // 0x0000000189720DD0-0x0000000189720E10
	// [XID] // 0x0000000189720DD0-0x0000000189720E10
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001818306E0-0x00000001818309B0
	// [XID] // 0x000000018972B1F0-0x000000018972B210
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001818317E0-0x0000000181831A80
	[BlackList] // 0x00000001897329E0-0x0000000189732A20
	// [XID] // 0x00000001897329E0-0x0000000189732A20
	public virtual void AutoAllocTypeFields() {} // 0x00000001818309B0-0x0000000181830A50
	[BlackList] // 0x000000018973D470-0x000000018973D4B0
	// [XID] // 0x000000018973D470-0x000000018973D4B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181830A50-0x0000000181830B30
	[BlackList] // 0x0000000189747B70-0x0000000189747BB0
	// [XID] // 0x0000000189747B70-0x0000000189747BB0
	public virtual void ReturnToObjectPool() {} // 0x0000000181831D70-0x0000000181831E10
	[BlackList] // 0x0000000189752090-0x00000001897520D0
	// [XID] // 0x0000000189752090-0x00000001897520D0
	public virtual void OnPoolAllocated() {} // 0x0000000181831CD0-0x0000000181831D70
	[BlackList] // 0x000000018975C650-0x000000018975C690
	// [XID] // 0x000000018975C650-0x000000018975C690
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181831C30-0x0000000181831CD0
}

