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
using MoleMole.Config;
using Newtonsoft.Json;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class DialogExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14900
{
	// Fields
	private uint[] _nextValidDialogList; // 0x10
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected uint _id; // 0x18
	protected uint[] _nextDialogs; // 0x20
	protected TalkShowType _talkShowType; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected TalkRole _talkRole; // 0x30
	protected uint _talkContentTextMapHash; // 0x38
	protected uint _talkTitleTextMapHash; // 0x3C
	protected uint _talkRoleNameTextMapHash; // 0x40
	protected string _talkAssetPath; // 0x48
	protected string _talkAssetPath_Alter; // 0x50
	protected string _talkAudioName; // 0x58
	protected string _actionBefore; // 0x60
	protected string _actionWhile; // 0x68
	protected string _actionAfter; // 0x70
	protected float _showDuration; // 0x78
	protected uint _groupId; // 0x7C
	protected string _optionIcon; // 0x80

	// Properties
	public bool isForceSelect { /* [XID] */ /* 0x00000001898058F0-0x0000000189805910 */ get => default; } // 0x0000000181271B70-0x0000000181271C20 
	public uint nextDialog { /* [XID] */ /* 0x0000000189823790-0x00000001898237B0 */ get => default; /* [XID] */ /* 0x000000018982B070-0x000000018982B0B0 */ [BlackList] /* 0x000000018982B070-0x000000018982B0B0 */ set {} } // 0x00000001812734D0-0x00000001812735D0 0x0000000181272FA0-0x0000000181273050
	public uint[] nextValidDialogList { /* [XID] */ /* 0x000000018984A0B0-0x000000018984A0D0 */ get => default; } // 0x000000018126EF40-0x000000018126EFE0 
	public uint[] genNextValidDialogList { /* [XID] */ /* 0x0000000189851690-0x00000001898516B0 */ get => default; } // 0x0000000181272D40-0x0000000181272DF0 
	public uint id { /* [XID] */ /* 0x0000000189858CA0-0x0000000189858CC0 */ get => default; /* [XID] */ /* 0x000000018985FED0-0x000000018985FEF0 */ protected set {} } // 0x0000000181273430-0x00000001812734D0 0x0000000181271CC0-0x0000000181271D70
	public uint[] nextDialogs { /* [XID] */ /* 0x0000000189867510-0x0000000189867530 */ get => default; /* [XID] */ /* 0x000000018986ECF0-0x000000018986ED10 */ protected set {} } // 0x0000000181271C20-0x0000000181271CC0 0x0000000181271390-0x0000000181271440
	public TalkShowType talkShowType { /* [XID] */ /* 0x00000001898761A0-0x00000001898761C0 */ get => default; /* [XID] */ /* 0x000000018987DD40-0x000000018987DD60 */ protected set {} } // 0x00000001812714E0-0x0000000181271580 0x000000018126F360-0x000000018126F410
	public TalkRole talkRole { /* [XID] */ /* 0x0000000189884CF0-0x0000000189884D10 */ get => default; /* [XID] */ /* 0x000000018988C360-0x000000018988C380 */ protected set {} } // 0x0000000181271440-0x00000001812714E0 0x0000000181271820-0x00000001812718D0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint talkContentTextMapHash { /* [XID] */ /* 0x0000000189893930-0x0000000189893950 */ get => default; /* [XID] */ /* 0x000000018989B070-0x000000018989B090 */ protected set {} } // 0x000000018126F7A0-0x000000018126F840 0x0000000181270F60-0x0000000181271010
	public string talkContent { /* [XID] */ /* 0x00000001898A23C0-0x00000001898A23E0 */ get => default; } // 0x000000018126F410-0x000000018126F590 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint talkTitleTextMapHash { /* [XID] */ /* 0x00000001898A99B0-0x00000001898A99D0 */ get => default; /* [XID] */ /* 0x00000001898B1340-0x00000001898B1360 */ protected set {} } // 0x0000000181271240-0x00000001812712E0 0x00000001812712E0-0x0000000181271390
	public string talkTitle { /* [XID] */ /* 0x00000001898B8CE0-0x00000001898B8D00 */ get => default; } // 0x00000001812716A0-0x0000000181271820 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint talkRoleNameTextMapHash { /* [XID] */ /* 0x00000001898C02C0-0x00000001898C02E0 */ get => default; /* [XID] */ /* 0x00000001898C7C40-0x00000001898C7C60 */ protected set {} } // 0x0000000181270EC0-0x0000000181270F60 0x000000018126EFE0-0x000000018126F090
	public string talkRoleName { /* [XID] */ /* 0x00000001898CF390-0x00000001898CF3B0 */ get => default; } // 0x0000000181271010-0x0000000181271190 
	public string talkAssetPath { /* [XID] */ /* 0x00000001898D6BC0-0x00000001898D6BE0 */ get => default; /* [XID] */ /* 0x00000001898DE8C0-0x00000001898DE8E0 */ protected set {} } // 0x000000018126EEA0-0x000000018126EF40 0x0000000181270E10-0x0000000181270EC0
	public string talkAssetPath_Alter { /* [XID] */ /* 0x00000001898E6080-0x00000001898E60A0 */ get => default; /* [XID] */ /* 0x00000001898ED9C0-0x00000001898ED9E0 */ protected set {} } // 0x0000000181271A30-0x0000000181271AD0 0x0000000181272A10-0x0000000181272AC0
	public string talkAudioName { /* [XID] */ /* 0x00000001898F5300-0x00000001898F5320 */ get => default; /* [XID] */ /* 0x00000001898FC9B0-0x00000001898FC9D0 */ protected set {} } // 0x0000000181271AD0-0x0000000181271B70 0x0000000181271190-0x0000000181271240
	public string actionBefore { /* [XID] */ /* 0x00000001899043F0-0x0000000189904410 */ get => default; /* [XID] */ /* 0x000000018990BA30-0x000000018990BA50 */ protected set {} } // 0x000000018126F090-0x000000018126F130 0x000000018126F8E0-0x000000018126F990
	public string actionWhile { /* [XID] */ /* 0x0000000189913560-0x0000000189913580 */ get => default; /* [XID] */ /* 0x000000018991AD50-0x000000018991AD70 */ protected set {} } // 0x0000000181273250-0x00000001812732F0 0x0000000181273050-0x0000000181273100
	public string actionAfter { /* [XID] */ /* 0x00000001899224E0-0x0000000189922500 */ get => default; /* [XID] */ /* 0x0000000189929C60-0x0000000189929C80 */ protected set {} } // 0x000000018126F840-0x000000018126F8E0 0x0000000181271980-0x0000000181271A30
	public float showDuration { /* [XID] */ /* 0x00000001899313C0-0x00000001899313E0 */ get => default; /* [XID] */ /* 0x00000001899388D0-0x00000001899388F0 */ protected set {} } // 0x00000001812718D0-0x0000000181271980 0x000000018126F2B0-0x000000018126F360
	public uint groupId { /* [XID] */ /* 0x0000000189940120-0x0000000189940140 */ get => default; /* [XID] */ /* 0x0000000189947700-0x0000000189947720 */ protected set {} } // 0x0000000181273100-0x00000001812731A0 0x00000001812731A0-0x0000000181273250
	public string optionIcon { /* [XID] */ /* 0x000000018994EF20-0x000000018994EF40 */ get => default; /* [XID] */ /* 0x00000001899565A0-0x00000001899565C0 */ protected set {} } // 0x00000001812735D0-0x0000000181273680 0x0000000181272C90-0x0000000181272D40

	// Constructors
	public DialogExcelConfig() {} // 0x0000000181273720-0x0000000181273790

	// Methods
	// [XID] // 0x000000018980D010-0x000000018980D030
	public string GetRealTalkRoleName(uint mainQuestId = 0 /* Metadata: 0x00AEF953 */) => default; // 0x0000000181272DF0-0x0000000181272FA0
	// [XID] // 0x00000001898147D0-0x00000001898147F0
	public uint GetTalkRoleID(uint mainQuestId = 0 /* Metadata: 0x00AEF957 */) => default; // 0x0000000181272AC0-0x0000000181272C90
	// [XID] // 0x000000018981C220-0x000000018981C240
	public string GetTalkAssetByMale(bool isMale) => default; // 0x0000000181271580-0x00000001812716A0
	// [IDTag] // 0x00000001898355F0-0x0000000189835630
	// [XID] // 0x00000001898355F0-0x0000000189835630
	private void GenNextValidDialogList() {} // 0x000000018126F590-0x000000018126F640
	// [IDTag] // 0x000000018983FBF0-0x000000018983FC30
	// [XID] // 0x000000018983FBF0-0x000000018983FC30
	public static void GenNextValidDialogList(uint[] nextDialogs, ref uint[] nextValidDialogList) {} // 0x000000018126F640-0x000000018126F7A0
	// [IDTag] // 0x000000018995DFD0-0x000000018995E010
	// [XID] // 0x000000018995DFD0-0x000000018995E010
	public virtual bool ParseFromLine(string line) => default; // 0x000000018126F990-0x0000000181270450
	// [IDTag] // 0x00000001899686C0-0x0000000189968700
	// [XID] // 0x00000001899686C0-0x0000000189968700
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000181270450-0x0000000181270E10
	// [XID] // 0x0000000189972FF0-0x0000000189973010
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF95B */, bool useObjectPool = false /* Metadata: 0x00AEF95F */) => default; // 0x0000000181271D70-0x0000000181272A10
	[BlackList] // 0x000000018997A8F0-0x000000018997A930
	// [XID] // 0x000000018997A8F0-0x000000018997A930
	public virtual void AutoAllocTypeFields() {} // 0x000000018126F130-0x000000018126F1D0
	[BlackList] // 0x0000000189984CD0-0x0000000189984D10
	// [XID] // 0x0000000189984CD0-0x0000000189984D10
	public virtual void AutoRecycleTypeFields() {} // 0x000000018126F1D0-0x000000018126F2B0
	[BlackList] // 0x000000018998F960-0x000000018998F9A0
	// [XID] // 0x000000018998F960-0x000000018998F9A0
	public virtual void ReturnToObjectPool() {} // 0x0000000181273680-0x0000000181273720
	[BlackList] // 0x000000018999A8D0-0x000000018999A910
	// [XID] // 0x000000018999A8D0-0x000000018999A910
	public virtual void OnPoolAllocated() {} // 0x0000000181273390-0x0000000181273430
	[BlackList] // 0x00000001899A4FB0-0x00000001899A4FF0
	// [XID] // 0x00000001899A4FB0-0x00000001899A4FF0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001812732F0-0x0000000181273390
}

