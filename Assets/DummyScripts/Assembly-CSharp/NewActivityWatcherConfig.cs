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
public class NewActivityWatcherConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 15892
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 rewardIDRawNum; // 0x28
	protected SimpleSafeUInt32 rewardPreviewRawNum; // 0x2C
	protected uint _activitychallengetipsTextMapHash; // 0x30
	protected uint _extraActivitychallengetipsTextMapHash; // 0x34
	protected bool _isAutoGrant; // 0x38

	// Properties
	public uint rewardID { /* [XID] */ /* 0x00000001898DAFC0-0x00000001898DAFE0 */ get => default; /* [XID] */ /* 0x00000001898E2C60-0x00000001898E2C80 */ protected set {} } // 0x000000018130F040-0x000000018130F110 0x000000018130EF60-0x000000018130F040
	public uint rewardPreview { /* [XID] */ /* 0x00000001898EA990-0x00000001898EA9B0 */ get => default; /* [XID] */ /* 0x00000001898F20D0-0x00000001898F20F0 */ protected set {} } // 0x000000018130F110-0x000000018130F1E0 0x000000018130F1E0-0x000000018130F2C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint activitychallengetipsTextMapHash { /* [XID] */ /* 0x00000001898F9850-0x00000001898F9870 */ get => default; /* [XID] */ /* 0x00000001899011F0-0x0000000189901210 */ protected set {} } // 0x000000018130E350-0x000000018130E3F0 0x000000018130FEC0-0x000000018130FF70
	public string activitychallengetips { /* [XID] */ /* 0x0000000189908A70-0x0000000189908A90 */ get => default; } // 0x000000018130E1D0-0x000000018130E350 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint extraActivitychallengetipsTextMapHash { /* [XID] */ /* 0x0000000189910030-0x0000000189910050 */ get => default; /* [XID] */ /* 0x0000000189917BC0-0x0000000189917BE0 */ protected set {} } // 0x000000018130FE20-0x000000018130FEC0 0x000000018130E120-0x000000018130E1D0
	public string extraActivitychallengetips { /* [XID] */ /* 0x000000018991F120-0x000000018991F140 */ get => default; } // 0x000000018130F460-0x000000018130F5E0 
	public bool isAutoGrant { /* [XID] */ /* 0x0000000189926B80-0x0000000189926BA0 */ get => default; /* [XID] */ /* 0x000000018992E2D0-0x000000018992E2F0 */ protected set {} } // 0x000000018130FF70-0x0000000181310010 0x000000018130F3B0-0x000000018130F460

	// Constructors
	public NewActivityWatcherConfig() {} // 0x00000001813100B0-0x0000000181310110

	// Methods
	// [IDTag] // 0x00000001899355F0-0x0000000189935630
	// [XID] // 0x00000001899355F0-0x0000000189935630
	public virtual bool ParseFromLine(string line) => default; // 0x000000018130E450-0x000000018130EA20
	// [IDTag] // 0x000000018993FFA0-0x000000018993FFE0
	// [XID] // 0x000000018993FFA0-0x000000018993FFE0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018130EA20-0x000000018130EF60
	// [XID] // 0x000000018994A460-0x000000018994A480
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2A69 */, bool useObjectPool = false /* Metadata: 0x00AF2A6D */) => default; // 0x000000018130F5E0-0x000000018130FDC0
	[BlackList] // 0x0000000189951F10-0x0000000189951F50
	// [XID] // 0x0000000189951F10-0x0000000189951F50
	public override void AutoAllocTypeFields() {} // 0x000000018130DEF0-0x000000018130DF90
	[BlackList] // 0x000000018995C400-0x000000018995C440
	// [XID] // 0x000000018995C400-0x000000018995C440
	public override void AutoRecycleTypeFields() {} // 0x000000018130DF90-0x000000018130E080
	[BlackList] // 0x0000000189966E70-0x0000000189966EB0
	// [XID] // 0x0000000189966E70-0x0000000189966EB0
	public override void ReturnToObjectPool() {} // 0x0000000181310010-0x00000001813100B0
}

