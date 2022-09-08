/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ForgeDataNotify : MessageBase, IMessage<ForgeDataNotify> // TypeDefIndex: 23770
{
	// Fields
	private static readonly MessageParser<ForgeDataNotify> _parser; // 0x00
	public const int ForgeIdListFieldNumber = 1; // Metadata: 0x00B04CA3
	private static readonly FieldCodec<uint> _repeated_forgeIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> forgeIdList_; // 0x18
	public const int MaxQueueNumFieldNumber = 2; // Metadata: 0x00B04CA7
	private uint maxQueueNum_; // 0x20
	public const int ForgeQueueMapFieldNumber = 3; // Metadata: 0x00B04CAB
	private static readonly MapField<uint, ForgeQueueData> _map_forgeQueueMap_codec; // 0x10
	private readonly MapField<uint, ForgeQueueData> forgeQueueMap_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ForgeDataNotify> Parser { get => default; } // 0x00000001832AAB50-0x00000001832AABE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001832AA8E0-0x00000001832AA970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832AA570-0x00000001832AA5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832A9CD0-0x00000001832A9D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001832AAFC0-0x00000001832AB0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001832AAD10-0x00000001832AAD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832AA970-0x00000001832AAA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001832AAF70-0x00000001832AAFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832AA690-0x00000001832AA780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ForgeIdList { get => default; } // 0x00000001832AAF10-0x00000001832AAF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxQueueNum { get => default; set {} } // 0x00000001832AA0F0-0x00000001832AA190 0x00000001832A9D30-0x00000001832A9DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, ForgeQueueData> ForgeQueueMap { get => default; } // 0x00000001832A9DD0-0x00000001832A9E30 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23771
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23772
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 663
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeDataNotify() {} // 0x00000001832AB490-0x00000001832AB540
	static ForgeDataNotify() {} // 0x00000001832AB310-0x00000001832AB490

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeDataNotify Clone() => default; // 0x00000001832AAA60-0x00000001832AAB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForgeDataNotify ShallowCopy() => default; // 0x00000001832AA5F0-0x00000001832AA690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832A9F80-0x00000001832A9FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832AAC70-0x00000001832AACC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832AACC0-0x00000001832AAD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001832A9FD0-0x00000001832AA0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001832AA190-0x00000001832AA260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ForgeDataNotify other) => default; // 0x00000001832AA260-0x00000001832AA3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832AA780-0x00000001832AA8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832AB0B0-0x00000001832AB310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832AAD70-0x00000001832AAF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832AA3D0-0x00000001832AA570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ForgeDataNotify other) {} // 0x00000001832A9E30-0x00000001832A9F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001832A9AF0-0x00000001832A9CD0
}

