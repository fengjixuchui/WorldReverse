/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RegionSearchNotify : MessageBase, IMessage<RegionSearchNotify> // TypeDefIndex: 24727
{
	// Fields
	private static readonly MessageParser<RegionSearchNotify> _parser; // 0x00
	public const int RegionSearchListFieldNumber = 1; // Metadata: 0x00B0717F
	private static readonly FieldCodec<RegionSearchInfo> _repeated_regionSearchList_codec; // 0x08
	private readonly RepeatedMessageField<RegionSearchInfo> regionSearchList_; // 0x18
	public const int UidFieldNumber = 2; // Metadata: 0x00B07183
	private uint uid_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RegionSearchNotify> Parser { get => default; } // 0x00000001850732A0-0x0000000185073330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185072F30-0x0000000185072FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185072C20-0x0000000185072CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185072550-0x00000001850725B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001850736D0-0x00000001850737C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001850734E0-0x0000000185073540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001850730C0-0x00000001850731B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185073680-0x00000001850736D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185072D40-0x0000000185072E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<RegionSearchInfo> RegionSearchList { get => default; } // 0x0000000185073060-0x00000001850730C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000185072B80-0x0000000185072C20 0x0000000185072FC0-0x0000000185073060

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24728
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24729
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5601
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchNotify() {} // 0x0000000185073AB0-0x0000000185073B40
	static RegionSearchNotify() {} // 0x00000001850739A0-0x0000000185073AB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchNotify Clone() => default; // 0x00000001850731B0-0x00000001850732A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchNotify ShallowCopy() => default; // 0x0000000185072CA0-0x0000000185072D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185072720-0x0000000185072770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850733C0-0x0000000185073450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185073450-0x00000001850734E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185072770-0x0000000185072850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185072850-0x0000000185072920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RegionSearchNotify other) => default; // 0x0000000185072920-0x0000000185072A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185072E30-0x0000000185072F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001850737C0-0x00000001850739A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185073540-0x0000000185073680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185072A40-0x0000000185072B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RegionSearchNotify other) {} // 0x00000001850725B0-0x0000000185072720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001850723F0-0x0000000185072550
}

