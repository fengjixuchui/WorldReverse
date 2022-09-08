/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UpdatePlayerShowNameCardListReq : MessageBase, IMessage<UpdatePlayerShowNameCardListReq> // TypeDefIndex: 25672
{
	// Fields
	private static readonly MessageParser<UpdatePlayerShowNameCardListReq> _parser; // 0x00
	public const int ShowNameCardIdListFieldNumber = 1; // Metadata: 0x00B094D3
	private static readonly FieldCodec<uint> _repeated_showNameCardIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> showNameCardIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UpdatePlayerShowNameCardListReq> Parser { get => default; } // 0x00000001828573B0-0x0000000182857440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182857140-0x00000001828571D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182856E70-0x0000000182856EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182856930-0x0000000182856990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182857780-0x0000000182857870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182857570-0x00000001828575D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001828571D0-0x00000001828572C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182857730-0x0000000182857780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182856F90-0x0000000182857080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ShowNameCardIdList { get => default; } // 0x00000001828576D0-0x0000000182857730 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25673
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25674
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4049
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowNameCardListReq() {} // 0x0000000182857AA0-0x0000000182857B30
	static UpdatePlayerShowNameCardListReq() {} // 0x00000001828579C0-0x0000000182857AA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowNameCardListReq Clone() => default; // 0x00000001828572C0-0x00000001828573B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowNameCardListReq ShallowCopy() => default; // 0x0000000182856EF0-0x0000000182856F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182856AA0-0x0000000182856AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828574D0-0x0000000182857520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182857520-0x0000000182857570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182856AF0-0x0000000182856BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182856CB0-0x0000000182856D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UpdatePlayerShowNameCardListReq other) => default; // 0x0000000182856BB0-0x0000000182856CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182857080-0x0000000182857140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182857870-0x00000001828579C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001828575D0-0x00000001828576D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182856D80-0x0000000182856E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UpdatePlayerShowNameCardListReq other) {} // 0x0000000182856990-0x0000000182856AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001828567F0-0x0000000182856930
}

