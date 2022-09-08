/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GivingRecordNotify : MessageBase, IMessage<GivingRecordNotify> // TypeDefIndex: 24468
{
	// Fields
	private static readonly MessageParser<GivingRecordNotify> _parser; // 0x00
	public const int GivingRecordListFieldNumber = 1; // Metadata: 0x00B06803
	private static readonly FieldCodec<GivingRecord> _repeated_givingRecordList_codec; // 0x08
	private readonly RepeatedMessageField<GivingRecord> givingRecordList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GivingRecordNotify> Parser { get => default; } // 0x0000000181FEFFF0-0x0000000181FF0080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181FEFD20-0x0000000181FEFDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181FEFA50-0x0000000181FEFAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181FEF4D0-0x0000000181FEF530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181FF03E0-0x0000000181FF04D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181FF0230-0x0000000181FF0290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181FEFE10-0x0000000181FEFF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181FF0390-0x0000000181FF03E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181FEFB70-0x0000000181FEFC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<GivingRecord> GivingRecordList { get => default; } // 0x0000000181FEFDB0-0x0000000181FEFE10 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24469
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24470
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 155
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecordNotify() {} // 0x0000000181FF0730-0x0000000181FF07C0
	static GivingRecordNotify() {} // 0x0000000181FF0620-0x0000000181FF0730

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecordNotify Clone() => default; // 0x0000000181FEFF00-0x0000000181FEFFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GivingRecordNotify ShallowCopy() => default; // 0x0000000181FEFAD0-0x0000000181FEFB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181FEF660-0x0000000181FEF6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FF0110-0x0000000181FF01A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181FF01A0-0x0000000181FF0230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181FEF6B0-0x0000000181FEF780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181FEF890-0x0000000181FEF960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GivingRecordNotify other) => default; // 0x0000000181FEF780-0x0000000181FEF890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181FEFC60-0x0000000181FEFD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181FF04D0-0x0000000181FF0620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181FF0290-0x0000000181FF0390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181FEF960-0x0000000181FEFA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GivingRecordNotify other) {} // 0x0000000181FEF530-0x0000000181FEF660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181FEF3A0-0x0000000181FEF4D0
}

