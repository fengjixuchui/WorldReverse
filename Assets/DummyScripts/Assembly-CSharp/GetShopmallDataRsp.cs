/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetShopmallDataRsp : MessageBase, IMessage<GetShopmallDataRsp> // TypeDefIndex: 25434
{
	// Fields
	private static readonly MessageParser<GetShopmallDataRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08C0F
	private int retcode_; // 0x18
	public const int ShopTypeListFieldNumber = 2; // Metadata: 0x00B08C13
	private static readonly FieldCodec<uint> _repeated_shopTypeList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> shopTypeList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetShopmallDataRsp> Parser { get => default; } // 0x0000000183CEB7F0-0x0000000183CEB880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183CEB520-0x0000000183CEB5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183CEB210-0x0000000183CEB290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183CEAAF0-0x0000000183CEAB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183CEBBA0-0x0000000183CEBC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183CEB9B0-0x0000000183CEBA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183CEB610-0x0000000183CEB700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183CEBB50-0x0000000183CEBBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183CEB330-0x0000000183CEB420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183CEB170-0x0000000183CEB210 0x0000000183CEAD90-0x0000000183CEAE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ShopTypeList { get => default; } // 0x0000000183CEB5B0-0x0000000183CEB610 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25435
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25436
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 706
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetShopmallDataRsp() {} // 0x0000000183CEBF50-0x0000000183CEBFE0
	static GetShopmallDataRsp() {} // 0x0000000183CEBE70-0x0000000183CEBF50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetShopmallDataRsp Clone() => default; // 0x0000000183CEB700-0x0000000183CEB7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetShopmallDataRsp ShallowCopy() => default; // 0x0000000183CEB290-0x0000000183CEB330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183CEAC80-0x0000000183CEACD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CEB910-0x0000000183CEB960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CEB960-0x0000000183CEB9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183CEACD0-0x0000000183CEAD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183CEAF60-0x0000000183CEB030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetShopmallDataRsp other) => default; // 0x0000000183CEAE30-0x0000000183CEAF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183CEB420-0x0000000183CEB520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183CEBC90-0x0000000183CEBE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183CEBA10-0x0000000183CEBB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183CEB030-0x0000000183CEB170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetShopmallDataRsp other) {} // 0x0000000183CEAB50-0x0000000183CEAC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183CEA980-0x0000000183CEAAF0
}

