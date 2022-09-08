/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FoundationReq : MessageBase, IMessage<FoundationReq> // TypeDefIndex: 23223
{
	// Fields
	private static readonly MessageParser<FoundationReq> _parser; // 0x00
	public const int GadgetEntityIdFieldNumber = 1; // Metadata: 0x00B0385B
	private uint gadgetEntityId_; // 0x18
	public const int OpTypeFieldNumber = 2; // Metadata: 0x00B0385F
	private FoundationOpType opType_; // 0x1C
	public const int BuildingIdFieldNumber = 3; // Metadata: 0x00B03863
	private uint buildingId_; // 0x20
	public const int PointConfigIdFieldNumber = 4; // Metadata: 0x00B03867
	private uint pointConfigId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FoundationReq> Parser { get => default; } // 0x00000001859577C0-0x0000000185957850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185957550-0x00000001859575E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185957100-0x0000000185957180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185956870-0x00000001859568D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185957DB0-0x0000000185957EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185957A20-0x0000000185957A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001859575E0-0x00000001859576D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185957D60-0x0000000185957DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185957220-0x0000000185957310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetEntityId { get => default; set {} } // 0x0000000185957B20-0x0000000185957BC0 0x00000001859568D0-0x0000000185956970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationOpType OpType { get => default; set {} } // 0x0000000185956B90-0x0000000185956C30 0x00000001859567D0-0x0000000185956870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BuildingId { get => default; set {} } // 0x0000000185957980-0x0000000185957A20 0x0000000185957A80-0x0000000185957B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointConfigId { get => default; set {} } // 0x00000001859574B0-0x0000000185957550 0x0000000185956970-0x0000000185956A10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23224
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23225
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 816
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationReq() {} // 0x0000000185958280-0x00000001859582F0
	static FoundationReq() {} // 0x00000001859581C0-0x0000000185958280

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationReq Clone() => default; // 0x00000001859576D0-0x00000001859577C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FoundationReq ShallowCopy() => default; // 0x0000000185957180-0x0000000185957220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185956C30-0x0000000185956C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001859578E0-0x0000000185957930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185957930-0x0000000185957980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185956C80-0x0000000185956D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185956D10-0x0000000185956DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FoundationReq other) => default; // 0x0000000185956DE0-0x0000000185956F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185957310-0x00000001859574B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185957EA0-0x00000001859581C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185957BC0-0x0000000185957D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185956F30-0x0000000185957100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FoundationReq other) {} // 0x0000000185956A10-0x0000000185956B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001859566B0-0x00000001859567D0
}

