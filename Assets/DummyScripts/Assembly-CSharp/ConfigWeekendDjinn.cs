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
public class ConfigWeekendDjinn : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18944
{
	// Fields
	private MoleMole.Config.Vector _spawnPos; // 0x10
	private MoleMole.Config.Vector _spawnRot; // 0x1C
	private MoleMole.Config.Vector _pos; // 0x28
	private MoleMole.Config.Vector _rot; // 0x34

	// Properties
	public MoleMole.Config.Vector spawnPos { /* [XID] */ /* 0x0000000189B14DD0-0x0000000189B14DF0 */ get => default; /* [XID] */ /* 0x0000000189B1C710-0x0000000189B1C730 */ private set {} } // 0x000000018482A8B0-0x000000018482A990 0x000000018482B6A0-0x000000018482B770
	public MoleMole.Config.Vector spawnRot { /* [XID] */ /* 0x0000000189B23CE0-0x0000000189B23D00 */ get => default; /* [XID] */ /* 0x0000000189B2AFA0-0x0000000189B2AFC0 */ private set {} } // 0x000000018482B770-0x000000018482B850 0x000000018482B5D0-0x000000018482B6A0
	public MoleMole.Config.Vector pos { /* [XID] */ /* 0x0000000189B325A0-0x0000000189B325C0 */ get => default; /* [XID] */ /* 0x0000000189B39E70-0x0000000189B39E90 */ private set {} } // 0x000000018482B0E0-0x000000018482B1C0 0x000000018482A7E0-0x000000018482A8B0
	public MoleMole.Config.Vector rot { /* [XID] */ /* 0x0000000189B41770-0x0000000189B41790 */ get => default; /* [XID] */ /* 0x0000000189B49120-0x0000000189B49140 */ private set {} } // 0x0000000184829D60-0x0000000184829E40 0x000000018482A710-0x000000018482A7E0

	// Constructors
	public ConfigWeekendDjinn() {} // 0x000000018482C040-0x000000018482C0A0

	// Methods
	// [XID] // 0x0000000189B50760-0x0000000189B50780
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018482BCD0-0x000000018482BE60
	// [XID] // 0x0000000189B58080-0x0000000189B580A0
	public void InitEmpty() {} // 0x000000018482B1C0-0x000000018482B2D0
	[BlackList] // 0x0000000189B5F9C0-0x0000000189B5FA00
	// [XID] // 0x0000000189B5F9C0-0x0000000189B5FA00
	public bool FromJson(JSONNode node) => default; // 0x000000018482AD60-0x000000018482B0E0
	// [XID] // 0x0000000189B69FD0-0x0000000189B69FF0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184829E40-0x000000018482A2B0
	// [XID] // 0x0000000189B715F0-0x0000000189B71610
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB481 */, bool useObjectPool = false /* Metadata: 0x00AFB485 */) => default; // 0x000000018482B2D0-0x000000018482B5D0
	// [XID] // 0x0000000189B78BC0-0x0000000189B78BE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB486 */, bool useObjectPool = false /* Metadata: 0x00AFB48A */) => default; // 0x000000018482A990-0x000000018482AD60
	[BlackList] // 0x0000000189B7FFF0-0x0000000189B80030
	// [XID] // 0x0000000189B7FFF0-0x0000000189B80030
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018482A2B0-0x000000018482A580
	// [XID] // 0x0000000189B8A750-0x0000000189B8A770
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018482B850-0x000000018482BCD0
	[BlackList] // 0x0000000189B91D20-0x0000000189B91D60
	// [XID] // 0x0000000189B91D20-0x0000000189B91D60
	public virtual void AutoAllocTypeFields() {} // 0x000000018482A580-0x000000018482A620
	[BlackList] // 0x0000000189B9C1E0-0x0000000189B9C220
	// [XID] // 0x0000000189B9C1E0-0x0000000189B9C220
	public virtual void AutoRecycleTypeFields() {} // 0x000000018482A620-0x000000018482A710
	[BlackList] // 0x0000000189BA6700-0x0000000189BA6740
	// [XID] // 0x0000000189BA6700-0x0000000189BA6740
	public virtual void ReturnToObjectPool() {} // 0x000000018482BFA0-0x000000018482C040
	[BlackList] // 0x0000000189BB0D90-0x0000000189BB0DD0
	// [XID] // 0x0000000189BB0D90-0x0000000189BB0DD0
	public virtual void OnPoolAllocated() {} // 0x000000018482BF00-0x000000018482BFA0
	[BlackList] // 0x0000000189BBB030-0x0000000189BBB070
	// [XID] // 0x0000000189BBB030-0x0000000189BBB070
	public virtual void OnBeforePoolRecycled() {} // 0x000000018482BE60-0x000000018482BF00
}

