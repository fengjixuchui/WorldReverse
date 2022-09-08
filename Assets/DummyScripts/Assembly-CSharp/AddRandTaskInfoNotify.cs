/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AddRandTaskInfoNotify : MessageBase, IMessage<AddRandTaskInfoNotify> // TypeDefIndex: 24451
{
	// Fields
	private static readonly MessageParser<AddRandTaskInfoNotify> _parser; // 0x00
	public const int RandTaskIdFieldNumber = 1; // Metadata: 0x00B0676B
	private uint randTaskId_; // 0x18
	public const int PosFieldNumber = 2; // Metadata: 0x00B0676F
	private Vector pos_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AddRandTaskInfoNotify> Parser { get => default; } // 0x0000000184ED7E20-0x0000000184ED7EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184ED7B10-0x0000000184ED7BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184ED7780-0x0000000184ED7800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184ED7050-0x0000000184ED70B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184ED8350-0x0000000184ED8440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184ED80E0-0x0000000184ED8140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184ED7BA0-0x0000000184ED7C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184ED8300-0x0000000184ED8350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184ED78A0-0x0000000184ED7990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RandTaskId { get => default; set {} } // 0x0000000184ED7D80-0x0000000184ED7E20 0x0000000184ED8440-0x0000000184ED84E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000184ED8040-0x0000000184ED80E0 0x0000000184ED8260-0x0000000184ED8300

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24452
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24453
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 150
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddRandTaskInfoNotify() {} // 0x0000000184ED8780-0x0000000184ED87E0
	static AddRandTaskInfoNotify() {} // 0x0000000184ED86C0-0x0000000184ED8780

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddRandTaskInfoNotify Clone() => default; // 0x0000000184ED7C90-0x0000000184ED7D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddRandTaskInfoNotify ShallowCopy() => default; // 0x0000000184ED7800-0x0000000184ED78A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184ED7230-0x0000000184ED72B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ED7F40-0x0000000184ED7FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ED7FC0-0x0000000184ED8040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184ED72B0-0x0000000184ED73E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184ED7510-0x0000000184ED75E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AddRandTaskInfoNotify other) => default; // 0x0000000184ED73E0-0x0000000184ED7510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184ED7990-0x0000000184ED7B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184ED84E0-0x0000000184ED86C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184ED8140-0x0000000184ED8260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184ED75E0-0x0000000184ED7780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AddRandTaskInfoNotify other) {} // 0x0000000184ED70B0-0x0000000184ED7230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184ED6F10-0x0000000184ED7050
}

