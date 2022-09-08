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
public class ConfigAINetworkSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17506
{
	// Fields
	private bool _syncSkill; // 0x10
	private bool _resetHpOnSpawn; // 0x11

	// Properties
	public bool syncSkill { /* [XID] */ /* 0x000000018990A6C0-0x000000018990A6E0 */ get => default; /* [XID] */ /* 0x000000018990E750-0x000000018990E770 */ private set {} } // 0x0000000182A8D9A0-0x0000000182A8DA40 0x0000000182A8DED0-0x0000000182A8DF80
	public bool resetHpOnSpawn { /* [XID] */ /* 0x0000000189915DC0-0x0000000189915DE0 */ get => default; /* [XID] */ /* 0x000000018991D8D0-0x000000018991D8F0 */ private set {} } // 0x0000000182A8D4B0-0x0000000182A8D550 0x0000000182A8D8F0-0x0000000182A8D9A0

	// Constructors
	public ConfigAINetworkSetting() {} // 0x0000000182A8E020-0x0000000182A8E090

	// Methods
	// [XID] // 0x0000000189925040-0x0000000189925060
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A8DC80-0x0000000182A8DD90
	// [XID] // 0x000000018992C620-0x000000018992C640
	public void InitEmpty() {} // 0x0000000182A8D550-0x0000000182A8D5F0
	[BlackList] // 0x0000000189933CE0-0x0000000189933D20
	// [XID] // 0x0000000189933CE0-0x0000000189933D20
	public bool FromJson(JSONNode node) => default; // 0x0000000182A8D130-0x0000000182A8D4B0
	// [XID] // 0x000000018993E5F0-0x000000018993E610
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182A8C850-0x0000000182A8CAD0
	// [XID] // 0x0000000189945C60-0x0000000189945C80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7111 */, bool useObjectPool = false /* Metadata: 0x00AF7115 */) => default; // 0x0000000182A8D5F0-0x0000000182A8D8F0
	// [XID] // 0x000000018994D130-0x000000018994D150
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7116 */, bool useObjectPool = false /* Metadata: 0x00AF711A */) => default; // 0x0000000182A8CEE0-0x0000000182A8D130
	[BlackList] // 0x0000000189954860-0x00000001899548A0
	// [XID] // 0x0000000189954860-0x00000001899548A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A8CAD0-0x0000000182A8CDA0
	// [XID] // 0x000000018995F250-0x000000018995F270
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A8DA40-0x0000000182A8DC80
	[BlackList] // 0x0000000189966BB0-0x0000000189966BF0
	// [XID] // 0x0000000189966BB0-0x0000000189966BF0
	public virtual void AutoAllocTypeFields() {} // 0x0000000182A8CDA0-0x0000000182A8CE40
	[BlackList] // 0x0000000189971760-0x00000001899717A0
	// [XID] // 0x0000000189971760-0x00000001899717A0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182A8CE40-0x0000000182A8CEE0
	[BlackList] // 0x000000018997BA60-0x000000018997BAA0
	// [XID] // 0x000000018997BA60-0x000000018997BAA0
	public virtual void ReturnToObjectPool() {} // 0x0000000182A8DF80-0x0000000182A8E020
	[BlackList] // 0x0000000189986090-0x00000001899860D0
	// [XID] // 0x0000000189986090-0x00000001899860D0
	public virtual void OnPoolAllocated() {} // 0x0000000182A8DE30-0x0000000182A8DED0
	[BlackList] // 0x0000000189990DD0-0x0000000189990E10
	// [XID] // 0x0000000189990DD0-0x0000000189990E10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182A8DD90-0x0000000182A8DE30
}

