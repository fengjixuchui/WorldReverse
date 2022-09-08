/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetAllActivatedBargainDataRsp : MessageBase, IMessage<GetAllActivatedBargainDataRsp> // TypeDefIndex: 24651
{
	// Fields
	private static readonly MessageParser<GetAllActivatedBargainDataRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06EC7
	private int retcode_; // 0x18
	public const int SnapshotListFieldNumber = 2; // Metadata: 0x00B06ECB
	private static readonly FieldCodec<BargainSnapshot> _repeated_snapshotList_codec; // 0x08
	private readonly RepeatedMessageField<BargainSnapshot> snapshotList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetAllActivatedBargainDataRsp> Parser { get => default; } // 0x0000000183B93760-0x0000000183B937F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B934F0-0x0000000183B93580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B931E0-0x0000000183B93260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B92A70-0x0000000183B92AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B93B90-0x0000000183B93C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B939A0-0x0000000183B93A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B93580-0x0000000183B93670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B93B40-0x0000000183B93B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B93300-0x0000000183B933F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183B93140-0x0000000183B931E0 0x0000000183B92D60-0x0000000183B92E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BargainSnapshot> SnapshotList { get => default; } // 0x0000000183B92A10-0x0000000183B92A70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24652
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24653
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 430
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAllActivatedBargainDataRsp() {} // 0x0000000183B93F70-0x0000000183B94000
	static GetAllActivatedBargainDataRsp() {} // 0x0000000183B93E60-0x0000000183B93F70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAllActivatedBargainDataRsp Clone() => default; // 0x0000000183B93670-0x0000000183B93760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAllActivatedBargainDataRsp ShallowCopy() => default; // 0x0000000183B93260-0x0000000183B93300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B92C30-0x0000000183B92C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B93880-0x0000000183B93910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B93910-0x0000000183B939A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B92C80-0x0000000183B92D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B92F30-0x0000000183B93000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetAllActivatedBargainDataRsp other) => default; // 0x0000000183B92E00-0x0000000183B92F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B933F0-0x0000000183B934F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B93C80-0x0000000183B93E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B93A00-0x0000000183B93B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B93000-0x0000000183B93140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetAllActivatedBargainDataRsp other) {} // 0x0000000183B92AD0-0x0000000183B92C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B928B0-0x0000000183B92A10
}

