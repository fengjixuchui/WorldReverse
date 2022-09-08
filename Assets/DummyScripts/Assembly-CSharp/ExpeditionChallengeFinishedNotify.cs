/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExpeditionChallengeFinishedNotify : MessageBase, IMessage<ExpeditionChallengeFinishedNotify> // TypeDefIndex: 22201
{
	// Fields
	private static readonly MessageParser<ExpeditionChallengeFinishedNotify> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B01073
	private uint id_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExpeditionChallengeFinishedNotify> Parser { get => default; } // 0x00000001817E7770-0x00000001817E7800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001817E7500-0x00000001817E7590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001817E7210-0x00000001817E7290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001817E6C80-0x00000001817E6CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001817E7B60-0x00000001817E7C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001817E79D0-0x00000001817E7A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001817E7590-0x00000001817E7680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001817E7B10-0x00000001817E7B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001817E7330-0x00000001817E7420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x00000001817E7170-0x00000001817E7210 0x00000001817E7800-0x00000001817E78A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22202
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22203
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2172
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionChallengeFinishedNotify() {} // 0x00000001817E7E80-0x00000001817E7EE0
	static ExpeditionChallengeFinishedNotify() {} // 0x00000001817E7DC0-0x00000001817E7E80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionChallengeFinishedNotify Clone() => default; // 0x00000001817E7680-0x00000001817E7770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionChallengeFinishedNotify ShallowCopy() => default; // 0x00000001817E7290-0x00000001817E7330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001817E6DF0-0x00000001817E6E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817E7930-0x00000001817E7980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817E7980-0x00000001817E79D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001817E6E40-0x00000001817E6EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001817E6FB0-0x00000001817E7080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExpeditionChallengeFinishedNotify other) => default; // 0x00000001817E6EB0-0x00000001817E6FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001817E7420-0x00000001817E7500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001817E7C50-0x00000001817E7DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001817E7A30-0x00000001817E7B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001817E7080-0x00000001817E7170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExpeditionChallengeFinishedNotify other) {} // 0x00000001817E6CE0-0x00000001817E6DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001817E6BA0-0x00000001817E6C80
}

