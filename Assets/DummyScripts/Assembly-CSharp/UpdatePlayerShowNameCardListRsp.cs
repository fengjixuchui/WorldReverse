/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UpdatePlayerShowNameCardListRsp : MessageBase, IMessage<UpdatePlayerShowNameCardListRsp> // TypeDefIndex: 25675
{
	// Fields
	private static readonly MessageParser<UpdatePlayerShowNameCardListRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B094EB
	private int retcode_; // 0x18
	public const int ShowNameCardIdListFieldNumber = 2; // Metadata: 0x00B094EF
	private static readonly FieldCodec<uint> _repeated_showNameCardIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> showNameCardIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UpdatePlayerShowNameCardListRsp> Parser { get => default; } // 0x000000018336D890-0x000000018336D920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018336D620-0x000000018336D6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018336D310-0x000000018336D390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018336CBF0-0x000000018336CC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018336DCA0-0x000000018336DD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018336DA50-0x000000018336DAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018336D6B0-0x000000018336D7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018336DC50-0x000000018336DCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018336D430-0x000000018336D520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018336D270-0x000000018336D310 0x000000018336CE90-0x000000018336CF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ShowNameCardIdList { get => default; } // 0x000000018336DBF0-0x000000018336DC50 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25676
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25677
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4050
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowNameCardListRsp() {} // 0x000000018336E050-0x000000018336E0E0
	static UpdatePlayerShowNameCardListRsp() {} // 0x000000018336DF70-0x000000018336E050

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowNameCardListRsp Clone() => default; // 0x000000018336D7A0-0x000000018336D890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowNameCardListRsp ShallowCopy() => default; // 0x000000018336D390-0x000000018336D430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018336CD80-0x000000018336CDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018336D9B0-0x000000018336DA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018336DA00-0x000000018336DA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018336CDD0-0x000000018336CE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018336CF30-0x000000018336D000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UpdatePlayerShowNameCardListRsp other) => default; // 0x000000018336D000-0x000000018336D130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018336D520-0x000000018336D620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018336DD90-0x000000018336DF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018336DAB0-0x000000018336DBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018336D130-0x000000018336D270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UpdatePlayerShowNameCardListRsp other) {} // 0x000000018336CC50-0x000000018336CD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018336CA80-0x000000018336CBF0
}

