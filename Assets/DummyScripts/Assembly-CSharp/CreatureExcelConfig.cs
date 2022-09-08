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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class CreatureExcelConfig : EntityExcelConfig, IAutoAllocRecycle // TypeDefIndex: 15399
{
	// Fields
	protected SimpleSafeFloat hp_baseRawNum; // 0x48
	protected SimpleSafeFloat attack_baseRawNum; // 0x4C
	protected SimpleSafeFloat defense_baseRawNum; // 0x50
	protected SimpleSafeFloat criticalRawNum; // 0x54
	protected SimpleSafeFloat antiCriticalRawNum; // 0x58
	protected SimpleSafeFloat criticalHurtRawNum; // 0x5C
	protected SimpleSafeFloat fireSubHurtRawNum; // 0x60
	protected SimpleSafeFloat grassSubHurtRawNum; // 0x64
	protected SimpleSafeFloat waterSubHurtRawNum; // 0x68
	protected SimpleSafeFloat elecSubHurtRawNum; // 0x6C
	protected SimpleSafeFloat windSubHurtRawNum; // 0x70
	protected SimpleSafeFloat iceSubHurtRawNum; // 0x74
	protected SimpleSafeFloat rockSubHurtRawNum; // 0x78
	protected SimpleSafeFloat fireAddHurtRawNum; // 0x7C
	protected SimpleSafeFloat grassAddHurtRawNum; // 0x80
	protected SimpleSafeFloat waterAddHurtRawNum; // 0x84
	protected SimpleSafeFloat elecAddHurtRawNum; // 0x88
	protected SimpleSafeFloat windAddHurtRawNum; // 0x8C
	protected SimpleSafeFloat iceAddHurtRawNum; // 0x90
	protected SimpleSafeFloat rockAddHurtRawNum; // 0x94
	protected FightPropGrowConfig[] _propGrowCurves; // 0x98
	protected SimpleSafeFloat elementMasteryRawNum; // 0xA0
	protected SimpleSafeFloat physicalSubHurtRawNum; // 0xA4
	protected SimpleSafeFloat physicalAddHurtRawNum; // 0xA8
	protected byte _prefabPathRagdollHashPre; // 0xAC
	protected uint _prefabPathRagdollHashSuffix; // 0xB0

	// Properties
	public float hp_base { /* [XID] */ /* 0x0000000189780CA0-0x0000000189780CC0 */ get => default; /* [XID] */ /* 0x00000001897881E0-0x0000000189788200 */ protected set {} } // 0x00000001848D35D0-0x00000001848D36B0 0x00000001848D1C00-0x00000001848D1CE0
	public float attack_base { /* [XID] */ /* 0x0000000189709BE0-0x0000000189709C00 */ get => default; /* [XID] */ /* 0x0000000189797030-0x0000000189797050 */ protected set {} } // 0x00000001848D6880-0x00000001848D6960 0x00000001848D5D00-0x00000001848D5DE0
	public float defense_base { /* [XID] */ /* 0x000000018979F030-0x000000018979F050 */ get => default; /* [XID] */ /* 0x00000001897A6620-0x00000001897A6640 */ protected set {} } // 0x00000001848D6C00-0x00000001848D6CE0 0x00000001848D1660-0x00000001848D1740
	public float critical { /* [XID] */ /* 0x0000000189727940-0x0000000189727960 */ get => default; /* [XID] */ /* 0x00000001897B5DD0-0x00000001897B5DF0 */ protected set {} } // 0x00000001848D14A0-0x00000001848D1580 0x00000001848D36B0-0x00000001848D3790
	public float antiCritical { /* [XID] */ /* 0x000000018973E420-0x000000018973E440 */ get => default; /* [XID] */ /* 0x00000001897C4FC0-0x00000001897C4FE0 */ protected set {} } // 0x00000001848D3870-0x00000001848D3950 0x00000001848D3120-0x00000001848D3200
	public float criticalHurt { /* [XID] */ /* 0x00000001897CC7D0-0x00000001897CC7F0 */ get => default; /* [XID] */ /* 0x00000001897D4000-0x00000001897D4020 */ protected set {} } // 0x00000001848D5C20-0x00000001848D5D00 0x00000001848D1320-0x00000001848D1400
	public float fireSubHurt { /* [XID] */ /* 0x0000000189736670-0x0000000189736690 */ get => default; /* [XID] */ /* 0x00000001897E31A0-0x00000001897E31C0 */ protected set {} } // 0x00000001848D6A40-0x00000001848D6B20 0x00000001848D65E0-0x00000001848D66C0
	public float grassSubHurt { /* [XID] */ /* 0x00000001897EA900-0x00000001897EA920 */ get => default; /* [XID] */ /* 0x00000001897F2690-0x00000001897F26B0 */ protected set {} } // 0x00000001848D6290-0x00000001848D6370 0x00000001848D1DC0-0x00000001848D1EA0
	public float waterSubHurt { /* [XID] */ /* 0x00000001897F9EC0-0x00000001897F9EE0 */ get => default; /* [XID] */ /* 0x0000000189801440-0x0000000189801460 */ protected set {} } // 0x00000001848D1CE0-0x00000001848D1DC0 0x00000001848D6000-0x00000001848D60E0
	public float elecSubHurt { /* [XID] */ /* 0x0000000189763480-0x00000001897634A0 */ get => default; /* [XID] */ /* 0x0000000189810250-0x0000000189810270 */ protected set {} } // 0x00000001848D66C0-0x00000001848D67A0 0x00000001848D0EF0-0x00000001848D0FD0
	public float windSubHurt { /* [XID] */ /* 0x00000001897721F0-0x0000000189772210 */ get => default; /* [XID] */ /* 0x000000018981F260-0x000000018981F280 */ protected set {} } // 0x00000001848D5F20-0x00000001848D6000 0x00000001848D6960-0x00000001848D6A40
	public float iceSubHurt { /* [XID] */ /* 0x0000000189779960-0x0000000189779980 */ get => default; /* [XID] */ /* 0x000000018982DDE0-0x000000018982DE00 */ protected set {} } // 0x00000001848D5B40-0x00000001848D5C20 0x00000001848D5A60-0x00000001848D5B40
	public float rockSubHurt { /* [XID] */ /* 0x0000000189781320-0x0000000189781340 */ get => default; /* [XID] */ /* 0x000000018983CC50-0x000000018983CC70 */ protected set {} } // 0x00000001848D6450-0x00000001848D6530 0x00000001848D5E40-0x00000001848D5F20
	public float fireAddHurt { /* [XID] */ /* 0x0000000189788840-0x0000000189788860 */ get => default; /* [XID] */ /* 0x000000018984B790-0x000000018984B7B0 */ protected set {} } // 0x00000001848D3BC0-0x00000001848D3CA0 0x00000001848D1B20-0x00000001848D1C00
	public float grassAddHurt { /* [XID] */ /* 0x000000018978FF60-0x000000018978FF80 */ get => default; /* [XID] */ /* 0x000000018985A2B0-0x000000018985A2D0 */ protected set {} } // 0x00000001848D34F0-0x00000001848D35D0 0x00000001848D3790-0x00000001848D3870
	public float waterAddHurt { /* [XID] */ /* 0x000000018979F6D0-0x000000018979F6F0 */ get => default; /* [XID] */ /* 0x0000000189868C50-0x0000000189868C70 */ protected set {} } // 0x00000001848D3A30-0x00000001848D3B10 0x00000001848D1A40-0x00000001848D1B20
	public float elecAddHurt { /* [XID] */ /* 0x00000001898700A0-0x00000001898700C0 */ get => default; /* [XID] */ /* 0x00000001898776F0-0x0000000189877710 */ protected set {} } // 0x00000001848D32B0-0x00000001848D3390 0x00000001848D3F50-0x00000001848D4030
	public float windAddHurt { /* [XID] */ /* 0x000000018987EF60-0x000000018987EF80 */ get => default; /* [XID] */ /* 0x0000000189886540-0x0000000189886560 */ protected set {} } // 0x00000001848D1740-0x00000001848D1820 0x00000001848D3D90-0x00000001848D3E70
	public float iceAddHurt { /* [XID] */ /* 0x000000018988D760-0x000000018988D780 */ get => default; /* [XID] */ /* 0x0000000189894E70-0x0000000189894E90 */ protected set {} } // 0x00000001848D3950-0x00000001848D3A30 0x00000001848D6B20-0x00000001848D6C00
	public float rockAddHurt { /* [XID] */ /* 0x000000018989C540-0x000000018989C560 */ get => default; /* [XID] */ /* 0x00000001898A3CE0-0x00000001898A3D00 */ protected set {} } // 0x00000001848D1820-0x00000001848D1900 0x00000001848D0E10-0x00000001848D0EF0
	public FightPropGrowConfig[] propGrowCurves { /* [XID] */ /* 0x00000001898AAF20-0x00000001898AAF40 */ get => default; /* [XID] */ /* 0x00000001898B2830-0x00000001898B2850 */ protected set {} } // 0x00000001848D3390-0x00000001848D3440 0x00000001848D3B10-0x00000001848D3BC0
	public float elementMastery { /* [XID] */ /* 0x00000001898BA620-0x00000001898BA640 */ get => default; /* [XID] */ /* 0x00000001898C1880-0x00000001898C18A0 */ protected set {} } // 0x00000001848D6370-0x00000001848D6450 0x00000001848D60E0-0x00000001848D61C0
	public float physicalSubHurt { /* [XID] */ /* 0x00000001898C9240-0x00000001898C9260 */ get => default; /* [XID] */ /* 0x00000001898D0AA0-0x00000001898D0AC0 */ protected set {} } // 0x00000001848D3E70-0x00000001848D3F50 0x00000001848D67A0-0x00000001848D6880
	public float physicalAddHurt { /* [XID] */ /* 0x00000001898D8140-0x00000001898D8160 */ get => default; /* [XID] */ /* 0x00000001898DFFC0-0x00000001898DFFE0 */ protected set {} } // 0x00000001848D1580-0x00000001848D1660 0x00000001848D1960-0x00000001848D1A40
	public byte prefabPathRagdollHashPre { /* [XID] */ /* 0x0000000189999280-0x00000001899992A0 */ get => default; /* [XID] */ /* 0x00000001898EF140-0x00000001898EF160 */ protected set {} } // 0x00000001848D6530-0x00000001848D65E0 0x00000001848D3440-0x00000001848D34F0
	public uint prefabPathRagdollHashSuffix { /* [XID] */ /* 0x00000001898F6A80-0x00000001898F6AA0 */ get => default; /* [XID] */ /* 0x00000001898FE160-0x00000001898FE180 */ protected set {} } // 0x00000001848D6CE0-0x00000001848D6D80 0x00000001848D3200-0x00000001848D32B0
	public ulong prefabPathRagdollHash { /* [XID] */ /* 0x0000000189905A20-0x0000000189905A40 */ get => default; } // 0x00000001848D61C0-0x00000001848D6290 

	// Constructors
	public CreatureExcelConfig() {} // 0x00000001848D6E20-0x00000001848D6E80

	// Methods
	// [XID] // 0x000000018990D2B0-0x000000018990D2D0
	public override bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001848D1EA0-0x00000001848D3120
	// [XID] // 0x0000000189914A00-0x0000000189914A20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF1429 */, bool useObjectPool = false /* Metadata: 0x00AF142D */) => default; // 0x00000001848D4030-0x00000001848D5A60
	[BlackList] // 0x000000018991C600-0x000000018991C640
	// [XID] // 0x000000018991C600-0x000000018991C640
	public override void AutoAllocTypeFields() {} // 0x00000001848D0FD0-0x00000001848D1070
	[BlackList] // 0x0000000189926C40-0x0000000189926C80
	// [XID] // 0x0000000189926C40-0x0000000189926C80
	public override void AutoRecycleTypeFields() {} // 0x00000001848D1070-0x00000001848D1320
	[BlackList] // 0x00000001899311A0-0x00000001899311E0
	// [XID] // 0x00000001899311A0-0x00000001899311E0
	public override void ReturnToObjectPool() {} // 0x00000001848D6D80-0x00000001848D6E20
}

