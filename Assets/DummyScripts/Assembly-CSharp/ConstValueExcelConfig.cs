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
public class ConstValueExcelConfig : IAutoAllocRecycle // TypeDefIndex: 14851
{
	// Fields
	private static float? _questBoringThreshold; // 0x00
	private static int? _levelSuppressThreshold; // 0x08
	private static int? _seriousLevelSuppressThreshold; // 0x10
	protected ConstValueType _name; // 0x10
	protected string[] _value; // 0x18

	// Properties
	public static float questBoringThreshold { /* [XID] */ /* 0x00000001898EC130-0x00000001898EC150 */ get => default; } // 0x00000001841A7F20-0x00000001841A81B0 
	public ConstValueType name { /* [XID] */ /* 0x00000001898FB080-0x00000001898FB0A0 */ get => default; /* [XID] */ /* 0x0000000189902B80-0x0000000189902BA0 */ protected set {} } // 0x00000001841A8B10-0x00000001841A8BB0 0x00000001841A7E70-0x00000001841A7F20
	public string[] value { /* [XID] */ /* 0x000000018990A1E0-0x000000018990A200 */ get => default; /* [XID] */ /* 0x0000000189911BC0-0x0000000189911BE0 */ protected set {} } // 0x00000001841A7DD0-0x00000001841A7E70 0x00000001841A7D20-0x00000001841A7DD0

	// Nested types
	public enum LevelSuppressType // TypeDefIndex: 14852
	{
		Normal = 0,
		Difficult = 1,
		Dangerous = 2
	}

	// Constructors
	public ConstValueExcelConfig() {} // 0x00000001841A8CD0-0x00000001841A8D30
	static ConstValueExcelConfig() {} // 0x00000001841A8C50-0x00000001841A8CD0

	// Methods
	// [XID] // 0x00000001898F3980-0x00000001898F39A0
	public static LevelSuppressType GetLevelSuppress(float selfLevel, float enermyLevel) => default; // 0x00000001841A8660-0x00000001841A8B10
	// [IDTag] // 0x00000001899196A0-0x00000001899196E0
	// [XID] // 0x00000001899196A0-0x00000001899196E0
	public virtual bool ParseFromLine(string line) => default; // 0x00000001841A7660-0x00000001841A79F0
	// [IDTag] // 0x0000000189923F80-0x0000000189923FC0
	// [XID] // 0x0000000189923F80-0x0000000189923FC0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x00000001841A79F0-0x00000001841A7D20
	// [XID] // 0x000000018992E530-0x000000018992E550
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF7C0 */, bool useObjectPool = false /* Metadata: 0x00AEF7C4 */) => default; // 0x00000001841A81B0-0x00000001841A8520
	[BlackList] // 0x00000001899357F0-0x0000000189935830
	// [XID] // 0x00000001899357F0-0x0000000189935830
	public virtual void AutoAllocTypeFields() {} // 0x00000001841A7520-0x00000001841A75C0
	[BlackList] // 0x0000000189940160-0x00000001899401A0
	// [XID] // 0x0000000189940160-0x00000001899401A0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001841A75C0-0x00000001841A7660
	[BlackList] // 0x000000018994A6E0-0x000000018994A720
	// [XID] // 0x000000018994A6E0-0x000000018994A720
	public virtual void ReturnToObjectPool() {} // 0x00000001841A8BB0-0x00000001841A8C50
	[BlackList] // 0x0000000189954DC0-0x0000000189954E00
	// [XID] // 0x0000000189954DC0-0x0000000189954E00
	public virtual void OnPoolAllocated() {} // 0x00000001841A85C0-0x00000001841A8660
	[BlackList] // 0x000000018995F810-0x000000018995F850
	// [XID] // 0x000000018995F810-0x000000018995F850
	public virtual void OnBeforePoolRecycled() {} // 0x00000001841A8520-0x00000001841A85C0
}

