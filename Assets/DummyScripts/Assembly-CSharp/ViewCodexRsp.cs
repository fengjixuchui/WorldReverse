/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ViewCodexRsp : MessageBase, IMessage<ViewCodexRsp> // TypeDefIndex: 22671
{
	// Fields
	private static readonly MessageParser<ViewCodexRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B021D3
	private int retcode_; // 0x18
	public const int TypeDataListFieldNumber = 2; // Metadata: 0x00B021D7
	private static readonly FieldCodec<CodexTypeData> _repeated_typeDataList_codec; // 0x08
	private readonly RepeatedMessageField<CodexTypeData> typeDataList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ViewCodexRsp> Parser { get => default; } // 0x0000000182635190-0x0000000182635220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182634F20-0x0000000182634FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182634BB0-0x0000000182634C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182634440-0x00000001826344A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001826355C0-0x00000001826356B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001826353D0-0x0000000182635430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182634FB0-0x00000001826350A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182635570-0x00000001826355C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182634CD0-0x0000000182634DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182634B10-0x0000000182634BB0 0x0000000182634730-0x00000001826347D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CodexTypeData> TypeDataList { get => default; } // 0x0000000182634EC0-0x0000000182634F20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22672
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22673
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4208
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ViewCodexRsp() {} // 0x00000001826359A0-0x0000000182635A30
	static ViewCodexRsp() {} // 0x0000000182635890-0x00000001826359A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ViewCodexRsp Clone() => default; // 0x00000001826350A0-0x0000000182635190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ViewCodexRsp ShallowCopy() => default; // 0x0000000182634C30-0x0000000182634CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182634600-0x0000000182634650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001826352B0-0x0000000182635340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182635340-0x00000001826353D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182634650-0x0000000182634730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001826347D0-0x00000001826348A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ViewCodexRsp other) => default; // 0x00000001826348A0-0x00000001826349D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182634DC0-0x0000000182634EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001826356B0-0x0000000182635890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182635430-0x0000000182635570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001826349D0-0x0000000182634B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ViewCodexRsp other) {} // 0x00000001826344A0-0x0000000182634600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001826342E0-0x0000000182634440
}

