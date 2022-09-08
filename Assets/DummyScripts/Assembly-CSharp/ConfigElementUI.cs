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
public class ConfigElementUI : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18111
{
	// Fields
	private EntityType[] _showIconEntityTypes; // 0x10
	private EntityType[] _showReactionEntityTypes; // 0x18
	private SimpleSafeFloat iconRecoverTimeRawNum; // 0x20
	private SimpleSafeFloat iconDisappearTimeRawNum; // 0x24
	private SimpleSafeUInt32 iconDisappearRoundRawNum; // 0x28
	private SimpleSafeFloat iconShowDistanceRawNum; // 0x2C
	private Dictionary<string, string> _overrideElemPath; // 0x30
	private Dictionary<ElementReactionType, string> _reactionElemPath; // 0x38

	// Properties
	public EntityType[] showIconEntityTypes { /* [XID] */ /* 0x00000001898EAE90-0x00000001898EAEB0 */ get => default; /* [XID] */ /* 0x0000000189627DB0-0x0000000189627DD0 */ private set {} } // 0x0000000183A8D740-0x0000000183A8D7E0 0x0000000183A8EAD0-0x0000000183A8EB80
	public EntityType[] showReactionEntityTypes { /* [XID] */ /* 0x000000018962F6E0-0x000000018962F700 */ get => default; /* [XID] */ /* 0x0000000189637240-0x0000000189637260 */ private set {} } // 0x0000000183A8D5C0-0x0000000183A8D660 0x0000000183A8D7E0-0x0000000183A8D890
	public float iconRecoverTime { /* [XID] */ /* 0x000000018963E740-0x000000018963E760 */ get => default; /* [XID] */ /* 0x0000000189645E80-0x0000000189645EA0 */ private set {} } // 0x0000000183A8E9F0-0x0000000183A8EAD0 0x0000000183A8B9A0-0x0000000183A8BA80
	public float iconDisappearTime { /* [XID] */ /* 0x000000018964D7A0-0x000000018964D7C0 */ get => default; /* [XID] */ /* 0x0000000189654F40-0x0000000189654F60 */ private set {} } // 0x0000000183A8DA20-0x0000000183A8DB00 0x0000000183A8DE00-0x0000000183A8DEE0
	public uint iconDisappearRound { /* [XID] */ /* 0x000000018965C720-0x000000018965C740 */ get => default; /* [XID] */ /* 0x0000000189663D20-0x0000000189663D40 */ private set {} } // 0x0000000183A8C8E0-0x0000000183A8C9B0 0x0000000183A8DEE0-0x0000000183A8DFC0
	public float iconShowDistance { /* [XID] */ /* 0x000000018966B4E0-0x000000018966B500 */ get => default; /* [XID] */ /* 0x0000000189673200-0x0000000189673220 */ private set {} } // 0x0000000183A8E620-0x0000000183A8E700 0x0000000183A8D660-0x0000000183A8D740
	public Dictionary<string, string> overrideElemPath { /* [XID] */ /* 0x000000018967A880-0x000000018967A8A0 */ get => default; /* [XID] */ /* 0x0000000189682190-0x00000001896821B0 */ private set {} } // 0x0000000183A8C660-0x0000000183A8C700 0x0000000183A8D0E0-0x0000000183A8D190
	public Dictionary<ElementReactionType, string> reactionElemPath { /* [XID] */ /* 0x0000000189B16EA0-0x0000000189B16EC0 */ get => default; /* [XID] */ /* 0x00000001896919D0-0x00000001896919F0 */ private set {} } // 0x0000000183A8C9B0-0x0000000183A8CA50 0x0000000183A8D190-0x0000000183A8D240

	// Constructors
	public ConfigElementUI() {} // 0x0000000183A8EC20-0x0000000183A8EC80

	// Methods
	// [XID] // 0x0000000189698EE0-0x0000000189698F00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A8E700-0x0000000183A8E8B0
	// [XID] // 0x00000001896A0450-0x00000001896A0470
	public void InitEmpty() {} // 0x0000000183A8D890-0x0000000183A8DA20
	[BlackList] // 0x00000001896A7960-0x00000001896A79A0
	// [XID] // 0x00000001896A7960-0x00000001896A79A0
	public bool FromJson(JSONNode node) => default; // 0x0000000183A8D240-0x0000000183A8D5C0
	// [XID] // 0x00000001896B17D0-0x00000001896B17F0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183A8BA80-0x0000000183A8C390
	// [XID] // 0x00000001896B91B0-0x00000001896B91D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B6D */, bool useObjectPool = false /* Metadata: 0x00AF8B71 */) => default; // 0x0000000183A8DB00-0x0000000183A8DE00
	// [XID] // 0x00000001896C05C0-0x00000001896C05E0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B72 */, bool useObjectPool = false /* Metadata: 0x00AF8B76 */) => default; // 0x0000000183A8CA50-0x0000000183A8D0E0
	[BlackList] // 0x00000001896C7D10-0x00000001896C7D50
	// [XID] // 0x00000001896C7D10-0x00000001896C7D50
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A8C390-0x0000000183A8C660
	// [XID] // 0x00000001896D20C0-0x00000001896D20E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A8DFC0-0x0000000183A8E620
	[BlackList] // 0x00000001896D99B0-0x00000001896D99F0
	// [XID] // 0x00000001896D99B0-0x00000001896D99F0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A8C700-0x0000000183A8C7A0
	[BlackList] // 0x00000001896E3FB0-0x00000001896E3FF0
	// [XID] // 0x00000001896E3FB0-0x00000001896E3FF0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A8C7A0-0x0000000183A8C8E0
	[BlackList] // 0x00000001896EE190-0x00000001896EE1D0
	// [XID] // 0x00000001896EE190-0x00000001896EE1D0
	public virtual void ReturnToObjectPool() {} // 0x0000000183A8EB80-0x0000000183A8EC20
	[BlackList] // 0x00000001896F8720-0x00000001896F8760
	// [XID] // 0x00000001896F8720-0x00000001896F8760
	public virtual void OnPoolAllocated() {} // 0x0000000183A8E950-0x0000000183A8E9F0
	[BlackList] // 0x00000001897030F0-0x0000000189703130
	// [XID] // 0x00000001897030F0-0x0000000189703130
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A8E8B0-0x0000000183A8E950
}

