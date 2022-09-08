/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MarkNewNotify : MessageBase, IMessage<MarkNewNotify> // TypeDefIndex: 24558
{
	// Fields
	private static readonly MessageParser<MarkNewNotify> _parser; // 0x00
	public const int MarkNewTypeFieldNumber = 1; // Metadata: 0x00B06B4F
	private uint markNewType_; // 0x18
	public const int IdListFieldNumber = 2; // Metadata: 0x00B06B53
	private static readonly FieldCodec<uint> _repeated_idList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> idList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MarkNewNotify> Parser { get => default; } // 0x000000018594E3C0-0x000000018594E450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018594E0B0-0x000000018594E140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018594DDA0-0x000000018594DE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018594D760-0x000000018594D7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018594E810-0x000000018594E900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018594E620-0x000000018594E680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018594E140-0x000000018594E230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018594E7C0-0x000000018594E810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018594DEC0-0x000000018594DFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MarkNewType { get => default; set {} } // 0x000000018594E320-0x000000018594E3C0 0x000000018594E450-0x000000018594E4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> IdList { get => default; } // 0x000000018594DA00-0x000000018594DA60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24559
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24560
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1212
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkNewNotify() {} // 0x000000018594EBC0-0x000000018594EC50
	static MarkNewNotify() {} // 0x000000018594EAE0-0x000000018594EBC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkNewNotify Clone() => default; // 0x000000018594E230-0x000000018594E320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MarkNewNotify ShallowCopy() => default; // 0x000000018594DE20-0x000000018594DEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018594D8F0-0x000000018594D940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018594E580-0x000000018594E5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018594E5D0-0x000000018594E620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018594D940-0x000000018594DA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018594DB90-0x000000018594DC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MarkNewNotify other) => default; // 0x000000018594DA60-0x000000018594DB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018594DFB0-0x000000018594E0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018594E900-0x000000018594EAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018594E680-0x000000018594E7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018594DC60-0x000000018594DDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MarkNewNotify other) {} // 0x000000018594D7C0-0x000000018594D8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018594D5F0-0x000000018594D760
}

