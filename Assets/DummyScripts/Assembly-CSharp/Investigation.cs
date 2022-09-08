/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Investigation : MessageBase, IMessage<Investigation> // TypeDefIndex: 23571
{
	// Fields
	private static readonly MessageParser<Investigation> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B044F3
	private uint id_; // 0x18
	public const int ProgressFieldNumber = 2; // Metadata: 0x00B044F7
	private uint progress_; // 0x1C
	public const int TotalProgressFieldNumber = 3; // Metadata: 0x00B044FB
	private uint totalProgress_; // 0x20
	public const int StateFieldNumber = 4; // Metadata: 0x00B044FF
	private Types.State state_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Investigation> Parser { get => default; } // 0x000000018509F7A0-0x000000018509F830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018509F490-0x000000018509F520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018509F040-0x000000018509F0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018509E7B0-0x000000018509E810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018509FCF0-0x000000018509FDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018509FA00-0x000000018509FA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018509F5C0-0x000000018509F6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018509FCA0-0x000000018509FCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018509F200-0x000000018509F2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x000000018509EFA0-0x000000018509F040 0x000000018509F830-0x000000018509F8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x000000018509F520-0x000000018509F5C0 0x000000018509F160-0x000000018509F200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalProgress { get => default; set {} } // 0x000000018509FC00-0x000000018509FCA0 0x000000018509E710-0x000000018509E7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.State State { get => default; set {} } // 0x000000018509EE60-0x000000018509EF00 0x000000018509EF00-0x000000018509EFA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23572
	{
		// Nested types
		public enum State // TypeDefIndex: 23573
		{
			Invalid = 0,
			InProgress = 1,
			Complete = 2,
			RewardTaken = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Investigation() {} // 0x00000001850A01C0-0x00000001850A0230
	static Investigation() {} // 0x00000001850A0100-0x00000001850A01C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Investigation Clone() => default; // 0x000000018509F6B0-0x000000018509F7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Investigation ShallowCopy() => default; // 0x000000018509F0C0-0x000000018509F160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018509E990-0x000000018509E9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018509F960-0x000000018509F9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018509F9B0-0x000000018509FA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018509E9E0-0x000000018509EA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018509EA70-0x000000018509EB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Investigation other) => default; // 0x000000018509EB40-0x000000018509EC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018509F2F0-0x000000018509F490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018509FDE0-0x00000001850A0100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018509FA60-0x000000018509FC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018509EC90-0x000000018509EE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Investigation other) {} // 0x000000018509E810-0x000000018509E990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018509E5F0-0x000000018509E710
}

