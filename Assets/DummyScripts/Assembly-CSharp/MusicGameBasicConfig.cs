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
public class MusicGameBasicConfig : IAutoAllocRecycle // TypeDefIndex: 15146
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 idRawNum; // 0x10
	protected SimpleSafeUInt32 musicIDRawNum; // 0x14
	protected SimpleSafeUInt32 musicLevelRawNum; // 0x18
	protected string _jsonPath; // 0x20
	protected SimpleSafeFloat successPrePointRawNum; // 0x28
	protected SimpleSafeFloat successLatePointRawNum; // 0x2C
	protected SimpleSafeUInt32 scaleTimeRawNum; // 0x30
	protected SimpleSafeFloat scaleRangeRawNum; // 0x34
	protected SimpleSafeUInt32[] _scoreLevelList; // 0x38
	protected SimpleSafeUInt32 scoreOneKeyRawNum; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected ComboConfig[] _comboConfig; // 0x48
	protected uint _unlockTipsTextMapHash; // 0x50

	// Properties
	public uint id { /* [XID] */ /* 0x0000000189686F90-0x0000000189686FB0 */ get => default; /* [XID] */ /* 0x000000018968ED90-0x000000018968EDB0 */ protected set {} } // 0x00000001843EC950-0x00000001843ECA20 0x00000001843EB7E0-0x00000001843EB8C0
	public uint musicID { /* [XID] */ /* 0x0000000189696710-0x0000000189696730 */ get => default; /* [XID] */ /* 0x000000018969DDB0-0x000000018969DDD0 */ protected set {} } // 0x00000001843EB490-0x00000001843EB560 0x00000001843E9BE0-0x00000001843E9CC0
	public uint musicLevel { /* [XID] */ /* 0x00000001896A4D80-0x00000001896A4DA0 */ get => default; /* [XID] */ /* 0x00000001896AC630-0x00000001896AC650 */ protected set {} } // 0x00000001843EB710-0x00000001843EB7E0 0x00000001843EBA10-0x00000001843EBAF0
	public string jsonPath { /* [XID] */ /* 0x00000001896B38B0-0x00000001896B38D0 */ get => default; /* [XID] */ /* 0x00000001896BAF70-0x00000001896BAF90 */ protected set {} } // 0x00000001843EC690-0x00000001843EC730 0x00000001843E9900-0x00000001843E99B0
	public float successPrePoint { /* [XID] */ /* 0x00000001896C2120-0x00000001896C2140 */ get => default; /* [XID] */ /* 0x00000001896C9730-0x00000001896C9750 */ protected set {} } // 0x00000001843E9CC0-0x00000001843E9DA0 0x00000001843E9520-0x00000001843E9600
	public float successLatePoint { /* [XID] */ /* 0x00000001896D0E80-0x00000001896D0EA0 */ get => default; /* [XID] */ /* 0x00000001896D85D0-0x00000001896D85F0 */ protected set {} } // 0x00000001843EC4D0-0x00000001843EC5B0 0x00000001843EC5B0-0x00000001843EC690
	public uint scaleTime { /* [XID] */ /* 0x00000001896DFFC0-0x00000001896DFFE0 */ get => default; /* [XID] */ /* 0x00000001896E71E0-0x00000001896E7200 */ protected set {} } // 0x00000001843EB560-0x00000001843EB630 0x00000001843EC730-0x00000001843EC810
	public float scaleRange { /* [XID] */ /* 0x00000001896EE850-0x00000001896EE870 */ get => default; /* [XID] */ /* 0x00000001896F60E0-0x00000001896F6100 */ protected set {} } // 0x00000001843EB630-0x00000001843EB710 0x00000001843EB1C0-0x00000001843EB2A0
	public SimpleSafeUInt32[] scoreLevelList { /* [XID] */ /* 0x00000001896FD910-0x00000001896FD930 */ get => default; /* [XID] */ /* 0x0000000189704DB0-0x0000000189704DD0 */ protected set {} } // 0x00000001843EB3F0-0x00000001843EB490 0x00000001843EB2A0-0x00000001843EB350
	public uint scoreOneKey { /* [XID] */ /* 0x000000018970C4B0-0x000000018970C4D0 */ get => default; /* [XID] */ /* 0x0000000189713E20-0x0000000189713E40 */ protected set {} } // 0x00000001843E9830-0x00000001843E9900 0x00000001843ECA20-0x00000001843ECB00
	public ComboConfig[] comboConfig { /* [XID] */ /* 0x000000018971B6A0-0x000000018971B6C0 */ get => default; /* [XID] */ /* 0x0000000189722900-0x0000000189722920 */ protected set {} } // 0x00000001843EB970-0x00000001843EBA10 0x00000001843E9B30-0x00000001843E9BE0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint unlockTipsTextMapHash { /* [XID] */ /* 0x000000018972A080-0x000000018972A0A0 */ get => default; /* [XID] */ /* 0x00000001897316E0-0x0000000189731700 */ protected set {} } // 0x00000001843EB350-0x00000001843EB3F0 0x00000001843EB8C0-0x00000001843EB970
	public string unlockTips { /* [XID] */ /* 0x0000000189738F50-0x0000000189738F70 */ get => default; } // 0x00000001843E99B0-0x00000001843E9B30 

	// Constructors
	public MusicGameBasicConfig() {} // 0x00000001843ECBA0-0x00000001843ECC00

	// Methods
	// [IDTag] // 0x0000000189740CE0-0x0000000189740D20
	// [XID] // 0x0000000189740CE0-0x0000000189740D20
	public virtual bool ParseFromLine(string line) => default; // 0x00000001843E9DA0-0x00000001843EA820
	// [IDTag] // 0x000000018974B4A0-0x000000018974B4E0
	// [XID] // 0x000000018974B4A0-0x000000018974B4E0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001843EA820-0x00000001843EB1C0
	// [XID] // 0x00000001897559D0-0x00000001897559F0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0226 */, bool useObjectPool = false /* Metadata: 0x00AF022A */) => default; // 0x00000001843EBAF0-0x00000001843EC4D0
	[BlackList] // 0x000000018975CCD0-0x000000018975CD10
	// [XID] // 0x000000018975CCD0-0x000000018975CD10
	public virtual void AutoAllocTypeFields() {} // 0x00000001843E9600-0x00000001843E96A0
	[BlackList] // 0x0000000189767500-0x0000000189767540
	// [XID] // 0x0000000189767500-0x0000000189767540
	public virtual void AutoRecycleTypeFields() {} // 0x00000001843E96A0-0x00000001843E9830
	[BlackList] // 0x0000000189771CD0-0x0000000189771D10
	// [XID] // 0x0000000189771CD0-0x0000000189771D10
	public virtual void ReturnToObjectPool() {} // 0x00000001843ECB00-0x00000001843ECBA0
	[BlackList] // 0x000000018977C340-0x000000018977C380
	// [XID] // 0x000000018977C340-0x000000018977C380
	public virtual void OnPoolAllocated() {} // 0x00000001843EC8B0-0x00000001843EC950
	[BlackList] // 0x0000000189786B80-0x0000000189786BC0
	// [XID] // 0x0000000189786B80-0x0000000189786BC0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001843EC810-0x00000001843EC8B0
}

