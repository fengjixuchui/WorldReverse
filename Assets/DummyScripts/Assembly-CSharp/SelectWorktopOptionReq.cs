/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SelectWorktopOptionReq : MessageBase, IMessage<SelectWorktopOptionReq> // TypeDefIndex: 23188
{
	// Fields
	private static readonly MessageParser<SelectWorktopOptionReq> _parser; // 0x00
	public const int GadgetEntityIdFieldNumber = 1; // Metadata: 0x00B036FF
	private uint gadgetEntityId_; // 0x18
	public const int OptionIdFieldNumber = 2; // Metadata: 0x00B03703
	private uint optionId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SelectWorktopOptionReq> Parser { get => default; } // 0x0000000181D5B850-0x0000000181D5B8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D5B5E0-0x0000000181D5B670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D5B230-0x0000000181D5B2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D5AB80-0x0000000181D5ABE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D5BC80-0x0000000181D5BD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D5BA10-0x0000000181D5BA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D5B670-0x0000000181D5B760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D5BC30-0x0000000181D5BC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D5B3F0-0x0000000181D5B4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000181D5BA70-0x0000000181D5BB10 0x0000000181D5ABE0-0x0000000181D5AC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OptionId { get => default; set {} } // 0x0000000181D5B350-0x0000000181D5B3F0 0x0000000181D5ADB0-0x0000000181D5AE50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23189
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23190
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 805
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectWorktopOptionReq() {} // 0x0000000181D5C030-0x0000000181D5C090
	static SelectWorktopOptionReq() {} // 0x0000000181D5BF70-0x0000000181D5C030

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectWorktopOptionReq Clone() => default; // 0x0000000181D5B760-0x0000000181D5B850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SelectWorktopOptionReq ShallowCopy() => default; // 0x0000000181D5B2B0-0x0000000181D5B350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D5AE50-0x0000000181D5AEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D5B970-0x0000000181D5B9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D5B9C0-0x0000000181D5BA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D5AEA0-0x0000000181D5AF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D5AF10-0x0000000181D5AFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SelectWorktopOptionReq other) => default; // 0x0000000181D5AFE0-0x0000000181D5B100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D5B4E0-0x0000000181D5B5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D5BD70-0x0000000181D5BF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D5BB10-0x0000000181D5BC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D5B100-0x0000000181D5B230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SelectWorktopOptionReq other) {} // 0x0000000181D5AC80-0x0000000181D5ADB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D5AA80-0x0000000181D5AB80
}

