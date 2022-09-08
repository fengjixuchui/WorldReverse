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
public class ConfigBaseStateIDInfo : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 19026
{
	// Fields
	private SimpleSafeInt32 priorityRawNum; // 0x10

	// Properties
	public int priority { /* [XID] */ /* 0x000000018979D4B0-0x000000018979D4D0 */ get => default; /* [XID] */ /* 0x00000001897A47B0-0x00000001897A47D0 */ private set {} } // 0x000000018278CC40-0x000000018278CD10 0x000000018278C070-0x000000018278C150

	// Constructors
	public ConfigBaseStateIDInfo() {} // 0x000000018278D550-0x000000018278D5E0

	// Methods
	// [XID] // 0x00000001897ABCC0-0x00000001897ABCE0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018278D290-0x000000018278D370
	// [XID] // 0x00000001897B3C90-0x00000001897B3CB0
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018278CF10-0x000000018278CFC0
	// [XID] // 0x00000001897BBA70-0x00000001897BBA90
	public virtual ConfigBaseStateIDInfo Clone(bool useObjectPool = false /* Metadata: 0x00AFB7E9 */) => default; // 0x000000018278CB60-0x000000018278CC40
	// [XID] // 0x00000001897C32F0-0x00000001897C3310
	public virtual int GetHashNum() => default; // 0x000000018278BDD0-0x000000018278BEA0
	// [XID] // 0x00000001897CAAB0-0x00000001897CAAD0
	public virtual void InitEmpty() {} // 0x000000018278C6A0-0x000000018278C770
	[BlackList] // 0x00000001897D20B0-0x00000001897D20F0
	// [XID] // 0x00000001897D20B0-0x00000001897D20F0
	public virtual bool FromJson(JSONNode node) => default; // 0x000000018278C150-0x000000018278C4D0
	// [XID] // 0x00000001897DC8B0-0x00000001897DC8D0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018278B790-0x000000018278B990
	[BlackList] // 0x00000001897E42D0-0x00000001897E4310
	// [XID] // 0x00000001897E42D0-0x00000001897E4310
	public static ConfigBaseStateIDInfo ParseFromJson(JSONNode node) => default; // 0x000000018278CD10-0x000000018278CF10
	// [XID] // 0x00000001897EED70-0x00000001897EED90
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7EA */, bool useObjectPool = false /* Metadata: 0x00AFB7EE */) => default; // 0x000000018278C860-0x000000018278CB60
	// [XID] // 0x00000001897F6440-0x00000001897F6460
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7EF */, bool useObjectPool = false /* Metadata: 0x00AFB7F3 */) => default; // 0x000000018278BEA0-0x000000018278C070
	// [XID] // 0x00000001897FDB20-0x00000001897FDB40
	public static ConfigBaseStateIDInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB7F4 */, bool useObjectPool = false /* Metadata: 0x00AFB7F8 */) => default; // 0x000000018278C4D0-0x000000018278C6A0
	[BlackList] // 0x00000001898052D0-0x0000000189805310
	// [XID] // 0x00000001898052D0-0x0000000189805310
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x000000018278B990-0x000000018278BC60
	// [XID] // 0x000000018980FB90-0x000000018980FBB0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018278D0B0-0x000000018278D290
	[BlackList] // 0x0000000189817200-0x0000000189817240
	// [XID] // 0x0000000189817200-0x0000000189817240
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018278C770-0x000000018278C860
	[BlackList] // 0x0000000189821C30-0x0000000189821C70
	// [XID] // 0x0000000189821C30-0x0000000189821C70
	public virtual void AutoAllocTypeFields() {} // 0x000000018278BC60-0x000000018278BD00
	[BlackList] // 0x000000018982C350-0x000000018982C390
	// [XID] // 0x000000018982C350-0x000000018982C390
	public virtual void AutoRecycleTypeFields() {} // 0x000000018278BD00-0x000000018278BDD0
	[BlackList] // 0x0000000189836710-0x0000000189836750
	// [XID] // 0x0000000189836710-0x0000000189836750
	public virtual void ReturnToObjectPool() {} // 0x000000018278D4B0-0x000000018278D550
	[BlackList] // 0x0000000189840BA0-0x0000000189840BE0
	// [XID] // 0x0000000189840BA0-0x0000000189840BE0
	public virtual void OnPoolAllocated() {} // 0x000000018278D410-0x000000018278D4B0
	[BlackList] // 0x000000018984B090-0x000000018984B0D0
	// [XID] // 0x000000018984B090-0x000000018984B0D0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018278D370-0x000000018278D410
	// [XID] // 0x0000000189855230-0x0000000189855250
	public virtual void HandleAnimatorState(BaseEntity entity, bool isTo, int fromStateID, int toStateID, VCAnimatorEvent animatorComponent) {} // 0x000000018278CFC0-0x000000018278D0B0
}

