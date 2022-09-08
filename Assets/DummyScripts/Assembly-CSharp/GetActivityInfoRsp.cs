/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetActivityInfoRsp : MessageBase, IMessage<GetActivityInfoRsp> // TypeDefIndex: 21861
{
	// Fields
	private static readonly MessageParser<GetActivityInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0035B
	private int retcode_; // 0x18
	public const int ActivityInfoListFieldNumber = 2; // Metadata: 0x00B0035F
	private static readonly FieldCodec<ActivityInfo> _repeated_activityInfoList_codec; // 0x08
	private readonly RepeatedMessageField<ActivityInfo> activityInfoList_; // 0x20
	public const int ActivatedSaleIdListFieldNumber = 3; // Metadata: 0x00B00363
	private static readonly FieldCodec<uint> _repeated_activatedSaleIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> activatedSaleIdList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetActivityInfoRsp> Parser { get => default; } // 0x000000018545A7E0-0x000000018545A870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018545A4B0-0x000000018545A540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018545A180-0x000000018545A200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185459920-0x0000000185459980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018545AC40-0x000000018545AD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018545AA20-0x000000018545AA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018545A600-0x000000018545A6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018545ABF0-0x000000018545AC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018545A2A0-0x000000018545A390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018545A0E0-0x000000018545A180 0x0000000185459CA0-0x0000000185459D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ActivityInfo> ActivityInfoList { get => default; } // 0x000000018545A540-0x000000018545A5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ActivatedSaleIdList { get => default; } // 0x000000018545A5A0-0x000000018545A600 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21862
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21863
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2004
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetActivityInfoRsp() {} // 0x000000018545B0C0-0x000000018545B170
	static GetActivityInfoRsp() {} // 0x000000018545AF90-0x000000018545B0C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetActivityInfoRsp Clone() => default; // 0x000000018545A6F0-0x000000018545A7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetActivityInfoRsp ShallowCopy() => default; // 0x000000018545A200-0x000000018545A2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185459B10-0x0000000185459B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018545A900-0x000000018545A990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018545A990-0x000000018545AA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185459B60-0x0000000185459CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185459D40-0x0000000185459E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetActivityInfoRsp other) => default; // 0x0000000185459E10-0x0000000185459F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018545A390-0x000000018545A4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018545AD30-0x000000018545AF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018545AA80-0x000000018545ABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185459F60-0x000000018545A0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetActivityInfoRsp other) {} // 0x0000000185459980-0x0000000185459B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185459740-0x0000000185459920
}

