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
public class ConfigAudioDialog : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17567
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private AudioDialogReaction[] _reactions; // 0x10
	private Dictionary<uint, AudioDialogReaction> _reactionIndex; // 0x18

	// Properties
	public AudioDialogReaction[] reactions { /* [XID] */ /* 0x0000000189BD4DD0-0x0000000189BD4DF0 */ get => default; /* [XID] */ /* 0x0000000189BDC920-0x0000000189BDC940 */ private set {} } // 0x000000018464E070-0x000000018464E110 0x000000018464D9A0-0x000000018464DA50

	// Constructors
	public ConfigAudioDialog() {} // 0x000000018464E5C0-0x000000018464E620

	// Methods
	// [XID] // 0x00000001895E91F0-0x00000001895E9210
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018464E300-0x000000018464E3E0
	// [XID] // 0x00000001895F09A0-0x00000001895F09C0
	public void InitEmpty() {} // 0x000000018464DA50-0x000000018464DB20
	[BlackList] // 0x00000001895F8330-0x00000001895F8370
	// [XID] // 0x00000001895F8330-0x00000001895F8370
	public bool FromJson(JSONNode node) => default; // 0x000000018464D620-0x000000018464D9A0
	// [XID] // 0x00000001896029B0-0x00000001896029D0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018464CE10-0x000000018464CFF0
	// [XID] // 0x000000018960A310-0x000000018960A330
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF732F */, bool useObjectPool = false /* Metadata: 0x00AF7333 */) => default; // 0x000000018464DB20-0x000000018464DE20
	// [XID] // 0x0000000189611AC0-0x0000000189611AE0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7334 */, bool useObjectPool = false /* Metadata: 0x00AF7338 */) => default; // 0x000000018464D410-0x000000018464D620
	[BlackList] // 0x00000001896193C0-0x0000000189619400
	// [XID] // 0x00000001896193C0-0x0000000189619400
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018464CFF0-0x000000018464D2C0
	// [XID] // 0x00000001896236A0-0x00000001896236C0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018464E110-0x000000018464E300
	// [XID] // 0x000000018962B000-0x000000018962B020
	public void BuildRactionIndex() {} // 0x000000018464DE20-0x000000018464DF90
	// [XID] // 0x0000000189632700-0x0000000189632720
	public AudioDialogReaction GetReactionById(uint dialogId) => default; // 0x000000018464DF90-0x000000018464E070
	[BlackList] // 0x000000018963A1F0-0x000000018963A230
	// [XID] // 0x000000018963A1F0-0x000000018963A230
	public virtual void AutoAllocTypeFields() {} // 0x000000018464D2C0-0x000000018464D360
	[BlackList] // 0x0000000189644810-0x0000000189644850
	// [XID] // 0x0000000189644810-0x0000000189644850
	public virtual void AutoRecycleTypeFields() {} // 0x000000018464D360-0x000000018464D410
	[BlackList] // 0x000000018964EE40-0x000000018964EE80
	// [XID] // 0x000000018964EE40-0x000000018964EE80
	public virtual void ReturnToObjectPool() {} // 0x000000018464E520-0x000000018464E5C0
	[BlackList] // 0x00000001896596D0-0x0000000189659710
	// [XID] // 0x00000001896596D0-0x0000000189659710
	public virtual void OnPoolAllocated() {} // 0x000000018464E480-0x000000018464E520
	[BlackList] // 0x0000000189663D80-0x0000000189663DC0
	// [XID] // 0x0000000189663D80-0x0000000189663DC0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018464E3E0-0x000000018464E480
}

