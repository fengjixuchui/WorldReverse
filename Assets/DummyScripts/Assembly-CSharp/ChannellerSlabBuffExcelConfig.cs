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
public class ChannellerSlabBuffExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15044
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected uint _buffNameTextMapHash; // 0x14
	protected uint _descTextMapHash; // 0x18
	protected string[] _descParam; // 0x20
	protected SimpleSafeUInt32 materialIDRawNum; // 0x28
	protected string _icon; // 0x30
	protected SimpleSafeUInt32 costRawNum; // 0x38
	protected ChannellerSlabBuffQuality _buffQuality; // 0x3C
	protected QualityType _buffQualityType; // 0x40

	// Properties
	public uint id { /* [XID] */ /* 0x00000001897A5090-0x00000001897A50B0 */ get => default; /* [XID] */ /* 0x00000001897AC5C0-0x00000001897AC5E0 */ protected set {} } // 0x0000000185789510-0x00000001857895E0 0x0000000185788270-0x0000000185788350
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint buffNameTextMapHash { /* [XID] */ /* 0x00000001897B4570-0x00000001897B4590 */ get => default; /* [XID] */ /* 0x00000001897BC2F0-0x00000001897BC310 */ protected set {} } // 0x0000000185788050-0x00000001857880F0 0x0000000185787000-0x00000001857870B0
	public string buffName { /* [XID] */ /* 0x00000001897C39F0-0x00000001897C3A10 */ get => default; } // 0x0000000185789050-0x00000001857891D0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint descTextMapHash { /* [XID] */ /* 0x00000001897CB170-0x00000001897CB190 */ get => default; /* [XID] */ /* 0x00000001897D2850-0x00000001897D2870 */ protected set {} } // 0x0000000185788DB0-0x0000000185788E50 0x00000001857870B0-0x0000000185787160
	public string desc { /* [XID] */ /* 0x00000001897DA550-0x00000001897DA570 */ get => default; } // 0x00000001857880F0-0x0000000185788270 
	public string[] descParam { /* [XID] */ /* 0x00000001897E19E0-0x00000001897E1A00 */ get => default; /* [XID] */ /* 0x00000001897E91B0-0x00000001897E91D0 */ protected set {} } // 0x0000000185789330-0x00000001857893D0 0x0000000185789280-0x0000000185789330
	public uint materialID { /* [XID] */ /* 0x00000001897F0D80-0x00000001897F0DA0 */ get => default; /* [XID] */ /* 0x00000001897F8620-0x00000001897F8640 */ protected set {} } // 0x0000000185788420-0x00000001857884F0 0x0000000185787160-0x0000000185787240
	public string icon { /* [XID] */ /* 0x00000001897FFD30-0x00000001897FFD50 */ get => default; /* [XID] */ /* 0x00000001898073D0-0x00000001898073F0 */ protected set {} } // 0x0000000185786DB0-0x0000000185786E50 0x0000000185788F00-0x0000000185788FB0
	public uint cost { /* [XID] */ /* 0x000000018980E9B0-0x000000018980E9D0 */ get => default; /* [XID] */ /* 0x0000000189816050-0x0000000189816070 */ protected set {} } // 0x0000000185788350-0x0000000185788420 0x0000000185788CD0-0x0000000185788DB0
	public ChannellerSlabBuffQuality buffQuality { /* [XID] */ /* 0x000000018981DB10-0x000000018981DB30 */ get => default; /* [XID] */ /* 0x0000000189824F80-0x0000000189824FA0 */ protected set {} } // 0x0000000185788FB0-0x0000000185789050 0x0000000185788E50-0x0000000185788F00
	public QualityType buffQualityType { /* [XID] */ /* 0x000000018982C9B0-0x000000018982C9D0 */ get => default; /* [XID] */ /* 0x0000000189833E80-0x0000000189833EA0 */ protected set {} } // 0x0000000185787240-0x00000001857872E0 0x00000001857891D0-0x0000000185789280

	// Constructors
	public ChannellerSlabBuffExcelConfig() {} // 0x0000000185789680-0x00000001857896E0

	// Methods
	// [IDTag] // 0x000000018983B300-0x000000018983B340
	// [XID] // 0x000000018983B300-0x000000018983B340
	public virtual bool ParseFromLine(string line) => default; // 0x0000000185787980-0x0000000185788050
	// [IDTag] // 0x0000000189845A70-0x0000000189845AB0
	// [XID] // 0x0000000189845A70-0x0000000189845AB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001857872E0-0x0000000185787980
	// [XID] // 0x000000018984FCC0-0x000000018984FCE0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFF4B */, bool useObjectPool = false /* Metadata: 0x00AEFF4F */) => default; // 0x00000001857884F0-0x0000000185788CD0
	[BlackList] // 0x0000000189857100-0x0000000189857140
	// [XID] // 0x0000000189857100-0x0000000189857140
	public virtual void AutoAllocTypeFields() {} // 0x0000000185786E50-0x0000000185786EF0
	[BlackList] // 0x0000000189861570-0x00000001898615B0
	// [XID] // 0x0000000189861570-0x00000001898615B0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185786EF0-0x0000000185787000
	[BlackList] // 0x000000018986BD00-0x000000018986BD40
	// [XID] // 0x000000018986BD00-0x000000018986BD40
	public virtual void ReturnToObjectPool() {} // 0x00000001857895E0-0x0000000185789680
	[BlackList] // 0x0000000189876120-0x0000000189876160
	// [XID] // 0x0000000189876120-0x0000000189876160
	public virtual void OnPoolAllocated() {} // 0x0000000185789470-0x0000000185789510
	[BlackList] // 0x0000000189880820-0x0000000189880860
	// [XID] // 0x0000000189880820-0x0000000189880860
	public virtual void OnBeforePoolRecycled() {} // 0x00000001857893D0-0x0000000185789470
}

