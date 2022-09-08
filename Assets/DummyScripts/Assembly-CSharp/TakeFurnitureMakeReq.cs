/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeFurnitureMakeReq : MessageBase, IMessage<TakeFurnitureMakeReq> // TypeDefIndex: 23451
{
	// Fields
	private static readonly MessageParser<TakeFurnitureMakeReq> _parser; // 0x00
	public const int IndexFieldNumber = 1; // Metadata: 0x00B040E3
	private uint index_; // 0x18
	public const int MakeIdFieldNumber = 2; // Metadata: 0x00B040E7
	private uint makeId_; // 0x1C
	public const int IsFastFinishFieldNumber = 3; // Metadata: 0x00B040EB
	private bool isFastFinish_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeFurnitureMakeReq> Parser { get => default; } // 0x0000000181CF05C0-0x0000000181CF0650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181CF0350-0x0000000181CF03E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181CEFF70-0x0000000181CEFFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181CEF7A0-0x0000000181CEF800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181CF0A30-0x0000000181CF0B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181CF0780-0x0000000181CF07E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181CF03E0-0x0000000181CF04D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181CF09E0-0x0000000181CF0A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181CF0090-0x0000000181CF0180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Index { get => default; set {} } // 0x0000000181CEFED0-0x0000000181CEFF70 0x0000000181CF02B0-0x0000000181CF0350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MakeId { get => default; set {} } // 0x0000000181CEF960-0x0000000181CEFA00 0x0000000181CEF700-0x0000000181CEF7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFastFinish { get => default; set {} } // 0x0000000181CEFAD0-0x0000000181CEFB70 0x0000000181CF07E0-0x0000000181CF0880

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23452
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23453
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4603
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeFurnitureMakeReq() {} // 0x0000000181CF0E70-0x0000000181CF0ED0
	static TakeFurnitureMakeReq() {} // 0x0000000181CF0DB0-0x0000000181CF0E70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeFurnitureMakeReq Clone() => default; // 0x0000000181CF04D0-0x0000000181CF05C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeFurnitureMakeReq ShallowCopy() => default; // 0x0000000181CEFFF0-0x0000000181CF0090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181CEFA00-0x0000000181CEFA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CF06E0-0x0000000181CF0730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CF0730-0x0000000181CF0780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181CEFA50-0x0000000181CEFAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181CEFCB0-0x0000000181CEFD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeFurnitureMakeReq other) => default; // 0x0000000181CEFB70-0x0000000181CEFCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181CF0180-0x0000000181CF02B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181CF0B20-0x0000000181CF0DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181CF0880-0x0000000181CF09E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181CEFD80-0x0000000181CEFED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeFurnitureMakeReq other) {} // 0x0000000181CEF800-0x0000000181CEF960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181CEF5F0-0x0000000181CEF700
}

