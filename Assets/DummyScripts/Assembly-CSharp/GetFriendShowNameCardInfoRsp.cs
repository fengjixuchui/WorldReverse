/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetFriendShowNameCardInfoRsp : MessageBase, IMessage<GetFriendShowNameCardInfoRsp> // TypeDefIndex: 25681
{
	// Fields
	private static readonly MessageParser<GetFriendShowNameCardInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0951B
	private int retcode_; // 0x18
	public const int UidFieldNumber = 2; // Metadata: 0x00B0951F
	private uint uid_; // 0x1C
	public const int ShowNameCardIdListFieldNumber = 3; // Metadata: 0x00B09523
	private static readonly FieldCodec<uint> _repeated_showNameCardIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> showNameCardIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetFriendShowNameCardInfoRsp> Parser { get => default; } // 0x0000000182362160-0x00000001823621F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182361E50-0x0000000182361EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182361B10-0x0000000182361B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823612B0-0x0000000182361310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823625A0-0x0000000182362690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182362320-0x0000000182362380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182361F80-0x0000000182362070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182362550-0x00000001823625A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182361C30-0x0000000182361D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001823619D0-0x0000000182361A70 0x0000000182361590-0x0000000182361630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000182361A70-0x0000000182361B10 0x0000000182361EE0-0x0000000182361F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ShowNameCardIdList { get => default; } // 0x00000001823624F0-0x0000000182362550 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25682
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25683
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4052
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetFriendShowNameCardInfoRsp() {} // 0x00000001823629E0-0x0000000182362A70
	static GetFriendShowNameCardInfoRsp() {} // 0x0000000182362900-0x00000001823629E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetFriendShowNameCardInfoRsp Clone() => default; // 0x0000000182362070-0x0000000182362160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetFriendShowNameCardInfoRsp ShallowCopy() => default; // 0x0000000182361B90-0x0000000182361C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182361470-0x00000001823614C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182362280-0x00000001823622D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823622D0-0x0000000182362320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823614C0-0x0000000182361590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182361770-0x0000000182361840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetFriendShowNameCardInfoRsp other) => default; // 0x0000000182361630-0x0000000182361770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182361D20-0x0000000182361E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182362690-0x0000000182362900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182362380-0x00000001823624F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182361840-0x00000001823619D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetFriendShowNameCardInfoRsp other) {} // 0x0000000182361310-0x0000000182361470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182361130-0x00000001823612B0
}

