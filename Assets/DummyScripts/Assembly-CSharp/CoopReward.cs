/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopReward : MessageBase, IMessage<CoopReward> // TypeDefIndex: 22698
{
	// Fields
	private static readonly MessageParser<CoopReward> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B022CF
	private uint id_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B022D3
	private Types.State state_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CoopReward> Parser { get => default; } // 0x0000000183D90520-0x0000000183D905B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D902B0-0x0000000183D90340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D8FF50-0x0000000183D8FFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D8F800-0x0000000183D8F860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D90950-0x0000000183D90A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D90780-0x0000000183D907E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D90340-0x0000000183D90430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D90900-0x0000000183D90950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D90070-0x0000000183D90160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x0000000183D8FEB0-0x0000000183D8FF50 0x0000000183D905B0-0x0000000183D90650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.State State { get => default; set {} } // 0x0000000183D8FD70-0x0000000183D8FE10 0x0000000183D8FE10-0x0000000183D8FEB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22699
	{
		// Nested types
		public enum State // TypeDefIndex: 22700
		{
			Unlock = 0,
			Lock = 1,
			Taken = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopReward() {} // 0x0000000183D90D00-0x0000000183D90D70
	static CoopReward() {} // 0x0000000183D90C40-0x0000000183D90D00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopReward Clone() => default; // 0x0000000183D90430-0x0000000183D90520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopReward ShallowCopy() => default; // 0x0000000183D8FFD0-0x0000000183D90070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D8F990-0x0000000183D8F9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D906E0-0x0000000183D90730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D90730-0x0000000183D90780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D8F9E0-0x0000000183D8FA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D8FB70-0x0000000183D8FC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CoopReward other) => default; // 0x0000000183D8FA50-0x0000000183D8FB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D90160-0x0000000183D902B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D90A40-0x0000000183D90C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D907E0-0x0000000183D90900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D8FC40-0x0000000183D8FD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CoopReward other) {} // 0x0000000183D8F860-0x0000000183D8F990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D8F710-0x0000000183D8F800
}

