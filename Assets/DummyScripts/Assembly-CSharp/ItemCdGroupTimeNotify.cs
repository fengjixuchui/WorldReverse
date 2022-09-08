/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ItemCdGroupTimeNotify : MessageBase, IMessage<ItemCdGroupTimeNotify> // TypeDefIndex: 23690
{
	// Fields
	private static readonly MessageParser<ItemCdGroupTimeNotify> _parser; // 0x00
	public const int ItemCdMapFieldNumber = 1; // Metadata: 0x00B049C3
	private static readonly MapField<uint, ulong> _map_itemCdMap_codec; // 0x08
	private readonly MapField<uint, ulong> itemCdMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ItemCdGroupTimeNotify> Parser { get => default; } // 0x00000001820C8E60-0x00000001820C8EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001820C8B90-0x00000001820C8C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001820C8890-0x00000001820C8910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820C82E0-0x00000001820C8340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001820C91D0-0x00000001820C92C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820C9020-0x00000001820C9080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820C8C80-0x00000001820C8D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820C9180-0x00000001820C91D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001820C89B0-0x00000001820C8AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, ulong> ItemCdMap { get => default; } // 0x00000001820C8C20-0x00000001820C8C80 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23691
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23692
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 632
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemCdGroupTimeNotify() {} // 0x00000001820C9540-0x00000001820C95D0
	static ItemCdGroupTimeNotify() {} // 0x00000001820C9410-0x00000001820C9540

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemCdGroupTimeNotify Clone() => default; // 0x00000001820C8D70-0x00000001820C8E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ItemCdGroupTimeNotify ShallowCopy() => default; // 0x00000001820C8910-0x00000001820C89B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001820C8450-0x00000001820C84A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820C8F80-0x00000001820C8FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820C8FD0-0x00000001820C9020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820C84A0-0x00000001820C8550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820C8550-0x00000001820C8620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ItemCdGroupTimeNotify other) => default; // 0x00000001820C8620-0x00000001820C87A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001820C8AA0-0x00000001820C8B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820C92C0-0x00000001820C9410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820C9080-0x00000001820C9180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820C87A0-0x00000001820C8890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ItemCdGroupTimeNotify other) {} // 0x00000001820C8340-0x00000001820C8450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001820C81B0-0x00000001820C82E0
}

