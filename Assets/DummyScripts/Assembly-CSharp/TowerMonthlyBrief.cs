/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerMonthlyBrief : MessageBase, IMessage<TowerMonthlyBrief> // TypeDefIndex: 25718
{
	// Fields
	private static readonly MessageParser<TowerMonthlyBrief> _parser; // 0x00
	public const int TowerScheduleIdFieldNumber = 1; // Metadata: 0x00B09697
	private uint towerScheduleId_; // 0x18
	public const int BestFloorIndexFieldNumber = 2; // Metadata: 0x00B0969B
	private uint bestFloorIndex_; // 0x1C
	public const int BestLevelIndexFieldNumber = 3; // Metadata: 0x00B0969F
	private uint bestLevelIndex_; // 0x20
	public const int TotalStarCountFieldNumber = 4; // Metadata: 0x00B096A3
	private uint totalStarCount_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerMonthlyBrief> Parser { get => default; } // 0x000000018379BE20-0x000000018379BEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018379BA70-0x000000018379BB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018379B660-0x000000018379B6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018379ADD0-0x000000018379AE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018379C370-0x000000018379C460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018379C080-0x000000018379C0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018379BB00-0x000000018379BBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018379C320-0x000000018379C370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018379B780-0x000000018379B870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TowerScheduleId { get => default; set {} } // 0x000000018379B520-0x000000018379B5C0 0x000000018379B9D0-0x000000018379BA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BestFloorIndex { get => default; set {} } // 0x000000018379BFE0-0x000000018379C080 0x000000018379B090-0x000000018379B130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BestLevelIndex { get => default; set {} } // 0x000000018379BD80-0x000000018379BE20 0x000000018379C0E0-0x000000018379C180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalStarCount { get => default; set {} } // 0x000000018379B5C0-0x000000018379B660 0x000000018379BCE0-0x000000018379BD80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyBrief() {} // 0x000000018379C840-0x000000018379C8A0
	static TowerMonthlyBrief() {} // 0x000000018379C780-0x000000018379C840

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyBrief Clone() => default; // 0x000000018379BBF0-0x000000018379BCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyBrief ShallowCopy() => default; // 0x000000018379B6E0-0x000000018379B780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018379AFB0-0x000000018379B000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018379BF40-0x000000018379BF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018379BF90-0x000000018379BFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018379B000-0x000000018379B090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018379B130-0x000000018379B200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerMonthlyBrief other) => default; // 0x000000018379B200-0x000000018379B350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018379B870-0x000000018379B9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018379C460-0x000000018379C780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018379C180-0x000000018379C320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018379B350-0x000000018379B520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerMonthlyBrief other) {} // 0x000000018379AE30-0x000000018379AFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018379ACA0-0x000000018379ADD0
}

