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
public class HomeworldModuleExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15714
{
	// Fields
	public static Func<uint, string> getLocalizedTextHandler; // 0x00
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected bool _isFree; // 0x14
	protected SimpleSafeUInt32 worldSceneIdRawNum; // 0x18
	protected SimpleSafeUInt32 defaultRoomSceneIdRawNum; // 0x1C
	protected SimpleSafeUInt32[] _optionalRoomSceneIdVec; // 0x20
	protected uint _moduleNameTextMapHash; // 0x28
	protected uint _moduleDescTextMapHash; // 0x2C
	protected string[] _region; // 0x30
	protected string[] _regionPointPos; // 0x38
	protected string _smallImageAddr; // 0x40
	protected string _bigImageAddr; // 0x48

	// Properties
	public uint Id { /* [XID] */ /* 0x0000000189735FA0-0x0000000189735FC0 */ get => default; /* [XID] */ /* 0x000000018973DC30-0x000000018973DC50 */ protected set {} } // 0x0000000184253C50-0x0000000184253D20 0x0000000184254CD0-0x0000000184254DB0
	public bool isFree { /* [XID] */ /* 0x0000000189745010-0x0000000189745030 */ get => default; /* [XID] */ /* 0x000000018974CB20-0x000000018974CB40 */ protected set {} } // 0x0000000184253BB0-0x0000000184253C50 0x00000001842526E0-0x0000000184252790
	public uint worldSceneId { /* [XID] */ /* 0x0000000189753E80-0x0000000189753EA0 */ get => default; /* [XID] */ /* 0x000000018975B3C0-0x000000018975B3E0 */ protected set {} } // 0x0000000184252610-0x00000001842526E0 0x0000000184255130-0x0000000184255210
	public uint defaultRoomSceneId { /* [XID] */ /* 0x0000000189762D50-0x0000000189762D70 */ get => default; /* [XID] */ /* 0x000000018976A3B0-0x000000018976A3D0 */ protected set {} } // 0x0000000184254E60-0x0000000184254F30 0x0000000184253DC0-0x0000000184253EA0
	public SimpleSafeUInt32[] optionalRoomSceneIdVec { /* [XID] */ /* 0x0000000189771BD0-0x0000000189771BF0 */ get => default; /* [XID] */ /* 0x0000000189779380-0x00000001897793A0 */ protected set {} } // 0x0000000184254AB0-0x0000000184254B50 0x00000001842553F0-0x00000001842554A0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint moduleNameTextMapHash { /* [XID] */ /* 0x0000000189780B80-0x0000000189780BA0 */ get => default; /* [XID] */ /* 0x0000000189788180-0x00000001897881A0 */ protected set {} } // 0x0000000184254FE0-0x0000000184255080 0x0000000184255080-0x0000000184255130
	public string moduleName { /* [XID] */ /* 0x000000018978F780-0x000000018978F7A0 */ get => default; } // 0x0000000184254B50-0x0000000184254CD0 
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint moduleDescTextMapHash { /* [XID] */ /* 0x0000000189796F90-0x0000000189796FB0 */ get => default; /* [XID] */ /* 0x000000018979EFF0-0x000000018979F010 */ protected set {} } // 0x0000000184253D20-0x0000000184253DC0 0x00000001842554A0-0x0000000184255550
	public string moduleDesc { /* [XID] */ /* 0x00000001897A65E0-0x00000001897A6600 */ get => default; } // 0x0000000184253F40-0x00000001842540C0 
	public string[] region { /* [XID] */ /* 0x00000001897ADBB0-0x00000001897ADBD0 */ get => default; /* [XID] */ /* 0x00000001897B5D30-0x00000001897B5D50 */ protected set {} } // 0x0000000184252320-0x00000001842523C0 0x0000000184254DB0-0x0000000184254E60
	public string[] regionPointPos { /* [XID] */ /* 0x00000001897BDB00-0x00000001897BDB20 */ get => default; /* [XID] */ /* 0x00000001897C4EA0-0x00000001897C4EC0 */ protected set {} } // 0x0000000184253EA0-0x0000000184253F40 0x0000000184254F30-0x0000000184254FE0
	public string smallImageAddr { /* [XID] */ /* 0x00000001897CC6F0-0x00000001897CC710 */ get => default; /* [XID] */ /* 0x00000001897D3FA0-0x00000001897D3FC0 */ protected set {} } // 0x0000000184255210-0x00000001842552B0 0x0000000184252270-0x0000000184252320
	public string bigImageAddr { /* [XID] */ /* 0x00000001897DB8D0-0x00000001897DB8F0 */ get => default; /* [XID] */ /* 0x00000001897E30E0-0x00000001897E3100 */ protected set {} } // 0x0000000184252570-0x0000000184252610 0x00000001842540C0-0x0000000184254170

	// Constructors
	public HomeworldModuleExcelConfig() {} // 0x00000001842555F0-0x0000000184255650

	// Methods
	// [IDTag] // 0x00000001897EA8A0-0x00000001897EA8E0
	// [XID] // 0x00000001897EA8A0-0x00000001897EA8E0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001842531A0-0x0000000184253BB0
	// [IDTag] // 0x00000001897F52D0-0x00000001897F5310
	// [XID] // 0x00000001897F52D0-0x00000001897F5310
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184252790-0x00000001842531A0
	// [XID] // 0x00000001897FFC30-0x00000001897FFC50
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23FF */, bool useObjectPool = false /* Metadata: 0x00AF2403 */) => default; // 0x0000000184254170-0x0000000184254AB0
	[BlackList] // 0x0000000189807230-0x0000000189807270
	// [XID] // 0x0000000189807230-0x0000000189807270
	public virtual void AutoAllocTypeFields() {} // 0x00000001842523C0-0x0000000184252460
	[BlackList] // 0x00000001898117A0-0x00000001898117E0
	// [XID] // 0x00000001898117A0-0x00000001898117E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184252460-0x0000000184252570
	[BlackList] // 0x000000018981C0C0-0x000000018981C100
	// [XID] // 0x000000018981C0C0-0x000000018981C100
	public virtual void ReturnToObjectPool() {} // 0x0000000184255550-0x00000001842555F0
	[BlackList] // 0x00000001898266D0-0x0000000189826710
	// [XID] // 0x00000001898266D0-0x0000000189826710
	public virtual void OnPoolAllocated() {} // 0x0000000184255350-0x00000001842553F0
	[BlackList] // 0x0000000189830D00-0x0000000189830D40
	// [XID] // 0x0000000189830D00-0x0000000189830D40
	public virtual void OnBeforePoolRecycled() {} // 0x00000001842552B0-0x0000000184255350
}

