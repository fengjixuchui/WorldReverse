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
public class AchievementExcelConfig : WatcherConfig, IAutoAllocRecycle // TypeDefIndex: 14993
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 goalIdRawNum; // 0x28
	protected SimpleSafeUInt32 orderIdRawNum; // 0x2C
	protected SimpleSafeUInt32 preStageAchievementIdRawNum; // 0x30
	protected uint _titleTextMapHash; // 0x34
	protected uint _descTextMapHash; // 0x38
	protected ShowType _isShow; // 0x3C
	protected SimpleSafeUInt32 ps4GroupIdRawNum; // 0x40
	protected SimpleSafeUInt32 ps5GroupIdRawNum; // 0x44
	protected uint _ps5TitleTextMapHash; // 0x48
	protected string _ttype; // 0x50
	protected string _psTrophyId; // 0x58
	protected string _ps4TrophyId; // 0x60
	protected string _ps5TrophyId; // 0x68
	protected string _icon; // 0x70
	protected SimpleSafeUInt32 finishRewardIdRawNum; // 0x78
	protected bool _isDeleteWatcherAfterFinish; // 0x7C
	protected ProgressShowType _progressShowType; // 0x80

	// Properties
	public uint goalId { /* [XID] */ /* 0x00000001899595B0-0x00000001899595D0 */ get => default; /* [XID] */ /* 0x0000000189960F20-0x0000000189960F40 */ protected set {} } // 0x000000018224F5E0-0x000000018224F6B0 0x0000000182252E50-0x0000000182252F30
	public uint orderId { /* [XID] */ /* 0x0000000189968600-0x0000000189968620 */ get => default; /* [XID] */ /* 0x000000018996FB00-0x000000018996FB20 */ protected set {} } // 0x00000001822516A0-0x0000000182251770 0x00000001822530F0-0x00000001822531D0
	public uint preStageAchievementId { /* [XID] */ /* 0x0000000189977A00-0x0000000189977A20 */ get => default; /* [XID] */ /* 0x000000018997EB60-0x000000018997EB80 */ protected set {} } // 0x0000000182251250-0x0000000182251320 0x0000000182252A70-0x0000000182252B50
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint titleTextMapHash { /* [XID] */ /* 0x0000000189986490-0x00000001899864B0 */ get => default; /* [XID] */ /* 0x000000018998E120-0x000000018998E140 */ protected set {} } // 0x000000018224F810-0x000000018224F8B0 0x000000018224F9C0-0x000000018224FA70
	public string title { /* [XID] */ /* 0x0000000189995B90-0x0000000189995BB0 */ get => default; } // 0x0000000182252BF0-0x0000000182252D70 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x000000018999D5D0-0x000000018999D5F0 */ get => default; /* [XID] */ /* 0x00000001899A4E90-0x00000001899A4EB0 */ protected set {} } // 0x0000000182252B50-0x0000000182252BF0 0x000000018224F8B0-0x000000018224F960
	public string desc { /* [XID] */ /* 0x00000001899ACA50-0x00000001899ACA70 */ get => default; } // 0x00000001822513F0-0x0000000182251570 
	public ShowType isShow { /* [XID] */ /* 0x00000001899B4220-0x00000001899B4240 */ get => default; /* [XID] */ /* 0x00000001899BB6B0-0x00000001899BB6D0 */ protected set {} } // 0x00000001822534D0-0x0000000182253570 0x000000018224F760-0x000000018224F810
	public uint ps4GroupId { /* [XID] */ /* 0x00000001899C32C0-0x00000001899C32E0 */ get => default; /* [XID] */ /* 0x00000001899CA780-0x00000001899CA7A0 */ protected set {} } // 0x0000000182251320-0x00000001822513F0 0x0000000182252D70-0x0000000182252E50
	public uint ps5GroupId { /* [XID] */ /* 0x00000001899D1EC0-0x00000001899D1EE0 */ get => default; /* [XID] */ /* 0x00000001899D9390-0x00000001899D93B0 */ protected set {} } // 0x00000001822531D0-0x00000001822532A0 0x00000001822532A0-0x0000000182253380
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint ps5TitleTextMapHash { /* [XID] */ /* 0x00000001899E0AA0-0x00000001899E0AC0 */ get => default; /* [XID] */ /* 0x00000001899E8680-0x00000001899E86A0 */ protected set {} } // 0x0000000182251770-0x0000000182251810 0x000000018224F490-0x000000018224F540
	public string ps5Title { /* [XID] */ /* 0x00000001899EFCF0-0x00000001899EFD10 */ get => default; } // 0x000000018224FA70-0x000000018224FBF0 
	public string ttype { /* [XID] */ /* 0x00000001899F7370-0x00000001899F7390 */ get => default; /* [XID] */ /* 0x00000001899FEAF0-0x00000001899FEB10 */ protected set {} } // 0x0000000182251870-0x0000000182251910 0x0000000182251910-0x00000001822519C0
	public string psTrophyId { /* [XID] */ /* 0x0000000189A06350-0x0000000189A06370 */ get => default; /* [XID] */ /* 0x0000000189A0D800-0x0000000189A0D820 */ protected set {} } // 0x0000000182253380-0x0000000182253420 0x0000000182253420-0x00000001822534D0
	public string ps4TrophyId { /* [XID] */ /* 0x0000000189A14F40-0x0000000189A14F60 */ get => default; /* [XID] */ /* 0x0000000189A1C090-0x0000000189A1C0B0 */ protected set {} } // 0x0000000182251600-0x00000001822516A0 0x000000018224F2A0-0x000000018224F350
	public string ps5TrophyId { /* [XID] */ /* 0x0000000189A23960-0x0000000189A23980 */ get => default; /* [XID] */ /* 0x0000000189A2ADA0-0x0000000189A2ADC0 */ protected set {} } // 0x000000018224F3F0-0x000000018224F490 0x000000018224F6B0-0x000000018224F760
	public string icon { /* [XID] */ /* 0x0000000189A322E0-0x0000000189A32300 */ get => default; /* [XID] */ /* 0x0000000189A39D70-0x0000000189A39D90 */ protected set {} } // 0x000000018224F000-0x000000018224F0A0 0x0000000182253040-0x00000001822530F0
	public uint finishRewardId { /* [XID] */ /* 0x0000000189A415B0-0x0000000189A415D0 */ get => default; /* [XID] */ /* 0x0000000189A48C70-0x0000000189A48C90 */ protected set {} } // 0x000000018224EF30-0x000000018224F000 0x0000000182252990-0x0000000182252A70
	public bool isDeleteWatcherAfterFinish { /* [XID] */ /* 0x0000000189A503C0-0x0000000189A503E0 */ get => default; /* [XID] */ /* 0x0000000189A57950-0x0000000189A57970 */ protected set {} } // 0x000000018224F540-0x000000018224F5E0 0x0000000182253570-0x0000000182253620
	public ProgressShowType progressShowType { /* [XID] */ /* 0x0000000189A5F590-0x0000000189A5F5B0 */ get => default; /* [XID] */ /* 0x0000000189A66EE0-0x0000000189A66F00 */ protected set {} } // 0x00000001822511B0-0x0000000182251250 0x0000000182252F30-0x0000000182252FE0

	// Constructors
	public AchievementExcelConfig() {} // 0x00000001822536C0-0x0000000182253720

	// Methods
	// [IDTag] // 0x0000000189A6E660-0x0000000189A6E6A0
	// [XID] // 0x0000000189A6E660-0x0000000189A6E6A0
	public virtual bool ParseFromLine(string line) => default; // 0x000000018224FBF0-0x0000000182250730
	// [IDTag] // 0x0000000189A78FC0-0x0000000189A79000
	// [XID] // 0x0000000189A78FC0-0x0000000189A79000
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182250730-0x00000001822511B0
	// [XID] // 0x0000000189A839A0-0x0000000189A839C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFDDF */, bool useObjectPool = false /* Metadata: 0x00AEFDE3 */) => default; // 0x00000001822519C0-0x0000000182252990
	[BlackList] // 0x0000000189A8B120-0x0000000189A8B160
	// [XID] // 0x0000000189A8B120-0x0000000189A8B160
	public override void AutoAllocTypeFields() {} // 0x000000018224F0A0-0x000000018224F140
	[BlackList] // 0x0000000189A956B0-0x0000000189A956F0
	// [XID] // 0x0000000189A956B0-0x0000000189A956F0
	public override void AutoRecycleTypeFields() {} // 0x000000018224F140-0x000000018224F2A0
	[BlackList] // 0x0000000189A9FDB0-0x0000000189A9FDF0
	// [XID] // 0x0000000189A9FDB0-0x0000000189A9FDF0
	public override void ReturnToObjectPool() {} // 0x0000000182253620-0x00000001822536C0
}

