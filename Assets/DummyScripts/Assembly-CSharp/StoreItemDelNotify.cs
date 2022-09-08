/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StoreItemDelNotify : MessageBase, IMessage<StoreItemDelNotify> // TypeDefIndex: 23617
{
	// Fields
	private static readonly MessageParser<StoreItemDelNotify> _parser; // 0x00
	public const int StoreTypeFieldNumber = 1; // Metadata: 0x00B046AF
	private StoreType storeType_; // 0x18
	public const int GuidListFieldNumber = 2; // Metadata: 0x00B046B3
	private static readonly FieldCodec<ulong> _repeated_guidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> guidList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StoreItemDelNotify> Parser { get => default; } // 0x00000001832222B0-0x0000000183222340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183222040-0x00000001832220D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183221CF0-0x0000000183221D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183221570-0x00000001832215D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183222660-0x0000000183222750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183222470-0x00000001832224D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832220D0-0x00000001832221C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183222610-0x0000000183222660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183221E10-0x0000000183221F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreType StoreType { get => default; set {} } // 0x0000000183221700-0x00000001832217A0 0x00000001832218B0-0x0000000183221950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> GuidList { get => default; } // 0x0000000183221C90-0x0000000183221CF0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23618
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23619
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 604
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreItemDelNotify() {} // 0x0000000183222A10-0x0000000183222AB0
	static StoreItemDelNotify() {} // 0x0000000183222930-0x0000000183222A10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreItemDelNotify Clone() => default; // 0x00000001832221C0-0x00000001832222B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreItemDelNotify ShallowCopy() => default; // 0x0000000183221D70-0x0000000183221E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832217A0-0x00000001832217F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832223D0-0x0000000183222420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183222420-0x0000000183222470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001832217F0-0x00000001832218B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183221950-0x0000000183221A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StoreItemDelNotify other) => default; // 0x0000000183221A20-0x0000000183221B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183221F00-0x0000000183222040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183222750-0x0000000183222930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832224D0-0x0000000183222610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183221B50-0x0000000183221C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StoreItemDelNotify other) {} // 0x00000001832215D0-0x0000000183221700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183221410-0x0000000183221570
}

