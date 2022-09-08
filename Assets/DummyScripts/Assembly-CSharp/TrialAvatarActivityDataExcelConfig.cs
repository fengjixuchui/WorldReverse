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
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class TrialAvatarActivityDataExcelConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 16237
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 trialAvatarIndexIdRawNum; // 0x28
	protected SimpleSafeUInt32 trialAvatarIdRawNum; // 0x2C
	protected SimpleSafeUInt32 dungeonIdRawNum; // 0x30
	protected string _battleAvatarsList; // 0x38
	protected SimpleSafeUInt32 firstPassRewardRawNum; // 0x40
	protected uint _titleTextMapHash; // 0x44
	protected uint _briefInfoTextMapHash; // 0x48
	protected string _bgPath; // 0x50

	// Properties
	public uint trialAvatarIndexId { /* [XID] */ /* 0x00000001898177A0-0x00000001898177C0 */ get => default; /* [XID] */ /* 0x000000018981F100-0x000000018981F120 */ protected set {} } // 0x0000000181E6D0B0-0x0000000181E6D180 0x0000000181E6ADB0-0x0000000181E6AE90
	public uint trialAvatarId { /* [XID] */ /* 0x0000000189826630-0x0000000189826650 */ get => default; /* [XID] */ /* 0x000000018982DCC0-0x000000018982DCE0 */ protected set {} } // 0x0000000181E6CE30-0x0000000181E6CF00 0x0000000181E6CFD0-0x0000000181E6D0B0
	public uint dungeonId { /* [XID] */ /* 0x0000000189835390-0x00000001898353B0 */ get => default; /* [XID] */ /* 0x000000018983CA70-0x000000018983CA90 */ protected set {} } // 0x0000000181E6CD00-0x0000000181E6CDD0 0x0000000181E6D230-0x0000000181E6D310
	public string battleAvatarsList { /* [XID] */ /* 0x0000000189844200-0x0000000189844220 */ get => default; /* [XID] */ /* 0x000000018984B630-0x000000018984B650 */ protected set {} } // 0x0000000181E6C020-0x0000000181E6C0C0 0x0000000181E6BF70-0x0000000181E6C020
	public uint firstPassReward { /* [XID] */ /* 0x00000001898526E0-0x0000000189852700 */ get => default; /* [XID] */ /* 0x000000018985A170-0x000000018985A190 */ protected set {} } // 0x0000000181E6CF00-0x0000000181E6CFD0 0x0000000181E6BE90-0x0000000181E6BF70
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x00000001898612D0-0x00000001898612F0 */ get => default; /* [XID] */ /* 0x0000000189868AB0-0x0000000189868AD0 */ protected set {} } // 0x0000000181E6AB50-0x0000000181E6ABF0 0x0000000181E6AD00-0x0000000181E6ADB0
	public string title { /* [XID] */ /* 0x000000018986FF00-0x000000018986FF20 */ get => default; } // 0x0000000181E6CB80-0x0000000181E6CD00 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint briefInfoTextMapHash { /* [XID] */ /* 0x0000000189877650-0x0000000189877670 */ get => default; /* [XID] */ /* 0x000000018987EEE0-0x000000018987EF00 */ protected set {} } // 0x0000000181E6BDF0-0x0000000181E6BE90 0x0000000181E6ABF0-0x0000000181E6ACA0
	public string briefInfo { /* [XID] */ /* 0x00000001898864E0-0x0000000189886500 */ get => default; } // 0x0000000181E6AE90-0x0000000181E6B010 
	public string bgPath { /* [XID] */ /* 0x000000018988D660-0x000000018988D680 */ get => default; /* [XID] */ /* 0x0000000189894DB0-0x0000000189894DD0 */ protected set {} } // 0x0000000181E6A850-0x0000000181E6A8F0 0x0000000181E6D180-0x0000000181E6D230

	// Constructors
	public TrialAvatarActivityDataExcelConfig() {} // 0x0000000181E6D3B0-0x0000000181E6D410

	// Methods
	// [IDTag] // 0x000000018989C440-0x000000018989C480
	// [XID] // 0x000000018989C440-0x000000018989C480
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181E6B6C0-0x0000000181E6BDF0
	// [IDTag] // 0x00000001898A6B60-0x00000001898A6BA0
	// [XID] // 0x00000001898A6B60-0x00000001898A6BA0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181E6B010-0x0000000181E6B6C0
	// [XID] // 0x00000001898B1180-0x00000001898B11A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF353D */, bool useObjectPool = false /* Metadata: 0x00AF3541 */) => default; // 0x0000000181E6C1B0-0x0000000181E6CB80
	[BlackList] // 0x00000001898B89A0-0x00000001898B89E0
	// [XID] // 0x00000001898B89A0-0x00000001898B89E0
	public override void AutoAllocTypeFields() {} // 0x0000000181E6A8F0-0x0000000181E6A990
	[BlackList] // 0x00000001898C2F20-0x00000001898C2F60
	// [XID] // 0x00000001898C2F20-0x00000001898C2F60
	public override void AutoRecycleTypeFields() {} // 0x0000000181E6A990-0x0000000181E6AAB0
	[BlackList] // 0x00000001898CD640-0x00000001898CD680
	// [XID] // 0x00000001898CD640-0x00000001898CD680
	public override void ReturnToObjectPool() {} // 0x0000000181E6D310-0x0000000181E6D3B0
}

