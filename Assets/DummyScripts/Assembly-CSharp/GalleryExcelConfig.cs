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
public class GalleryExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15653
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected GalleryType _type; // 0x14
	protected string[] _param; // 0x18
	protected bool _isEnableSinglePrepare; // 0x20
	protected SimpleSafeUInt32 singlePrepareTimeRawNum; // 0x24
	protected bool _isEnableMpPrepare; // 0x28
	protected SimpleSafeUInt32 mpPrepareTimeRawNum; // 0x2C
	protected bool _canInterruptByClient; // 0x30
	protected SimpleSafeUInt32 sceneIdRawNum; // 0x34
	protected SimpleSafeUInt32 controlGroupIdRawNum; // 0x38
	protected SimpleSafeUInt32[] _groupId; // 0x40
	protected SimpleSafeUInt32 revivePointGroupIdRawNum; // 0x48
	protected SimpleSafeUInt32 revivePointConfigIdRawNum; // 0x4C
	protected string _abilityGroup; // 0x50
	protected string _limitRegion; // 0x58
	protected SimpleSafeFloat[] _centerPosList; // 0x60
	protected SimpleSafeUInt32 centerRadiusRawNum; // 0x68
	protected SimpleSafeUInt32 durationRawNum; // 0x6C
	protected uint _nameTextMapHash; // 0x70
	protected uint _descTextMapHash; // 0x74
	protected uint _galleryNameTextMapHash; // 0x78
	protected uint _galleryMSGTextMapHash; // 0x7C
	protected string _pic; // 0x80
	protected uint _targetTextMapHash; // 0x88
	protected string _startAudioValues; // 0x90
	protected string _endAudioValues; // 0x98
	protected string[] _selectable_ability_groups; // 0xA0

	// Properties
	public uint id { /* [XID] */ /* 0x000000018960EE40-0x000000018960EE60 */ get => default; /* [XID] */ /* 0x0000000189616480-0x00000001896164A0 */ protected set {} } // 0x0000000181C106C0-0x0000000181C10790 0x0000000181C0E510-0x0000000181C0E5F0
	public GalleryType type { /* [XID] */ /* 0x000000018961DD10-0x000000018961DD30 */ get => default; /* [XID] */ /* 0x00000001896250B0-0x00000001896250D0 */ protected set {} } // 0x0000000181C10790-0x0000000181C10830 0x0000000181C10240-0x0000000181C102F0
	public string[] param { /* [XID] */ /* 0x000000018962C990-0x000000018962C9B0 */ get => default; /* [XID] */ /* 0x0000000189634690-0x00000001896346B0 */ protected set {} } // 0x0000000181C10B30-0x0000000181C10BD0 0x0000000181C10830-0x0000000181C108E0
	public bool isEnableSinglePrepare { /* [XID] */ /* 0x000000018963BDC0-0x000000018963BDE0 */ get => default; /* [XID] */ /* 0x00000001896434C0-0x00000001896434E0 */ protected set {} } // 0x0000000181C0DBC0-0x0000000181C0DC60 0x0000000181C100E0-0x0000000181C10190
	public uint singlePrepareTime { /* [XID] */ /* 0x000000018964AAC0-0x000000018964AAE0 */ get => default; /* [XID] */ /* 0x00000001896522E0-0x0000000189652300 */ protected set {} } // 0x0000000181C0E0B0-0x0000000181C0E180 0x0000000181C09DA0-0x0000000181C09E80
	public bool isEnableMpPrepare { /* [XID] */ /* 0x00000001896599D0-0x00000001896599F0 */ get => default; /* [XID] */ /* 0x0000000189661110-0x0000000189661130 */ protected set {} } // 0x0000000181C104E0-0x0000000181C10580 0x0000000181C0E3B0-0x0000000181C0E460
	public uint mpPrepareTime { /* [XID] */ /* 0x0000000189668BC0-0x0000000189668BE0 */ get => default; /* [XID] */ /* 0x0000000189670730-0x0000000189670750 */ protected set {} } // 0x0000000181C0DA40-0x0000000181C0DB10 0x0000000181C0E6A0-0x0000000181C0E780
	public bool canInterruptByClient { /* [XID] */ /* 0x0000000189677F30-0x0000000189677F50 */ get => default; /* [XID] */ /* 0x000000018967F620-0x000000018967F640 */ protected set {} } // 0x0000000181C10040-0x0000000181C100E0 0x0000000181C0FCC0-0x0000000181C0FD70
	public uint sceneId { /* [XID] */ /* 0x0000000189686E90-0x0000000189686EB0 */ get => default; /* [XID] */ /* 0x000000018968ECF0-0x000000018968ED10 */ protected set {} } // 0x0000000181C0E780-0x0000000181C0E850 0x0000000181C0FF60-0x0000000181C10040
	public uint controlGroupId { /* [XID] */ /* 0x0000000189696650-0x0000000189696670 */ get => default; /* [XID] */ /* 0x000000018969DCB0-0x000000018969DCD0 */ protected set {} } // 0x0000000181C10A60-0x0000000181C10B30 0x0000000181C0AC70-0x0000000181C0AD50
	public SimpleSafeUInt32[] groupId { /* [XID] */ /* 0x00000001896A4CE0-0x00000001896A4D00 */ get => default; /* [XID] */ /* 0x00000001896AC490-0x00000001896AC4B0 */ protected set {} } // 0x0000000181C10390-0x0000000181C10430 0x0000000181C10430-0x0000000181C104E0
	public uint revivePointGroupId { /* [XID] */ /* 0x00000001896B3770-0x00000001896B3790 */ get => default; /* [XID] */ /* 0x00000001896BAEF0-0x00000001896BAF10 */ protected set {} } // 0x0000000181C0DFE0-0x0000000181C0E0B0 0x0000000181C0AD50-0x0000000181C0AE30
	public uint revivePointConfigId { /* [XID] */ /* 0x00000001896C2060-0x00000001896C2080 */ get => default; /* [XID] */ /* 0x00000001896C9670-0x00000001896C9690 */ protected set {} } // 0x0000000181C0AE30-0x0000000181C0AF00 0x0000000181C0AA10-0x0000000181C0AAF0
	public string abilityGroup { /* [XID] */ /* 0x00000001896D0E00-0x00000001896D0E20 */ get => default; /* [XID] */ /* 0x00000001896D8510-0x00000001896D8530 */ protected set {} } // 0x0000000181C0A810-0x0000000181C0A8B0 0x0000000181C0A8B0-0x0000000181C0A960
	public string limitRegion { /* [XID] */ /* 0x00000001896DFE40-0x00000001896DFE60 */ get => default; /* [XID] */ /* 0x00000001896E7120-0x00000001896E7140 */ protected set {} } // 0x0000000181C0DDC0-0x0000000181C0DE60 0x0000000181C0E300-0x0000000181C0E3B0
	public SimpleSafeFloat[] centerPosList { /* [XID] */ /* 0x00000001896EE750-0x00000001896EE770 */ get => default; /* [XID] */ /* 0x00000001896F6000-0x00000001896F6020 */ protected set {} } // 0x0000000181C0FC20-0x0000000181C0FCC0 0x0000000181C0DB10-0x0000000181C0DBC0
	public uint centerRadius { /* [XID] */ /* 0x00000001896FD790-0x00000001896FD7B0 */ get => default; /* [XID] */ /* 0x0000000189704D10-0x0000000189704D30 */ protected set {} } // 0x0000000181C0DF10-0x0000000181C0DFE0 0x0000000181C09E80-0x0000000181C09F60
	public uint duration { /* [XID] */ /* 0x000000018970C450-0x000000018970C470 */ get => default; /* [XID] */ /* 0x0000000189713DA0-0x0000000189713DC0 */ protected set {} } // 0x0000000181C0A3C0-0x0000000181C0A490 0x0000000181C0D7E0-0x0000000181C0D8C0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint nameTextMapHash { /* [XID] */ /* 0x000000018971B5C0-0x000000018971B5E0 */ get => default; /* [XID] */ /* 0x0000000189722860-0x0000000189722880 */ protected set {} } // 0x0000000181C0A5F0-0x0000000181C0A690 0x0000000181C0FEB0-0x0000000181C0FF60
	public string name { /* [XID] */ /* 0x0000000189729F80-0x0000000189729FA0 */ get => default; } // 0x0000000181C108E0-0x0000000181C10A60 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x0000000189731660-0x0000000189731680 */ get => default; /* [XID] */ /* 0x0000000189738E90-0x0000000189738EB0 */ protected set {} } // 0x0000000181C0FE10-0x0000000181C0FEB0 0x0000000181C0A960-0x0000000181C0AA10
	public string desc { /* [XID] */ /* 0x0000000189740C60-0x0000000189740C80 */ get => default; } // 0x0000000181C0E180-0x0000000181C0E300 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint galleryNameTextMapHash { /* [XID] */ /* 0x00000001897481A0-0x00000001897481C0 */ get => default; /* [XID] */ /* 0x000000018974F9D0-0x000000018974F9F0 */ protected set {} } // 0x0000000181C0FD70-0x0000000181C0FE10 0x0000000181C0A540-0x0000000181C0A5F0
	public string galleryName { /* [XID] */ /* 0x0000000189756FC0-0x0000000189756FE0 */ get => default; } // 0x0000000181C0AAF0-0x0000000181C0AC70 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint galleryMSGTextMapHash { /* [XID] */ /* 0x000000018975E550-0x000000018975E570 */ get => default; /* [XID] */ /* 0x0000000189765BF0-0x0000000189765C10 */ protected set {} } // 0x0000000181C102F0-0x0000000181C10390 0x0000000181C09F60-0x0000000181C0A010
	public string galleryMSG { /* [XID] */ /* 0x000000018976D340-0x000000018976D360 */ get => default; } // 0x0000000181C0D8C0-0x0000000181C0DA40 
	public string pic { /* [XID] */ /* 0x00000001897747D0-0x00000001897747F0 */ get => default; /* [XID] */ /* 0x000000018977C1E0-0x000000018977C200 */ protected set {} } // 0x0000000181C0D730-0x0000000181C0D7E0 0x0000000181C10190-0x0000000181C10240
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint targetTextMapHash { /* [XID] */ /* 0x0000000189783C10-0x0000000189783C30 */ get => default; /* [XID] */ /* 0x000000018978B3E0-0x000000018978B400 */ protected set {} } // 0x0000000181C0A010-0x0000000181C0A0B0 0x0000000181C0A310-0x0000000181C0A3C0
	public string target { /* [XID] */ /* 0x0000000189792860-0x0000000189792880 */ get => default; } // 0x0000000181C0A690-0x0000000181C0A810 
	public string startAudioValues { /* [XID] */ /* 0x0000000189799E30-0x0000000189799E50 */ get => default; /* [XID] */ /* 0x00000001897A1D40-0x00000001897A1D60 */ protected set {} } // 0x0000000181C0E5F0-0x0000000181C0E6A0 0x0000000181C0DC60-0x0000000181C0DD10
	public string endAudioValues { /* [XID] */ /* 0x00000001897A9560-0x00000001897A9580 */ get => default; /* [XID] */ /* 0x00000001897B0CE0-0x00000001897B0D00 */ protected set {} } // 0x0000000181C0DD10-0x0000000181C0DDC0 0x0000000181C0E460-0x0000000181C0E510
	public string[] selectable_ability_groups { /* [XID] */ /* 0x00000001897B8A00-0x00000001897B8A20 */ get => default; /* [XID] */ /* 0x00000001897C0A00-0x00000001897C0A20 */ protected set {} } // 0x0000000181C0A490-0x0000000181C0A540 0x0000000181C0DE60-0x0000000181C0DF10

	// Constructors
	public GalleryExcelConfig() {} // 0x0000000181C10C70-0x0000000181C10CD0

	// Methods
	// [IDTag] // 0x00000001897C83B0-0x00000001897C83F0
	// [XID] // 0x00000001897C83B0-0x00000001897C83F0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000181C0C320-0x0000000181C0D730
	// [IDTag] // 0x00000001897D26F0-0x00000001897D2730
	// [XID] // 0x00000001897D26F0-0x00000001897D2730
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181C0AF00-0x0000000181C0C320
	// [XID] // 0x00000001897DCE90-0x00000001897DCEB0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF21EF */, bool useObjectPool = false /* Metadata: 0x00AF21F3 */) => default; // 0x0000000181C0E850-0x0000000181C0FC20
	[BlackList] // 0x00000001897E47D0-0x00000001897E4810
	// [XID] // 0x00000001897E47D0-0x00000001897E4810
	public virtual void AutoAllocTypeFields() {} // 0x0000000181C0A0B0-0x0000000181C0A150
	[BlackList] // 0x00000001897EF330-0x00000001897EF370
	// [XID] // 0x00000001897EF330-0x00000001897EF370
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181C0A150-0x0000000181C0A310
	[BlackList] // 0x00000001897F9E00-0x00000001897F9E40
	// [XID] // 0x00000001897F9E00-0x00000001897F9E40
	public virtual void ReturnToObjectPool() {} // 0x0000000181C10BD0-0x0000000181C10C70
	[BlackList] // 0x00000001898042F0-0x0000000189804330
	// [XID] // 0x00000001898042F0-0x0000000189804330
	public virtual void OnPoolAllocated() {} // 0x0000000181C10620-0x0000000181C106C0
	[BlackList] // 0x000000018980E8B0-0x000000018980E8F0
	// [XID] // 0x000000018980E8B0-0x000000018980E8F0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181C10580-0x0000000181C10620
}

