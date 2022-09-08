/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReliquaryItem : BagItem // TypeDefIndex: 20668
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, ReliquaryLevelExcelConfig>> _levelConfigDic; // 0x00
	private bool _isFake; // 0x68
	private Dictionary<FightPropType, float> _appendPropDic; // 0x70
	private ReliquaryExcelConfig _equipConfig; // 0x78

	// Properties
	public bool isFake { /* [XID] */ /* 0x00000001899486A0-0x00000001899486C0 */ get => default; /* [XID] */ /* 0x000000018994FDF0-0x000000018994FE10 */ set {} } // 0x0000000182E0BD00-0x0000000182E0BDA0 0x0000000182E0C7D0-0x0000000182E0C880
	public uint level { /* [XID] */ /* 0x00000001899573A0-0x00000001899573C0 */ get => default; } // 0x0000000182E0C660-0x0000000182E0C730 
	public uint levelToShow { /* [XID] */ /* 0x000000018995EE70-0x000000018995EE90 */ get => default; } // 0x0000000182E0B440-0x0000000182E0B500 
	public uint mainPropID { /* [XID] */ /* 0x0000000189966710-0x0000000189966730 */ get => default; } // 0x0000000182E0B500-0x0000000182E0B5D0 
	public override uint rankLevel { /* [XID] */ /* 0x000000018996DA70-0x000000018996DA90 */ get => default; } // 0x0000000182E0BDA0-0x0000000182E0BE60 
	public uint appendPropNum { /* [XID] */ /* 0x0000000189975610-0x0000000189975630 */ get => default; } // 0x0000000182E0BC40-0x0000000182E0BD00 
	public uint setId { /* [XID] */ /* 0x000000018997C7B0-0x000000018997C7D0 */ get => default; } // 0x0000000182E0B820-0x0000000182E0B8E0 
	public EquipType equipType { /* [XID] */ /* 0x0000000189984510-0x0000000189984530 */ get => default; } // 0x0000000182E0BB80-0x0000000182E0BC40 
	public FightPropType mainPropType { /* [XID] */ /* 0x000000018998BF90-0x000000018998BFB0 */ get => default; } // 0x0000000182E0B370-0x0000000182E0B440 
	public float mainPropValue { /* [XID] */ /* 0x0000000189993CD0-0x0000000189993CF0 */ get => default; } // 0x0000000182E0C880-0x0000000182E0CB90 
	public Dictionary<FightPropType, float> appendPropDic { /* [XID] */ /* 0x000000018999B500-0x000000018999B520 */ get => default; } // 0x0000000182E0B8E0-0x0000000182E0BB80 
	public ReliquaryExcelConfig equipConfig { /* [XID] */ /* 0x00000001899A2C90-0x00000001899A2CB0 */ get => default; } // 0x0000000182E0B720-0x0000000182E0B820 
	public Reliquary reliquary { /* [XID] */ /* 0x00000001899AA700-0x00000001899AA720 */ get => default; } // 0x0000000182E0C730-0x0000000182E0C7D0 
	public uint maxLevel { /* [XID] */ /* 0x00000001899B2040-0x00000001899B2060 */ get => default; } // 0x0000000182E0B5D0-0x0000000182E0B680 
	public static Dictionary<uint, Dictionary<uint, ReliquaryLevelExcelConfig>> levelConfigDic { /* [XID] */ /* 0x00000001899B94A0-0x00000001899B94C0 */ get => default; } // 0x0000000182E0C1E0-0x0000000182E0C660 

	// Constructors
	public ReliquaryItem() {} // 0x0000000182E0CBF0-0x0000000182E0CC60
	static ReliquaryItem() {} // 0x0000000182E0CB90-0x0000000182E0CBF0

	// Methods
	// [XID] // 0x00000001899C0EB0-0x00000001899C0ED0
	public static List<ReliquarySetInfo> GetSetListByDic(Dictionary<uint, int> setCounts) => default; // 0x0000000182E0BE60-0x0000000182E0C1E0
	// [XID] // 0x00000001899C8450-0x00000001899C8470
	protected override void Recycle() {} // 0x0000000182E0B680-0x0000000182E0B720
}

