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
public class ConfigPreload : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18804
{
	// Fields
	private Dictionary<ConfigPreloadType, string[]> _effects; // 0x10
	private Dictionary<ConfigPreloadType, string[]> _abilities; // 0x18
	private Dictionary<ConfigPreloadType, string[]> _gadgets; // 0x20
	private Dictionary<ConfigPreloadType, string[]> _cameras; // 0x28
	private Dictionary<ConfigPreloadType, string[]> _animEventPatterns; // 0x30
	private Dictionary<ConfigPreloadType, string[]> _skillIcons; // 0x38

	// Properties
	public Dictionary<ConfigPreloadType, string[]> effects { /* [XID] */ /* 0x0000000189660C90-0x0000000189660CB0 */ get => default; /* [XID] */ /* 0x00000001896685C0-0x00000001896685E0 */ private set {} } // 0x00000001837DFEE0-0x00000001837DFF80 0x00000001837DECA0-0x00000001837DED50
	public Dictionary<ConfigPreloadType, string[]> abilities { /* [XID] */ /* 0x0000000189670050-0x0000000189670070 */ get => default; /* [XID] */ /* 0x00000001896779B0-0x00000001896779D0 */ private set {} } // 0x00000001837DF780-0x00000001837DF820 0x00000001837E05A0-0x00000001837E0650
	public Dictionary<ConfigPreloadType, string[]> gadgets { /* [XID] */ /* 0x000000018967EEC0-0x000000018967EEE0 */ get => default; /* [XID] */ /* 0x0000000189686830-0x0000000189686850 */ private set {} } // 0x00000001837DE1A0-0x00000001837DE240 0x00000001837DF6D0-0x00000001837DF780
	public Dictionary<ConfigPreloadType, string[]> cameras { /* [XID] */ /* 0x000000018968E610-0x000000018968E630 */ get => default; /* [XID] */ /* 0x0000000189695FF0-0x0000000189696010 */ private set {} } // 0x00000001837DF820-0x00000001837DF8C0 0x00000001837E04F0-0x00000001837E05A0
	public Dictionary<ConfigPreloadType, string[]> animEventPatterns { /* [XID] */ /* 0x000000018969D6F0-0x000000018969D710 */ get => default; /* [XID] */ /* 0x00000001896A47C0-0x00000001896A47E0 */ private set {} } // 0x00000001837DFE40-0x00000001837DFEE0 0x00000001837DF2A0-0x00000001837DF350
	public Dictionary<ConfigPreloadType, string[]> skillIcons { /* [XID] */ /* 0x00000001896ABF30-0x00000001896ABF50 */ get => default; /* [XID] */ /* 0x00000001896B3190-0x00000001896B31B0 */ private set {} } // 0x00000001837DF9F0-0x00000001837DFA90 0x00000001837DFD90-0x00000001837DFE40

	// Constructors
	public ConfigPreload() {} // 0x00000001837E09A0-0x00000001837E0A00

	// Methods
	// [XID] // 0x00000001896BA910-0x00000001896BA930
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837E0650-0x00000001837E07C0
	// [XID] // 0x00000001896C1980-0x00000001896C19A0
	public void InitEmpty() {} // 0x00000001837DF8C0-0x00000001837DF9F0
	[BlackList] // 0x00000001896C9090-0x00000001896C90D0
	// [XID] // 0x00000001896C9090-0x00000001896C90D0
	public bool FromJson(JSONNode node) => default; // 0x00000001837DF350-0x00000001837DF6D0
	// [XID] // 0x00000001896D33A0-0x00000001896D33C0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001837DE240-0x00000001837DE880
	// [XID] // 0x00000001896DAF40-0x00000001896DAF60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD39 */, bool useObjectPool = false /* Metadata: 0x00AFAD3D */) => default; // 0x00000001837DFA90-0x00000001837DFD90
	// [XID] // 0x00000001896E27A0-0x00000001896E27C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFAD3E */, bool useObjectPool = false /* Metadata: 0x00AFAD42 */) => default; // 0x00000001837DED50-0x00000001837DF2A0
	[BlackList] // 0x00000001896E9CC0-0x00000001896E9D00
	// [XID] // 0x00000001896E9CC0-0x00000001896E9D00
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001837DE880-0x00000001837DEB50
	// [XID] // 0x00000001896F41A0-0x00000001896F41C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837DFF80-0x00000001837E04F0
	[BlackList] // 0x00000001896FB9F0-0x00000001896FBA30
	// [XID] // 0x00000001896FB9F0-0x00000001896FBA30
	public virtual void AutoAllocTypeFields() {} // 0x00000001837DEB50-0x00000001837DEBF0
	[BlackList] // 0x0000000189705E00-0x0000000189705E40
	// [XID] // 0x0000000189705E00-0x0000000189705E40
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837DEBF0-0x00000001837DECA0
	[BlackList] // 0x0000000189710810-0x0000000189710850
	// [XID] // 0x0000000189710810-0x0000000189710850
	public virtual void ReturnToObjectPool() {} // 0x00000001837E0900-0x00000001837E09A0
	[BlackList] // 0x000000018971AF40-0x000000018971AF80
	// [XID] // 0x000000018971AF40-0x000000018971AF80
	public virtual void OnPoolAllocated() {} // 0x00000001837E0860-0x00000001837E0900
	[BlackList] // 0x00000001897253E0-0x0000000189725420
	// [XID] // 0x00000001897253E0-0x0000000189725420
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837E07C0-0x00000001837E0860
}

