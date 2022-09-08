/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MetNpcIdListNotify : MessageBase, IMessage<MetNpcIdListNotify> // TypeDefIndex: 24213
{
	// Fields
	private static readonly MessageParser<MetNpcIdListNotify> _parser; // 0x00
	public const int NpcFirstMetIdListFieldNumber = 1; // Metadata: 0x00B05DD7
	private static readonly FieldCodec<uint> _repeated_npcFirstMetIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> npcFirstMetIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MetNpcIdListNotify> Parser { get => default; } // 0x000000018214A540-0x000000018214A5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018214A2D0-0x000000018214A360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018214A000-0x000000018214A080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182149AC0-0x0000000182149B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018214A910-0x000000018214AA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018214A700-0x000000018214A760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018214A360-0x000000018214A450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018214A8C0-0x000000018214A910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018214A120-0x000000018214A210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> NpcFirstMetIdList { get => default; } // 0x000000018214A860-0x000000018214A8C0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24214
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24215
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 506
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MetNpcIdListNotify() {} // 0x000000018214AC30-0x000000018214ACC0
	static MetNpcIdListNotify() {} // 0x000000018214AB50-0x000000018214AC30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MetNpcIdListNotify Clone() => default; // 0x000000018214A450-0x000000018214A540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MetNpcIdListNotify ShallowCopy() => default; // 0x000000018214A080-0x000000018214A120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182149C30-0x0000000182149C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018214A660-0x000000018214A6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018214A6B0-0x000000018214A700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182149C80-0x0000000182149D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182149D40-0x0000000182149E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MetNpcIdListNotify other) => default; // 0x0000000182149E10-0x0000000182149F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018214A210-0x000000018214A2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018214AA00-0x000000018214AB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018214A760-0x000000018214A860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182149F10-0x000000018214A000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MetNpcIdListNotify other) {} // 0x0000000182149B20-0x0000000182149C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182149980-0x0000000182149AC0
}

