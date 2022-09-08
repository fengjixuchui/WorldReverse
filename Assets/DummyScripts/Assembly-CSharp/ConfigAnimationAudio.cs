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
public class ConfigAnimationAudio : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17518
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigStateAudioEvent[] _onTransitionIn; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigStateAudioEvent[] _onTransitionOut; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigAnimationRecurrentSpeech> _recurrentSpeeches; // 0x20

	// Properties
	public ConfigStateAudioEvent[] onTransitionIn { /* [XID] */ /* 0x00000001895F2A40-0x00000001895F2A60 */ get => default; /* [XID] */ /* 0x00000001899055A0-0x00000001899055C0 */ private set {} } // 0x0000000181D7E220-0x0000000181D7E2C0 0x0000000181D7D5E0-0x0000000181D7D690
	public ConfigStateAudioEvent[] onTransitionOut { /* [XID] */ /* 0x000000018990CE90-0x000000018990CEB0 */ get => default; /* [XID] */ /* 0x0000000189914640-0x0000000189914660 */ private set {} } // 0x0000000181D7E9D0-0x0000000181D7EA70 0x0000000181D7E6C0-0x0000000181D7E770
	public Dictionary<string, ConfigAnimationRecurrentSpeech> recurrentSpeeches { /* [XID] */ /* 0x000000018991C1A0-0x000000018991C1C0 */ get => default; /* [XID] */ /* 0x00000001899238C0-0x00000001899238E0 */ private set {} } // 0x0000000181D7E620-0x0000000181D7E6C0 0x0000000181D7DD70-0x0000000181D7DE20

	// Constructors
	public ConfigAnimationAudio() {} // 0x0000000181D7EB10-0x0000000181D7EB70

	// Methods
	// [XID] // 0x000000018992AF00-0x000000018992AF20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181D7E770-0x0000000181D7E890
	// [XID] // 0x00000001899325C0-0x00000001899325E0
	public void InitEmpty() {} // 0x0000000181D7DE20-0x0000000181D7DF20
	[BlackList] // 0x0000000189939FD0-0x000000018993A010
	// [XID] // 0x0000000189939FD0-0x000000018993A010
	public bool FromJson(JSONNode node) => default; // 0x0000000181D7D9F0-0x0000000181D7DD70
	// [XID] // 0x0000000189944500-0x0000000189944520
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181D7CDF0-0x0000000181D7D1A0
	// [XID] // 0x000000018994BAC0-0x000000018994BAE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7189 */, bool useObjectPool = false /* Metadata: 0x00AF718D */) => default; // 0x0000000181D7DF20-0x0000000181D7E220
	// [XID] // 0x00000001899532D0-0x00000001899532F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF718E */, bool useObjectPool = false /* Metadata: 0x00AF7192 */) => default; // 0x0000000181D7D690-0x0000000181D7D9F0
	[BlackList] // 0x000000018995AA10-0x000000018995AA50
	// [XID] // 0x000000018995AA10-0x000000018995AA50
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181D7D1A0-0x0000000181D7D470
	// [XID] // 0x0000000189965350-0x0000000189965370
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181D7E2C0-0x0000000181D7E620
	[BlackList] // 0x000000018996C8F0-0x000000018996C930
	// [XID] // 0x000000018996C8F0-0x000000018996C930
	public virtual void AutoAllocTypeFields() {} // 0x0000000181D7D470-0x0000000181D7D510
	[BlackList] // 0x00000001899772A0-0x00000001899772E0
	// [XID] // 0x00000001899772A0-0x00000001899772E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181D7D510-0x0000000181D7D5E0
	[BlackList] // 0x0000000189981C00-0x0000000189981C40
	// [XID] // 0x0000000189981C00-0x0000000189981C40
	public virtual void ReturnToObjectPool() {} // 0x0000000181D7EA70-0x0000000181D7EB10
	[BlackList] // 0x000000018998C2F0-0x000000018998C330
	// [XID] // 0x000000018998C2F0-0x000000018998C330
	public virtual void OnPoolAllocated() {} // 0x0000000181D7E930-0x0000000181D7E9D0
	[BlackList] // 0x0000000189996EE0-0x0000000189996F20
	// [XID] // 0x0000000189996EE0-0x0000000189996F20
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181D7E890-0x0000000181D7E930
}

