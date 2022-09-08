/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MistTrialLevelData : MessageBase, IMessage<MistTrialLevelData> // TypeDefIndex: 22332
{
	// Fields
	private static readonly MessageParser<MistTrialLevelData> _parser; // 0x00
	public const int LevelIdFieldNumber = 1; // Metadata: 0x00B0159F
	private uint levelId_; // 0x18
	public const int IsOpenFieldNumber = 2; // Metadata: 0x00B015A3
	private bool isOpen_; // 0x1C
	public const int OpenTimeFieldNumber = 3; // Metadata: 0x00B015A7
	private uint openTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MistTrialLevelData> Parser { get => default; } // 0x00000001814D5E00-0x00000001814D5E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001814D5AF0-0x00000001814D5B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001814D57B0-0x00000001814D5830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001814D4FF0-0x00000001814D5050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001814D6310-0x00000001814D6400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001814D6060-0x00000001814D60C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001814D5C20-0x00000001814D5D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001814D62C0-0x00000001814D6310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001814D58D0-0x00000001814D59C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LevelId { get => default; set {} } // 0x00000001814D50F0-0x00000001814D5190 0x00000001814D5B80-0x00000001814D5C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x00000001814D60C0-0x00000001814D6160 0x00000001814D5050-0x00000001814D50F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OpenTime { get => default; set {} } // 0x00000001814D5710-0x00000001814D57B0 0x00000001814D5FC0-0x00000001814D6060

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialLevelData() {} // 0x00000001814D6750-0x00000001814D67B0
	static MistTrialLevelData() {} // 0x00000001814D6690-0x00000001814D6750

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialLevelData Clone() => default; // 0x00000001814D5D10-0x00000001814D5E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialLevelData ShallowCopy() => default; // 0x00000001814D5830-0x00000001814D58D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001814D52F0-0x00000001814D5340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814D5F20-0x00000001814D5F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814D5F70-0x00000001814D5FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001814D5340-0x00000001814D53C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001814D5500-0x00000001814D55D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MistTrialLevelData other) => default; // 0x00000001814D53C0-0x00000001814D5500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001814D59C0-0x00000001814D5AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001814D6400-0x00000001814D6690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001814D6160-0x00000001814D62C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001814D55D0-0x00000001814D5710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MistTrialLevelData other) {} // 0x00000001814D5190-0x00000001814D52F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001814D4EE0-0x00000001814D4FF0
}

