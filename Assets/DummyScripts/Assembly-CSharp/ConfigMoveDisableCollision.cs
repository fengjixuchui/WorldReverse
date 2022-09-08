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
public class ConfigMoveDisableCollision : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18631
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigEntityCollider[] _selfColliders; // 0x10
	private SimpleSafeFloat delayEnableTimeRawNum; // 0x18

	// Properties
	public ConfigEntityCollider[] selfColliders { /* [XID] */ /* 0x0000000189870570-0x0000000189870590 */ get => default; /* [XID] */ /* 0x0000000189831F90-0x0000000189831FB0 */ private set {} } // 0x0000000184B2E670-0x0000000184B2E710 0x0000000184B2EA10-0x0000000184B2EAC0
	public float delayEnableTime { /* [XID] */ /* 0x0000000189877C80-0x0000000189877CA0 */ get => default; /* [XID] */ /* 0x0000000189840BE0-0x0000000189840C00 */ private set {} } // 0x0000000184B2DD60-0x0000000184B2DE40 0x0000000184B2E110-0x0000000184B2E1F0

	// Constructors
	public ConfigMoveDisableCollision() {} // 0x0000000184B2F020-0x0000000184B2F080

	// Methods
	// [XID] // 0x0000000189848060-0x0000000189848080
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184B2ED30-0x0000000184B2EE40
	// [XID] // 0x000000018984F760-0x000000018984F780
	public void InitEmpty() {} // 0x0000000184B2E570-0x0000000184B2E670
	[BlackList] // 0x00000001898569C0-0x0000000189856A00
	// [XID] // 0x00000001898569C0-0x0000000189856A00
	public bool FromJson(JSONNode node) => default; // 0x0000000184B2E1F0-0x0000000184B2E570
	// [XID] // 0x0000000189860E10-0x0000000189860E30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184B2D5F0-0x0000000184B2D910
	// [XID] // 0x0000000189868690-0x00000001898686B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA665 */, bool useObjectPool = false /* Metadata: 0x00AFA669 */) => default; // 0x0000000184B2E710-0x0000000184B2EA10
	// [XID] // 0x000000018986FAC0-0x000000018986FAE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA66A */, bool useObjectPool = false /* Metadata: 0x00AFA66E */) => default; // 0x0000000184B2DE40-0x0000000184B2E110
	[BlackList] // 0x0000000189877170-0x00000001898771B0
	// [XID] // 0x0000000189877170-0x00000001898771B0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184B2D910-0x0000000184B2DBE0
	// [XID] // 0x0000000189881800-0x0000000189881820
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184B2EAC0-0x0000000184B2ED30
	[BlackList] // 0x0000000189888DA0-0x0000000189888DE0
	// [XID] // 0x0000000189888DA0-0x0000000189888DE0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B2DBE0-0x0000000184B2DC80
	[BlackList] // 0x00000001898932B0-0x00000001898932F0
	// [XID] // 0x00000001898932B0-0x00000001898932F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B2DC80-0x0000000184B2DD60
	[BlackList] // 0x000000018989D480-0x000000018989D4C0
	// [XID] // 0x000000018989D480-0x000000018989D4C0
	public virtual void ReturnToObjectPool() {} // 0x0000000184B2EF80-0x0000000184B2F020
	[BlackList] // 0x00000001898A7AF0-0x00000001898A7B30
	// [XID] // 0x00000001898A7AF0-0x00000001898A7B30
	public virtual void OnPoolAllocated() {} // 0x0000000184B2EEE0-0x0000000184B2EF80
	[BlackList] // 0x00000001898B2290-0x00000001898B22D0
	// [XID] // 0x00000001898B2290-0x00000001898B22D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B2EE40-0x0000000184B2EEE0
}

