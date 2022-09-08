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
public class VoiceSound : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17643
{
	// Fields
	private VoicePersonality _personality; // 0x10
	private VoicePositioning _positioning; // 0x14
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _soundName; // 0x18

	// Properties
	public VoicePersonality personality { /* [XID] */ /* 0x0000000189679570-0x0000000189679590 */ get => default; /* [XID] */ /* 0x0000000189680C60-0x0000000189680C80 */ private set {} } // 0x00000001845D35A0-0x00000001845D3640 0x00000001845D3000-0x00000001845D30B0
	public VoicePositioning positioning { /* [XID] */ /* 0x00000001896886E0-0x0000000189688700 */ get => default; /* [XID] */ /* 0x0000000189690000-0x0000000189690020 */ private set {} } // 0x00000001845D39F0-0x00000001845D3A90 0x00000001845D3FF0-0x00000001845D40A0
	public ConfigWwiseString soundName { /* [XID] */ /* 0x0000000189697940-0x0000000189697960 */ get => default; /* [XID] */ /* 0x000000018969EDD0-0x000000018969EDF0 */ private set {} } // 0x00000001845D3430-0x00000001845D34D0 0x00000001845D3940-0x00000001845D39F0

	// Constructors
	public VoiceSound() {} // 0x00000001845D4140-0x00000001845D41A0

	// Methods
	// [XID] // 0x00000001896A60F0-0x00000001896A6110
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845D3D70-0x00000001845D3EB0
	// [XID] // 0x00000001896AD5F0-0x00000001896AD610
	public void InitEmpty() {} // 0x00000001845D34D0-0x00000001845D35A0
	[BlackList] // 0x00000001896B4CB0-0x00000001896B4CF0
	// [XID] // 0x00000001896B4CB0-0x00000001896B4CF0
	public bool FromJson(JSONNode node) => default; // 0x00000001845D30B0-0x00000001845D3430
	// [XID] // 0x00000001896BEC70-0x00000001896BEC90
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001845D2480-0x00000001845D2830
	// [XID] // 0x00000001896C66B0-0x00000001896C66D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75DD */, bool useObjectPool = false /* Metadata: 0x00AF75E1 */) => default; // 0x00000001845D3640-0x00000001845D3940
	// [XID] // 0x00000001896CDBF0-0x00000001896CDC10
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF75E2 */, bool useObjectPool = false /* Metadata: 0x00AF75E6 */) => default; // 0x00000001845D2CD0-0x00000001845D3000
	[BlackList] // 0x00000001896D5260-0x00000001896D52A0
	// [XID] // 0x00000001896D5260-0x00000001896D52A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001845D2830-0x00000001845D2B00
	// [XID] // 0x00000001896DFA60-0x00000001896DFA80
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845D3A90-0x00000001845D3D70
	[BlackList] // 0x00000001896E6DE0-0x00000001896E6E20
	// [XID] // 0x00000001896E6DE0-0x00000001896E6E20
	public virtual void AutoAllocTypeFields() {} // 0x00000001845D2B00-0x00000001845D2BA0
	[BlackList] // 0x00000001896F0F40-0x00000001896F0F80
	// [XID] // 0x00000001896F0F40-0x00000001896F0F80
	public virtual void AutoRecycleTypeFields() {} // 0x00000001845D2BA0-0x00000001845D2CD0
	[BlackList] // 0x00000001896FBBD0-0x00000001896FBC10
	// [XID] // 0x00000001896FBBD0-0x00000001896FBC10
	public virtual void ReturnToObjectPool() {} // 0x00000001845D40A0-0x00000001845D4140
	[BlackList] // 0x0000000189705F20-0x0000000189705F60
	// [XID] // 0x0000000189705F20-0x0000000189705F60
	public virtual void OnPoolAllocated() {} // 0x00000001845D3F50-0x00000001845D3FF0
	[BlackList] // 0x0000000189710B10-0x0000000189710B50
	// [XID] // 0x0000000189710B10-0x0000000189710B50
	public virtual void OnBeforePoolRecycled() {} // 0x00000001845D3EB0-0x00000001845D3F50
}

