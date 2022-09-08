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
public class ConfigGadgetStateAction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14954
{
	// Fields
	private GadgetState _gadgetState; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigGadgetPredicate _predicate; // 0x18

	// Properties
	public GadgetState gadgetState { /* [XID] */ /* 0x0000000189BD2930-0x0000000189BD2950 */ get => default; /* [XID] */ /* 0x00000001897CF910-0x00000001897CF930 */ private set {} } // 0x00000001835DEA20-0x00000001835DEAC0 0x00000001835DF980-0x00000001835DFA30
	public ConfigGadgetPredicate predicate { /* [XID] */ /* 0x00000001895F5DA0-0x00000001895F5DC0 */ get => default; /* [XID] */ /* 0x00000001897DE770-0x00000001897DE790 */ private set {} } // 0x00000001835DE100-0x00000001835DE1A0 0x00000001835DE970-0x00000001835DEA20

	// Constructors
	public ConfigGadgetStateAction() {} // 0x00000001835DFAD0-0x00000001835DFB30

	// Methods
	// [XID] // 0x00000001897B8B20-0x00000001897B8B40
	public virtual void DoAction(BaseEntity entity, GadgetState state) {} // 0x00000001835DEF80-0x00000001835DF040
	// [XID] // 0x0000000189BCB3E0-0x0000000189BCB400
	public virtual bool CheckState(GadgetState curGadgetState) => default; // 0x00000001835DF3F0-0x00000001835DF4B0
	// [XID] // 0x00000001897E6290-0x00000001897E62B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835DF720-0x00000001835DF840
	// [XID] // 0x00000001897EDD30-0x00000001897EDD50
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001835DF320-0x00000001835DF3F0
	// [XID] // 0x00000001897F5430-0x00000001897F5450
	public virtual ConfigGadgetStateAction Clone(bool useObjectPool = false /* Metadata: 0x00AEFBCD */) => default; // 0x00000001835DF040-0x00000001835DF120
	// [XID] // 0x00000001897FCD60-0x00000001897FCD80
	public virtual int GetHashNum() => default; // 0x00000001835DE030-0x00000001835DE100
	// [XID] // 0x00000001898043B0-0x00000001898043D0
	public virtual void InitEmpty() {} // 0x00000001835DEAC0-0x00000001835DEB90
	[BlackList] // 0x000000018980B840-0x000000018980B880
	// [XID] // 0x000000018980B840-0x000000018980B880
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001835DE420-0x00000001835DE7A0
	// [XID] // 0x00000001898160B0-0x00000001898160D0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001835DD8E0-0x00000001835DDB90
	[BlackList] // 0x000000018981DB30-0x000000018981DB70
	// [XID] // 0x000000018981DB30-0x000000018981DB70
	public static ConfigGadgetStateAction ParseFromJson(JSONNode node) => default; // 0x00000001835DF120-0x00000001835DF320
	// [XID] // 0x0000000189828320-0x0000000189828340
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBCE */, bool useObjectPool = false /* Metadata: 0x00AEFBD2 */) => default; // 0x00000001835DEC80-0x00000001835DEF80
	// [XID] // 0x000000018982F600-0x000000018982F620
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBD3 */, bool useObjectPool = false /* Metadata: 0x00AEFBD7 */) => default; // 0x00000001835DE1A0-0x00000001835DE420
	// [XID] // 0x0000000189836F10-0x0000000189836F30
	public static ConfigGadgetStateAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFBD8 */, bool useObjectPool = false /* Metadata: 0x00AEFBDC */) => default; // 0x00000001835DE7A0-0x00000001835DE970
	[BlackList] // 0x000000018983E320-0x000000018983E360
	// [XID] // 0x000000018983E320-0x000000018983E360
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001835DDB90-0x00000001835DDE60
	// [XID] // 0x00000001898485E0-0x0000000189848600
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835DF4B0-0x00000001835DF720
	[BlackList] // 0x000000018984FD00-0x000000018984FD40
	// [XID] // 0x000000018984FD00-0x000000018984FD40
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001835DEB90-0x00000001835DEC80
	[BlackList] // 0x000000018985A370-0x000000018985A3B0
	// [XID] // 0x000000018985A370-0x000000018985A3B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001835DDE60-0x00000001835DDF00
	[BlackList] // 0x0000000189864750-0x0000000189864790
	// [XID] // 0x0000000189864750-0x0000000189864790
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835DDF00-0x00000001835DE030
	[BlackList] // 0x000000018986EC90-0x000000018986ECD0
	// [XID] // 0x000000018986EC90-0x000000018986ECD0
	public virtual void ReturnToObjectPool() {} // 0x00000001835DFA30-0x00000001835DFAD0
	[BlackList] // 0x00000001898792D0-0x0000000189879310
	// [XID] // 0x00000001898792D0-0x0000000189879310
	public virtual void OnPoolAllocated() {} // 0x00000001835DF8E0-0x00000001835DF980
	[BlackList] // 0x0000000189883370-0x00000001898833B0
	// [XID] // 0x0000000189883370-0x00000001898833B0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835DF840-0x00000001835DF8E0
}

