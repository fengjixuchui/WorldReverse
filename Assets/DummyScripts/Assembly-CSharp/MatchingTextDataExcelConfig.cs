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
public class MatchingTextDataExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15807
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 matchIdRawNum; // 0x10
	protected byte _matchIconHashPre; // 0x14
	protected uint _matchIconHashSuffix; // 0x18
	protected string _matchBtnName; // 0x20
	protected string _matchBtnTips; // 0x28
	protected uint _requirementDescTextMapHash; // 0x30
	protected uint _matchLimitReasonDescTextMapHash; // 0x34
	protected uint _limitWarningDescTextMapHash; // 0x38
	protected uint _inviteGuestDescTextMapHash; // 0x3C
	protected uint _inviteHostDescTextMapHash; // 0x40
	protected string _matchStartDesc; // 0x48
	protected uint _matchTitleTextMapHash; // 0x50
	protected uint _matchSuccessDescTextMapHash; // 0x54

	// Properties
	public uint matchId { /* [XID] */ /* 0x00000001898EF080-0x00000001898EF0A0 */ get => default; /* [XID] */ /* 0x00000001898F6920-0x00000001898F6940 */ protected set {} } // 0x000000018482F580-0x000000018482F650 0x000000018482ECA0-0x000000018482ED80
	public byte matchIconHashPre { /* [XID] */ /* 0x00000001898FE0C0-0x00000001898FE0E0 */ get => default; /* [XID] */ /* 0x0000000189905940-0x0000000189905960 */ protected set {} } // 0x000000018482F790-0x000000018482F830 0x000000018482D710-0x000000018482D7C0
	public uint matchIconHashSuffix { /* [XID] */ /* 0x000000018990D250-0x000000018990D270 */ get => default; /* [XID] */ /* 0x0000000189914960-0x0000000189914980 */ protected set {} } // 0x000000018482D9F0-0x000000018482DA90 0x000000018482D940-0x000000018482D9F0
	public ulong matchIconHash { /* [XID] */ /* 0x000000018991C560-0x000000018991C580 */ get => default; } // 0x000000018482C650-0x000000018482C720 
	public string matchBtnName { /* [XID] */ /* 0x0000000189923D20-0x0000000189923D40 */ get => default; /* [XID] */ /* 0x000000018992B2E0-0x000000018992B300 */ protected set {} } // 0x000000018482C0A0-0x000000018482C140 0x000000018482E1C0-0x000000018482E270
	public string matchBtnTips { /* [XID] */ /* 0x00000001899329E0-0x0000000189932A00 */ get => default; /* [XID] */ /* 0x000000018993A3F0-0x000000018993A410 */ protected set {} } // 0x000000018482F100-0x000000018482F1A0 0x000000018482C5A0-0x000000018482C650
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint requirementDescTextMapHash { /* [XID] */ /* 0x0000000189941460-0x0000000189941480 */ get => default; /* [XID] */ /* 0x0000000189948FC0-0x0000000189948FE0 */ protected set {} } // 0x000000018482C380-0x000000018482C420 0x000000018482DA90-0x000000018482DB40
	public string requirementDesc { /* [XID] */ /* 0x00000001899507B0-0x00000001899507D0 */ get => default; } // 0x000000018482DCC0-0x000000018482DE40 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint matchLimitReasonDescTextMapHash { /* [XID] */ /* 0x0000000189957DA0-0x0000000189957DC0 */ get => default; /* [XID] */ /* 0x000000018995F670-0x000000018995F690 */ protected set {} } // 0x000000018482C8A0-0x000000018482C940 0x000000018482EFA0-0x000000018482F050
	public string matchLimitReasonDesc { /* [XID] */ /* 0x0000000189966EB0-0x0000000189966ED0 */ get => default; } // 0x000000018482D7C0-0x000000018482D940 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint limitWarningDescTextMapHash { /* [XID] */ /* 0x000000018996E1E0-0x000000018996E200 */ get => default; /* [XID] */ /* 0x0000000189975DF0-0x0000000189975E10 */ protected set {} } // 0x000000018482F380-0x000000018482F420 0x000000018482E110-0x000000018482E1C0
	public string limitWarningDesc { /* [XID] */ /* 0x000000018997CED0-0x000000018997CEF0 */ get => default; } // 0x000000018482DE40-0x000000018482DFC0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint inviteGuestDescTextMapHash { /* [XID] */ /* 0x0000000189984B70-0x0000000189984B90 */ get => default; /* [XID] */ /* 0x000000018998C730-0x000000018998C750 */ protected set {} } // 0x000000018482F2E0-0x000000018482F380 0x000000018482F4D0-0x000000018482F580
	public string inviteGuestDesc { /* [XID] */ /* 0x0000000189994490-0x00000001899944B0 */ get => default; } // 0x000000018482EE20-0x000000018482EFA0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint inviteHostDescTextMapHash { /* [XID] */ /* 0x000000018999BCA0-0x000000018999BCC0 */ get => default; /* [XID] */ /* 0x00000001899A3490-0x00000001899A34B0 */ protected set {} } // 0x000000018482ED80-0x000000018482EE20 0x000000018482F420-0x000000018482F4D0
	public string inviteHostDesc { /* [XID] */ /* 0x00000001899AAFC0-0x00000001899AAFE0 */ get => default; } // 0x000000018482C420-0x000000018482C5A0 
	public string matchStartDesc { /* [XID] */ /* 0x00000001899B29F0-0x00000001899B2A10 */ get => default; /* [XID] */ /* 0x00000001899B9B90-0x00000001899B9BB0 */ protected set {} } // 0x000000018482F1A0-0x000000018482F240 0x000000018482F050-0x000000018482F100
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint matchTitleTextMapHash { /* [XID] */ /* 0x00000001899C16D0-0x00000001899C16F0 */ get => default; /* [XID] */ /* 0x00000001899C8C40-0x00000001899C8C60 */ protected set {} } // 0x000000018482F240-0x000000018482F2E0 0x000000018482E060-0x000000018482E110
	public string matchTitle { /* [XID] */ /* 0x00000001899D0670-0x00000001899D0690 */ get => default; } // 0x000000018482DB40-0x000000018482DCC0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint matchSuccessDescTextMapHash { /* [XID] */ /* 0x00000001899D7B10-0x00000001899D7B30 */ get => default; /* [XID] */ /* 0x00000001899DF010-0x00000001899DF030 */ protected set {} } // 0x000000018482DFC0-0x000000018482E060 0x000000018482C140-0x000000018482C1F0
	public string matchSuccessDesc { /* [XID] */ /* 0x00000001899E6C70-0x00000001899E6C90 */ get => default; } // 0x000000018482C720-0x000000018482C8A0 

	// Constructors
	public MatchingTextDataExcelConfig() {} // 0x000000018482F8D0-0x000000018482F930

	// Methods
	// [IDTag] // 0x00000001899EE100-0x00000001899EE140
	// [XID] // 0x00000001899EE100-0x00000001899EE140
	public virtual bool ParseFromLine(string line) => default; // 0x000000018482D030-0x000000018482D710
	// [IDTag] // 0x00000001899F88F0-0x00000001899F8930
	// [XID] // 0x00000001899F88F0-0x00000001899F8930
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x000000018482C940-0x000000018482D030
	// [XID] // 0x0000000189A03010-0x0000000189A03030
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2685 */, bool useObjectPool = false /* Metadata: 0x00AF2689 */) => default; // 0x000000018482E270-0x000000018482ECA0
	[BlackList] // 0x0000000189A0A560-0x0000000189A0A5A0
	// [XID] // 0x0000000189A0A560-0x0000000189A0A5A0
	public virtual void AutoAllocTypeFields() {} // 0x000000018482C1F0-0x000000018482C290
	[BlackList] // 0x0000000189A14DC0-0x0000000189A14E00
	// [XID] // 0x0000000189A14DC0-0x0000000189A14E00
	public virtual void AutoRecycleTypeFields() {} // 0x000000018482C290-0x000000018482C380
	[BlackList] // 0x0000000189A1F010-0x0000000189A1F050
	// [XID] // 0x0000000189A1F010-0x0000000189A1F050
	public virtual void ReturnToObjectPool() {} // 0x000000018482F830-0x000000018482F8D0
	[BlackList] // 0x0000000189A294C0-0x0000000189A29500
	// [XID] // 0x0000000189A294C0-0x0000000189A29500
	public virtual void OnPoolAllocated() {} // 0x000000018482F6F0-0x000000018482F790
	[BlackList] // 0x0000000189A33A80-0x0000000189A33AC0
	// [XID] // 0x0000000189A33A80-0x0000000189A33AC0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018482F650-0x000000018482F6F0
}

