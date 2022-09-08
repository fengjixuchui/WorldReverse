/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CheckSegmentCRCReq : MessageBase, IMessage<CheckSegmentCRCReq> // TypeDefIndex: 24008
{
	// Fields
	private static readonly MessageParser<CheckSegmentCRCReq> _parser; // 0x00
	public const int InfoListFieldNumber = 1; // Metadata: 0x00B05577
	private static readonly FieldCodec<SegmentCRCInfo> _repeated_infoList_codec; // 0x08
	private readonly RepeatedMessageField<SegmentCRCInfo> infoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CheckSegmentCRCReq> Parser { get => default; } // 0x0000000182D6E4B0-0x0000000182D6E540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D6E240-0x0000000182D6E2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D6DF70-0x0000000182D6DFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D6D990-0x0000000182D6D9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D6E8A0-0x0000000182D6E990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D6E6F0-0x0000000182D6E750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D6E2D0-0x0000000182D6E3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D6E850-0x0000000182D6E8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D6E090-0x0000000182D6E180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SegmentCRCInfo> InfoList { get => default; } // 0x0000000182D6DC40-0x0000000182D6DCA0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24009
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24010
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 20
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CheckSegmentCRCReq() {} // 0x0000000182D6EBF0-0x0000000182D6EC80
	static CheckSegmentCRCReq() {} // 0x0000000182D6EAE0-0x0000000182D6EBF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CheckSegmentCRCReq Clone() => default; // 0x0000000182D6E3C0-0x0000000182D6E4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CheckSegmentCRCReq ShallowCopy() => default; // 0x0000000182D6DFF0-0x0000000182D6E090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D6DB20-0x0000000182D6DB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D6E5D0-0x0000000182D6E660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D6E660-0x0000000182D6E6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D6DB70-0x0000000182D6DC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D6DCA0-0x0000000182D6DD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CheckSegmentCRCReq other) => default; // 0x0000000182D6DD70-0x0000000182D6DE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D6E180-0x0000000182D6E240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D6E990-0x0000000182D6EAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D6E750-0x0000000182D6E850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D6DE80-0x0000000182D6DF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CheckSegmentCRCReq other) {} // 0x0000000182D6D9F0-0x0000000182D6DB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D6D860-0x0000000182D6D990
}

