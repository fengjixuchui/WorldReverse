/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MaterialDeleteReturnNotify : MessageBase, IMessage<MaterialDeleteReturnNotify> // TypeDefIndex: 23733
{
	// Fields
	private static readonly MessageParser<MaterialDeleteReturnNotify> _parser; // 0x00
	public const int DeleteMaterialMapFieldNumber = 1; // Metadata: 0x00B04B6B
	private static readonly MapField<uint, uint> _map_deleteMaterialMap_codec; // 0x08
	private readonly MapField<uint, uint> deleteMaterialMap_; // 0x18
	public const int ReturnItemMapFieldNumber = 2; // Metadata: 0x00B04B6F
	private static readonly MapField<uint, uint> _map_returnItemMap_codec; // 0x10
	private readonly MapField<uint, uint> returnItemMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MaterialDeleteReturnNotify> Parser { get => default; } // 0x000000018544C590-0x000000018544C620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018544C320-0x000000018544C3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018544BFB0-0x000000018544C030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018544B910-0x000000018544B970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018544C9F0-0x000000018544CAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018544C7B0-0x000000018544C810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018544C3B0-0x000000018544C4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018544C9A0-0x000000018544C9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018544C0D0-0x000000018544C1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> DeleteMaterialMap { get => default; } // 0x000000018544C810-0x000000018544C870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> ReturnItemMap { get => default; } // 0x000000018544C750-0x000000018544C7B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23734
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23735
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 651
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterialDeleteReturnNotify() {} // 0x000000018544CE30-0x000000018544CEE0
	static MaterialDeleteReturnNotify() {} // 0x000000018544CCA0-0x000000018544CE30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterialDeleteReturnNotify Clone() => default; // 0x000000018544C4A0-0x000000018544C590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterialDeleteReturnNotify ShallowCopy() => default; // 0x000000018544C030-0x000000018544C0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018544BAA0-0x000000018544BAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018544C6B0-0x000000018544C700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018544C700-0x000000018544C750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018544BAF0-0x000000018544BC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018544BC00-0x000000018544BCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MaterialDeleteReturnNotify other) => default; // 0x000000018544BCD0-0x000000018544BE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018544C1C0-0x000000018544C320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018544CAE0-0x000000018544CCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018544C870-0x000000018544C9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018544BE90-0x000000018544BFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MaterialDeleteReturnNotify other) {} // 0x000000018544B970-0x000000018544BAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018544B770-0x000000018544B910
}

