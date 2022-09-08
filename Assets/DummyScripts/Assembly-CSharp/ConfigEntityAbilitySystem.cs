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
public class ConfigEntityAbilitySystem : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16313
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilitySystem[] _onBeingHit; // 0x10

	// Properties
	public ConfigAbilitySystem[] onBeingHit { /* [XID] */ /* 0x00000001899FFE20-0x00000001899FFE40 */ get => default; /* [XID] */ /* 0x0000000189A076F0-0x0000000189A07710 */ private set {} } // 0x0000000181D15E30-0x0000000181D15ED0 0x0000000181D16A30-0x0000000181D16AE0

	// Constructors
	public ConfigEntityAbilitySystem() {} // 0x0000000181D16B80-0x0000000181D16BE0

	// Methods
	// [XID] // 0x0000000189A0EB30-0x0000000189A0EB50
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181D16810-0x0000000181D168F0
	// [XID] // 0x0000000189A162E0-0x0000000189A16300
	public void InitEmpty() {} // 0x0000000181D16250-0x0000000181D16320
	[BlackList] // 0x0000000189A1D840-0x0000000189A1D880
	// [XID] // 0x0000000189A1D840-0x0000000189A1D880
	public bool FromJson(JSONNode node) => default; // 0x0000000181D15ED0-0x0000000181D16250
	// [XID] // 0x0000000189A27C80-0x0000000189A27CA0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181D15630-0x0000000181D15810
	// [XID] // 0x0000000189A2F2D0-0x0000000189A2F2F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF375C */, bool useObjectPool = false /* Metadata: 0x00AF3760 */) => default; // 0x0000000181D16320-0x0000000181D16620
	// [XID] // 0x0000000189A36D30-0x0000000189A36D50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3761 */, bool useObjectPool = false /* Metadata: 0x00AF3765 */) => default; // 0x0000000181D15C20-0x0000000181D15E30
	[BlackList] // 0x0000000189A3E310-0x0000000189A3E350
	// [XID] // 0x0000000189A3E310-0x0000000189A3E350
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181D15810-0x0000000181D15AE0
	// [XID] // 0x0000000189A48990-0x0000000189A489B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181D16620-0x0000000181D16810
	[BlackList] // 0x0000000189A50100-0x0000000189A50140
	// [XID] // 0x0000000189A50100-0x0000000189A50140
	public virtual void AutoAllocTypeFields() {} // 0x0000000181D15AE0-0x0000000181D15B80
	[BlackList] // 0x0000000189A5A850-0x0000000189A5A890
	// [XID] // 0x0000000189A5A850-0x0000000189A5A890
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181D15B80-0x0000000181D15C20
	[BlackList] // 0x0000000189A65420-0x0000000189A65460
	// [XID] // 0x0000000189A65420-0x0000000189A65460
	public virtual void ReturnToObjectPool() {} // 0x0000000181D16AE0-0x0000000181D16B80
	[BlackList] // 0x0000000189A6FC00-0x0000000189A6FC40
	// [XID] // 0x0000000189A6FC00-0x0000000189A6FC40
	public virtual void OnPoolAllocated() {} // 0x0000000181D16990-0x0000000181D16A30
	[BlackList] // 0x0000000189A7A7F0-0x0000000189A7A830
	// [XID] // 0x0000000189A7A7F0-0x0000000189A7A830
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181D168F0-0x0000000181D16990
}

