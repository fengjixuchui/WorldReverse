/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DestroyMaterialRsp : MessageBase, IMessage<DestroyMaterialRsp> // TypeDefIndex: 23755
{
	// Fields
	private static readonly MessageParser<DestroyMaterialRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04C13
	private int retcode_; // 0x18
	public const int ItemIdListFieldNumber = 2; // Metadata: 0x00B04C17
	private static readonly FieldCodec<uint> _repeated_itemIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> itemIdList_; // 0x20
	public const int ItemCountListFieldNumber = 3; // Metadata: 0x00B04C1B
	private static readonly FieldCodec<uint> _repeated_itemCountList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> itemCountList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DestroyMaterialRsp> Parser { get => default; } // 0x0000000182E3BD50-0x0000000182E3BDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E3BA80-0x0000000182E3BB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E3B750-0x0000000182E3B7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E3AF40-0x0000000182E3AFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E3C190-0x0000000182E3C280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E3BF70-0x0000000182E3BFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E3BB10-0x0000000182E3BC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E3C140-0x0000000182E3C190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E3B870-0x0000000182E3B960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182E3B6B0-0x0000000182E3B750 0x0000000182E3B270-0x0000000182E3B310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ItemIdList { get => default; } // 0x0000000182E3BCF0-0x0000000182E3BD50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ItemCountList { get => default; } // 0x0000000182E3BF10-0x0000000182E3BF70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23756
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23757
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 658
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DestroyMaterialRsp() {} // 0x0000000182E3C5E0-0x0000000182E3C690
	static DestroyMaterialRsp() {} // 0x0000000182E3C4E0-0x0000000182E3C5E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DestroyMaterialRsp Clone() => default; // 0x0000000182E3BC00-0x0000000182E3BCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DestroyMaterialRsp ShallowCopy() => default; // 0x0000000182E3B7D0-0x0000000182E3B870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E3B0F0-0x0000000182E3B140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E3BE70-0x0000000182E3BEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E3BEC0-0x0000000182E3BF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E3B140-0x0000000182E3B270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E3B310-0x0000000182E3B3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DestroyMaterialRsp other) => default; // 0x0000000182E3B3E0-0x0000000182E3B530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E3B960-0x0000000182E3BA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E3C280-0x0000000182E3C4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E3BFD0-0x0000000182E3C140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E3B530-0x0000000182E3B6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DestroyMaterialRsp other) {} // 0x0000000182E3AFA0-0x0000000182E3B0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E3AD60-0x0000000182E3AF40
}

