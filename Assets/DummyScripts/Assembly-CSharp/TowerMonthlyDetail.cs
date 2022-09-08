/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerMonthlyDetail : MessageBase, IMessage<TowerMonthlyDetail> // TypeDefIndex: 25759
{
	// Fields
	private static readonly MessageParser<TowerMonthlyDetail> _parser; // 0x00
	public const int MonthlyBriefFieldNumber = 1; // Metadata: 0x00B09843
	private TowerMonthlyBrief monthlyBrief_; // 0x18
	public const int MonthlyCombatRecordFieldNumber = 2; // Metadata: 0x00B09847
	private TowerMonthlyCombatRecord monthlyCombatRecord_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerMonthlyDetail> Parser { get => default; } // 0x0000000181A73500-0x0000000181A73590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A731F0-0x0000000181A73280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A72DF0-0x0000000181A72E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A72480-0x0000000181A724E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A739A0-0x0000000181A73A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A737E0-0x0000000181A73840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A73320-0x0000000181A73410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A73950-0x0000000181A739A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A72F10-0x0000000181A73000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyBrief MonthlyBrief { get => default; set {} } // 0x0000000181A72D50-0x0000000181A72DF0 0x0000000181A723E0-0x0000000181A72480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyCombatRecord MonthlyCombatRecord { get => default; set {} } // 0x0000000181A736B0-0x0000000181A73750 0x0000000181A73280-0x0000000181A73320

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyDetail() {} // 0x0000000181A73D10-0x0000000181A73D70
	static TowerMonthlyDetail() {} // 0x0000000181A73C50-0x0000000181A73D10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyDetail Clone() => default; // 0x0000000181A73410-0x0000000181A73500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyDetail ShallowCopy() => default; // 0x0000000181A72E70-0x0000000181A72F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A726C0-0x0000000181A72750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A73620-0x0000000181A736B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A73750-0x0000000181A737E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A72750-0x0000000181A72930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A72A70-0x0000000181A72B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerMonthlyDetail other) => default; // 0x0000000181A72930-0x0000000181A72A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A73000-0x0000000181A731F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A73A90-0x0000000181A73C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A73840-0x0000000181A73950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A72B40-0x0000000181A72D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerMonthlyDetail other) {} // 0x0000000181A724E0-0x0000000181A726C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A72270-0x0000000181A723E0
}

