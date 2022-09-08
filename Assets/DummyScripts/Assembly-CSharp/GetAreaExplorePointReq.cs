/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetAreaExplorePointReq : MessageBase, IMessage<GetAreaExplorePointReq> // TypeDefIndex: 25005
{
	// Fields
	private static readonly MessageParser<GetAreaExplorePointReq> _parser; // 0x00
	public const int AreaIdListFieldNumber = 1; // Metadata: 0x00B07C17
	private static readonly FieldCodec<uint> _repeated_areaIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> areaIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetAreaExplorePointReq> Parser { get => default; } // 0x00000001827A2130-0x00000001827A21C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001827A1EC0-0x00000001827A1F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001827A1BF0-0x00000001827A1C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001827A16B0-0x00000001827A1710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001827A2500-0x00000001827A25F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001827A22F0-0x00000001827A2350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001827A1F50-0x00000001827A2040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001827A24B0-0x00000001827A2500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001827A1D10-0x00000001827A1E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AreaIdList { get => default; } // 0x00000001827A2450-0x00000001827A24B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25006
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25007
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 238
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAreaExplorePointReq() {} // 0x00000001827A2820-0x00000001827A28B0
	static GetAreaExplorePointReq() {} // 0x00000001827A2740-0x00000001827A2820

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAreaExplorePointReq Clone() => default; // 0x00000001827A2040-0x00000001827A2130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAreaExplorePointReq ShallowCopy() => default; // 0x00000001827A1C70-0x00000001827A1D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001827A1820-0x00000001827A1870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827A2250-0x00000001827A22A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827A22A0-0x00000001827A22F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001827A1870-0x00000001827A1930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001827A1A30-0x00000001827A1B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetAreaExplorePointReq other) => default; // 0x00000001827A1930-0x00000001827A1A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001827A1E00-0x00000001827A1EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001827A25F0-0x00000001827A2740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001827A2350-0x00000001827A2450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001827A1B00-0x00000001827A1BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetAreaExplorePointReq other) {} // 0x00000001827A1710-0x00000001827A1820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001827A1570-0x00000001827A16B0
}

