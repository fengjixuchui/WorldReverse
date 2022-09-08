/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerLevelStarCondData : MessageBase, IMessage<TowerLevelStarCondData> // TypeDefIndex: 25750
{
	// Fields
	private static readonly MessageParser<TowerLevelStarCondData> _parser; // 0x00
	public const int StarCondIndexFieldNumber = 3; // Metadata: 0x00B097EB
	private uint starCondIndex_; // 0x18
	public const int CondValueFieldNumber = 4; // Metadata: 0x00B097EF
	private uint condValue_; // 0x1C
	public const int IsPauseFieldNumber = 5; // Metadata: 0x00B097F3
	private bool isPause_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerLevelStarCondData> Parser { get => default; } // 0x0000000182FFB7C0-0x0000000182FFB850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182FFB4B0-0x0000000182FFB540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182FFB030-0x0000000182FFB0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182FFA900-0x0000000182FFA960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182FFBB90-0x0000000182FFBC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182FFB980-0x0000000182FFB9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182FFB540-0x0000000182FFB630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182FFBB40-0x0000000182FFBB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182FFB1F0-0x0000000182FFB2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StarCondIndex { get => default; set {} } // 0x0000000182FFAB60-0x0000000182FFAC00 0x0000000182FFB720-0x0000000182FFB7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CondValue { get => default; set {} } // 0x0000000182FFB0B0-0x0000000182FFB150 0x0000000182FFB410-0x0000000182FFB4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsPause { get => default; set {} } // 0x0000000182FFA860-0x0000000182FFA900 0x0000000182FFA960-0x0000000182FFAA00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelStarCondData() {} // 0x0000000182FFBFD0-0x0000000182FFC030
	static TowerLevelStarCondData() {} // 0x0000000182FFBF10-0x0000000182FFBFD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelStarCondData Clone() => default; // 0x0000000182FFB630-0x0000000182FFB720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelStarCondData ShallowCopy() => default; // 0x0000000182FFB150-0x0000000182FFB1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182FFAC00-0x0000000182FFAC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FFB8E0-0x0000000182FFB930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FFB930-0x0000000182FFB980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182FFAC50-0x0000000182FFACD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182FFACD0-0x0000000182FFADA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerLevelStarCondData other) => default; // 0x0000000182FFADA0-0x0000000182FFAEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182FFB2E0-0x0000000182FFB410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182FFBC80-0x0000000182FFBF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182FFB9E0-0x0000000182FFBB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182FFAEE0-0x0000000182FFB030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerLevelStarCondData other) {} // 0x0000000182FFAA00-0x0000000182FFAB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182FFA750-0x0000000182FFA860
}

