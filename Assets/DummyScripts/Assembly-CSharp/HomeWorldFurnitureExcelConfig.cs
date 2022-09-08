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
public class HomeWorldFurnitureExcelConfig : ItemConfig, IAutoAllocRecycle // TypeDefIndex: 15706
{
	// Fields
	protected SimpleSafeUInt32 furnitureIDRawNum; // 0x48
	protected uint _furnitureNameTextMapHash; // 0x4C
	protected SimpleSafeUInt32[] _furnitureGadgetID; // 0x50
	protected SimpleSafeUInt32[] _furnType; // 0x58
	protected FurnitureDeploySurfaceType _surfaceType; // 0x60
	protected SimpleSafeUInt32 isSpecialFurnitureRawNum; // 0x64
	protected SimpleSafeUInt32 roomSceneIDRawNum; // 0x68
	protected SimpleSafeUInt32 gridStyleRawNum; // 0x6C
	protected SimpleSafeUInt32 comfortRawNum; // 0x70
	protected SimpleSafeUInt32 stackLimitRawNum; // 0x74
	protected SimpleSafeUInt32 costRawNum; // 0x78
	protected SimpleSafeUInt32 heightRawNum; // 0x7C
	protected SimpleSafeUInt32 isUniqueRawNum; // 0x80
	protected string _itemIcon; // 0x88
	protected SimpleSafeUInt32 rankLevelRawNum; // 0x90

	// Properties
	public uint furnitureID { /* [XID] */ /* 0x00000001898527C0-0x00000001898527E0 */ get => default; /* [XID] */ /* 0x000000018985A230-0x000000018985A250 */ protected set {} } // 0x0000000183041530-0x0000000183041600 0x00000001830412C0-0x00000001830413A0
	[JsonIgnore] // 0x0000000189B96780-0x0000000189B96790
	public uint furnitureNameTextMapHash { /* [XID] */ /* 0x0000000189861490-0x00000001898614B0 */ get => default; /* [XID] */ /* 0x0000000189868BB0-0x0000000189868BD0 */ protected set {} } // 0x0000000183041B20-0x0000000183041BC0 0x0000000183046180-0x0000000183046230
	public string furnitureName { /* [XID] */ /* 0x0000000189870020-0x0000000189870040 */ get => default; } // 0x0000000183045F30-0x00000001830460B0 
	public SimpleSafeUInt32[] furnitureGadgetID { /* [XID] */ /* 0x00000001898776B0-0x00000001898776D0 */ get => default; /* [XID] */ /* 0x000000018987EF00-0x000000018987EF20 */ protected set {} } // 0x0000000183044290-0x0000000183044330 0x0000000183041D00-0x0000000183041DB0
	public SimpleSafeUInt32[] furnType { /* [XID] */ /* 0x0000000189886520-0x0000000189886540 */ get => default; /* [XID] */ /* 0x000000018988D720-0x000000018988D740 */ protected set {} } // 0x0000000183041600-0x00000001830416A0 0x0000000183045B90-0x0000000183045C40
	public FurnitureDeploySurfaceType surfaceType { /* [XID] */ /* 0x0000000189894E10-0x0000000189894E30 */ get => default; /* [XID] */ /* 0x000000018989C500-0x000000018989C520 */ protected set {} } // 0x00000001830447D0-0x0000000183044870 0x0000000183043ED0-0x0000000183043F80
	public uint isSpecialFurniture { /* [XID] */ /* 0x00000001898A3BA0-0x00000001898A3BC0 */ get => default; /* [XID] */ /* 0x00000001898AAEE0-0x00000001898AAF00 */ protected set {} } // 0x0000000183045E60-0x0000000183045F30 0x00000001830446F0-0x00000001830447D0
	public uint roomSceneID { /* [XID] */ /* 0x00000001898B27F0-0x00000001898B2810 */ get => default; /* [XID] */ /* 0x00000001898BA5A0-0x00000001898BA5C0 */ protected set {} } // 0x0000000183041A50-0x0000000183041B20 0x00000001830413A0-0x0000000183041480
	public uint gridStyle { /* [XID] */ /* 0x00000001898C1820-0x00000001898C1840 */ get => default; /* [XID] */ /* 0x00000001898C91A0-0x00000001898C91C0 */ protected set {} } // 0x0000000183041980-0x0000000183041A50 0x0000000183044610-0x00000001830446F0
	public uint comfort { /* [XID] */ /* 0x00000001898D09C0-0x00000001898D09E0 */ get => default; /* [XID] */ /* 0x00000001898D80A0-0x00000001898D80C0 */ protected set {} } // 0x0000000183044130-0x0000000183044200 0x0000000183043D20-0x0000000183043E00
	public uint stackLimit { /* [XID] */ /* 0x00000001898DFF60-0x00000001898DFF80 */ get => default; /* [XID] */ /* 0x00000001898E7A30-0x00000001898E7A50 */ protected set {} } // 0x0000000183043E00-0x0000000183043ED0 0x0000000183044460-0x0000000183044540
	public uint cost { /* [XID] */ /* 0x00000001898EF0A0-0x00000001898EF0C0 */ get => default; /* [XID] */ /* 0x00000001898F6960-0x00000001898F6980 */ protected set {} } // 0x0000000183044540-0x0000000183044610 0x0000000183045C40-0x0000000183045D20
	public uint height { /* [XID] */ /* 0x00000001898FE100-0x00000001898FE120 */ get => default; /* [XID] */ /* 0x0000000189905980-0x00000001899059A0 */ protected set {} } // 0x00000001830460B0-0x0000000183046180 0x0000000183045D20-0x0000000183045E00
	public uint isUnique { /* [XID] */ /* 0x000000018990D290-0x000000018990D2B0 */ get => default; /* [XID] */ /* 0x00000001899149A0-0x00000001899149C0 */ protected set {} } // 0x0000000183044330-0x0000000183044400 0x0000000183041BC0-0x0000000183041CA0
	public string itemIcon { /* [XID] */ /* 0x000000018991C5A0-0x000000018991C5C0 */ get => default; /* [XID] */ /* 0x0000000189923DA0-0x0000000189923DC0 */ protected set {} } // 0x0000000183046230-0x00000001830462E0 0x0000000183041480-0x0000000183041530
	public uint rankLevel { /* [XID] */ /* 0x000000018992B340-0x000000018992B360 */ get => default; /* [XID] */ /* 0x0000000189932A00-0x0000000189932A20 */ protected set {} } // 0x0000000183044060-0x0000000183044130 0x0000000183043F80-0x0000000183044060

	// Constructors
	public HomeWorldFurnitureExcelConfig() {} // 0x0000000183046380-0x00000001830463E0

	// Methods
	// [IDTag] // 0x000000018993A450-0x000000018993A490
	// [XID] // 0x000000018993A450-0x000000018993A490
	public virtual bool ParseFromLine(string line) => default; // 0x0000000183042D90-0x0000000183043D20
	// [IDTag] // 0x00000001899448C0-0x0000000189944900
	// [XID] // 0x00000001899448C0-0x0000000189944900
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183041DB0-0x0000000183042D90
	// [XID] // 0x000000018994EE20-0x000000018994EE40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF23C3 */, bool useObjectPool = false /* Metadata: 0x00AF23C7 */) => default; // 0x0000000183044870-0x0000000183045B90
	[BlackList] // 0x00000001899563C0-0x0000000189956400
	// [XID] // 0x00000001899563C0-0x0000000189956400
	public override void AutoAllocTypeFields() {} // 0x00000001830416A0-0x0000000183041740
	[BlackList] // 0x0000000189960E00-0x0000000189960E40
	// [XID] // 0x0000000189960E00-0x0000000189960E40
	public override void AutoRecycleTypeFields() {} // 0x0000000183041740-0x00000001830418E0
	[BlackList] // 0x000000018996B3D0-0x000000018996B410
	// [XID] // 0x000000018996B3D0-0x000000018996B410
	public override void ReturnToObjectPool() {} // 0x00000001830462E0-0x0000000183046380
}

