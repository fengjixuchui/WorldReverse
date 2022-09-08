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
public class ConfigLanguageSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14966
{
	// Fields
	public static Dictionary<TextLanguageType, LanguageType> protoTypeTrans; // 0x00
	private LanguageType[] _currentPlatformTextShowTypes; // 0x10
	private LanguageType[] _currentPlatformTextDisableTypes; // 0x18
	private VoiceLanguageType[] _currentPlatformVoiceShowTypes; // 0x20
	private VoiceLanguageType[] _currentPlatformVoiceDisableTypes; // 0x28
	private Dictionary<string, TextLanguageType[]> _textShowTypes; // 0x30
	private Dictionary<string, TextLanguageType[]> _textDisableTypes; // 0x38
	private Dictionary<string, VoiceLanguageType[]> _voiceShowTypes; // 0x40
	private Dictionary<string, VoiceLanguageType[]> _voiceDisableTypes; // 0x48

	// Properties
	public LanguageType[] currentPlatformTextShowTypes { /* [XID] */ /* 0x0000000189AA75C0-0x0000000189AA75E0 */ get => default; } // 0x000000018222D7D0-0x000000018222DA70 
	public LanguageType[] currentPlatformTextDisableTypes { /* [XID] */ /* 0x0000000189AAEC40-0x0000000189AAEC60 */ get => default; } // 0x000000018222C180-0x000000018222C420 
	public VoiceLanguageType[] currentPlatformVoiceShowTypes { /* [XID] */ /* 0x0000000189AB6640-0x0000000189AB6660 */ get => default; } // 0x000000018222CDB0-0x000000018222CFF0 
	public VoiceLanguageType[] currentPlatformVoiceDisableTypes { /* [XID] */ /* 0x0000000189ABE130-0x0000000189ABE150 */ get => default; } // 0x000000018222B090-0x000000018222B2D0 
	public Dictionary<string, TextLanguageType[]> textShowTypes { /* [XID] */ /* 0x0000000189AC5D10-0x0000000189AC5D30 */ get => default; /* [XID] */ /* 0x0000000189ACD220-0x0000000189ACD240 */ private set {} } // 0x000000018222D0A0-0x000000018222D140 0x000000018222C7A0-0x000000018222C850
	public Dictionary<string, TextLanguageType[]> textDisableTypes { /* [XID] */ /* 0x0000000189AD4FE0-0x0000000189AD5000 */ get => default; /* [XID] */ /* 0x0000000189ADC820-0x0000000189ADC840 */ private set {} } // 0x000000018222CA10-0x000000018222CAB0 0x000000018222CFF0-0x000000018222D0A0
	public Dictionary<string, VoiceLanguageType[]> voiceShowTypes { /* [XID] */ /* 0x0000000189AE41D0-0x0000000189AE41F0 */ get => default; /* [XID] */ /* 0x0000000189AEB9B0-0x0000000189AEB9D0 */ private set {} } // 0x000000018222C0E0-0x000000018222C180 0x000000018222C850-0x000000018222C900
	public Dictionary<string, VoiceLanguageType[]> voiceDisableTypes { /* [XID] */ /* 0x0000000189AF3430-0x0000000189AF3450 */ get => default; /* [XID] */ /* 0x0000000189AFACE0-0x0000000189AFAD00 */ private set {} } // 0x000000018222C040-0x000000018222C0E0 0x000000018222BB90-0x000000018222BC40

	// Constructors
	static ConfigLanguageSetting() {} // 0x000000018222DB10-0x000000018222DE60
	public ConfigLanguageSetting() {} // 0x000000018222DE60-0x000000018222DEC0

	// Methods
	// [XID] // 0x0000000189B02210-0x0000000189B02230
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018222D550-0x000000018222D690
	// [XID] // 0x0000000189B09650-0x0000000189B09670
	public void InitEmpty() {} // 0x000000018222C900-0x000000018222CA10
	[BlackList] // 0x0000000189B111B0-0x0000000189B111F0
	// [XID] // 0x0000000189B111B0-0x0000000189B111F0
	public bool FromJson(JSONNode node) => default; // 0x000000018222C420-0x000000018222C7A0
	// [XID] // 0x0000000189B1B3A0-0x0000000189B1B3C0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018222B2D0-0x000000018222B760
	// [XID] // 0x0000000189B229F0-0x0000000189B22A10
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC91 */, bool useObjectPool = false /* Metadata: 0x00AEFC95 */) => default; // 0x000000018222CAB0-0x000000018222CDB0
	// [XID] // 0x0000000189B2A060-0x0000000189B2A080
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFC96 */, bool useObjectPool = false /* Metadata: 0x00AEFC9A */) => default; // 0x000000018222BC40-0x000000018222C040
	[BlackList] // 0x0000000189B31730-0x0000000189B31770
	// [XID] // 0x0000000189B31730-0x0000000189B31770
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018222B760-0x000000018222BA30
	// [XID] // 0x0000000189B3BC70-0x0000000189B3BC90
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018222D140-0x000000018222D550
	[BlackList] // 0x0000000189B43630-0x0000000189B43670
	// [XID] // 0x0000000189B43630-0x0000000189B43670
	public virtual void AutoAllocTypeFields() {} // 0x000000018222BA30-0x000000018222BAD0
	[BlackList] // 0x0000000189B4DDA0-0x0000000189B4DDE0
	// [XID] // 0x0000000189B4DDA0-0x0000000189B4DDE0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018222BAD0-0x000000018222BB90
	[BlackList] // 0x0000000189B58730-0x0000000189B58770
	// [XID] // 0x0000000189B58730-0x0000000189B58770
	public virtual void ReturnToObjectPool() {} // 0x000000018222DA70-0x000000018222DB10
	[BlackList] // 0x0000000189B62B40-0x0000000189B62B80
	// [XID] // 0x0000000189B62B40-0x0000000189B62B80
	public virtual void OnPoolAllocated() {} // 0x000000018222D730-0x000000018222D7D0
	[BlackList] // 0x0000000189B6D360-0x0000000189B6D3A0
	// [XID] // 0x0000000189B6D360-0x0000000189B6D3A0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018222D690-0x000000018222D730
}

