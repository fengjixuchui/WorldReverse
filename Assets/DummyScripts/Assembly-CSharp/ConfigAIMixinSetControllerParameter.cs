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
public class ConfigAIMixinSetControllerParameter : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17512
{
	// Fields
	private EntityType[] _entityTypes; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIMixinActions _onSuccess; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAIMixinActions _onFail; // 0x20

	// Properties
	public EntityType[] entityTypes { /* [XID] */ /* 0x000000018972FD90-0x000000018972FDB0 */ get => default; /* [XID] */ /* 0x0000000189737700-0x0000000189737720 */ private set {} } // 0x0000000182357EE0-0x0000000182357F80 0x0000000182358380-0x0000000182358430
	public ConfigAIMixinActions onSuccess { /* [XID] */ /* 0x000000018973F200-0x000000018973F220 */ get => default; /* [XID] */ /* 0x00000001897464A0-0x00000001897464C0 */ private set {} } // 0x0000000182357650-0x00000001823576F0 0x0000000182357E30-0x0000000182357EE0
	public ConfigAIMixinActions onFail { /* [XID] */ /* 0x0000000189BC6780-0x0000000189BC67A0 */ get => default; /* [XID] */ /* 0x00000001897556B0-0x00000001897556D0 */ private set {} } // 0x0000000182358A00-0x0000000182358AA0 0x00000001823575A0-0x0000000182357650

	// Constructors
	public ConfigAIMixinSetControllerParameter() {} // 0x0000000182358B40-0x0000000182358BA0

	// Methods
	// [XID] // 0x000000018975C8F0-0x000000018975C910
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182358770-0x00000001823588C0
	// [XID] // 0x0000000189764100-0x0000000189764120
	public void InitEmpty() {} // 0x0000000182357F80-0x0000000182358080
	[BlackList] // 0x000000018976B9E0-0x000000018976BA20
	// [XID] // 0x000000018976B9E0-0x000000018976BA20
	public bool FromJson(JSONNode node) => default; // 0x0000000182357AB0-0x0000000182357E30
	// [XID] // 0x00000001897760C0-0x00000001897760E0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182356CA0-0x0000000182357080
	// [XID] // 0x000000018977D760-0x000000018977D780
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF714D */, bool useObjectPool = false /* Metadata: 0x00AF7151 */) => default; // 0x0000000182358080-0x0000000182358380
	// [XID] // 0x0000000189785040-0x0000000189785060
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7152 */, bool useObjectPool = false /* Metadata: 0x00AF7156 */) => default; // 0x00000001823576F0-0x0000000182357AB0
	[BlackList] // 0x000000018978C510-0x000000018978C550
	// [XID] // 0x000000018978C510-0x000000018978C550
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182357080-0x0000000182357350
	// [XID] // 0x0000000189796C70-0x0000000189796C90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182358430-0x0000000182358770
	[BlackList] // 0x000000018979EDB0-0x000000018979EDF0
	// [XID] // 0x000000018979EDB0-0x000000018979EDF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182357350-0x00000001823573F0
	[BlackList] // 0x00000001897A91C0-0x00000001897A9200
	// [XID] // 0x00000001897A91C0-0x00000001897A9200
	public virtual void AutoRecycleTypeFields() {} // 0x00000001823573F0-0x00000001823575A0
	[BlackList] // 0x00000001897B3FB0-0x00000001897B3FF0
	// [XID] // 0x00000001897B3FB0-0x00000001897B3FF0
	public virtual void ReturnToObjectPool() {} // 0x0000000182358AA0-0x0000000182358B40
	[BlackList] // 0x00000001897BF0D0-0x00000001897BF110
	// [XID] // 0x00000001897BF0D0-0x00000001897BF110
	public virtual void OnPoolAllocated() {} // 0x0000000182358960-0x0000000182358A00
	[BlackList] // 0x00000001897C9680-0x00000001897C96C0
	// [XID] // 0x00000001897C9680-0x00000001897C96C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001823588C0-0x0000000182358960
}

