/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigModeStateMap : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18801
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigActionPanelState> _states; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<PlayModeType, ConfigActionPanelMode> _modes; // 0x18

	// Properties
	public Dictionary<string, ConfigActionPanelState> states { /* [XID] */ /* 0x0000000189BB0DF0-0x0000000189BB0E10 */ get => default; /* [XID] */ /* 0x0000000189BB7F80-0x0000000189BB7FA0 */ private set {} } // 0x00000001817ED3C0-0x00000001817ED460 0x00000001817ECA70-0x00000001817ECB20
	public Dictionary<PlayModeType, ConfigActionPanelMode> modes { /* [XID] */ /* 0x0000000189BBF710-0x0000000189BBF730 */ get => default; /* [XID] */ /* 0x0000000189BC7320-0x0000000189BC7340 */ private set {} } // 0x00000001817EC290-0x00000001817EC330 0x00000001817ED0C0-0x00000001817ED170

	// Constructors
	public ConfigModeStateMap() {} // 0x00000001817ED500-0x00000001817ED560

	// Methods
	// [XID] // 0x0000000189BCF030-0x0000000189BCF050
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001817ED170-0x00000001817ED280
	// [XID] // 0x0000000189BD6400-0x0000000189BD6420
	public void InitEmpty() {} // 0x00000001817EC980-0x00000001817ECA70
	[BlackList] // 0x0000000189BDDE80-0x0000000189BDDEC0
	// [XID] // 0x0000000189BDDE80-0x0000000189BDDEC0
	public bool FromJson(JSONNode node) => default; // 0x00000001817EC600-0x00000001817EC980
	// [XID] // 0x00000001895ED9D0-0x00000001895ED9F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001817EBB70-0x00000001817EBE40
	// [XID] // 0x00000001895F5150-0x00000001895F5170
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD27 */, bool useObjectPool = false /* Metadata: 0x00AFAD2B */) => default; // 0x00000001817ECB20-0x00000001817ECE20
	// [XID] // 0x00000001895FC770-0x00000001895FC790
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD2C */, bool useObjectPool = false /* Metadata: 0x00AFAD30 */) => default; // 0x00000001817EC330-0x00000001817EC600
	[BlackList] // 0x00000001896040D0-0x0000000189604110
	// [XID] // 0x00000001896040D0-0x0000000189604110
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001817EBE40-0x00000001817EC110
	// [XID] // 0x000000018960E8A0-0x000000018960E8C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001817ECE20-0x00000001817ED0C0
	[BlackList] // 0x0000000189615EE0-0x0000000189615F20
	// [XID] // 0x0000000189615EE0-0x0000000189615F20
	public virtual void AutoAllocTypeFields() {} // 0x00000001817EC110-0x00000001817EC1B0
	[BlackList] // 0x0000000189620720-0x0000000189620760
	// [XID] // 0x0000000189620720-0x0000000189620760
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817EC1B0-0x00000001817EC290
	[BlackList] // 0x000000018962AD20-0x000000018962AD60
	// [XID] // 0x000000018962AD20-0x000000018962AD60
	public virtual void ReturnToObjectPool() {} // 0x00000001817ED460-0x00000001817ED500
	[BlackList] // 0x0000000189635A10-0x0000000189635A50
	// [XID] // 0x0000000189635A10-0x0000000189635A50
	public virtual void OnPoolAllocated() {} // 0x00000001817ED320-0x00000001817ED3C0
	[BlackList] // 0x000000018963FD70-0x000000018963FDB0
	// [XID] // 0x000000018963FD70-0x000000018963FDB0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001817ED280-0x00000001817ED320
}

