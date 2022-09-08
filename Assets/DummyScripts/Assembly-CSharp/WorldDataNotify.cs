/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldDataNotify : MessageBase, IMessage<WorldDataNotify> // TypeDefIndex: 25229
{
	// Fields
	private static readonly MessageParser<WorldDataNotify> _parser; // 0x00
	public const int WorldPropMapFieldNumber = 1; // Metadata: 0x00B0841F
	private static readonly MapField<uint, PropValue> _map_worldPropMap_codec; // 0x08
	private readonly MapField<uint, PropValue> worldPropMap_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldDataNotify> Parser { get => default; } // 0x00000001811F8AF0-0x00000001811F8B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001811F8880-0x00000001811F8910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001811F8580-0x00000001811F8600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001811F7FD0-0x00000001811F8030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001811F8EC0-0x00000001811F8FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001811F8CB0-0x00000001811F8D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001811F8910-0x00000001811F8A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001811F8E70-0x00000001811F8EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001811F86A0-0x00000001811F8790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, PropValue> WorldPropMap { get => default; } // 0x00000001811F8E10-0x00000001811F8E70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25230
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25231
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3013
		}

		public enum DataType // TypeDefIndex: 25232
		{
			DataNone = 0,
			WorldLevel = 1,
			IsInMpMode = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldDataNotify() {} // 0x00000001811F9260-0x00000001811F92F0
	static WorldDataNotify() {} // 0x00000001811F9100-0x00000001811F9260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldDataNotify Clone() => default; // 0x00000001811F8A00-0x00000001811F8AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldDataNotify ShallowCopy() => default; // 0x00000001811F8600-0x00000001811F86A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001811F8140-0x00000001811F8190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811F8C10-0x00000001811F8C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811F8C60-0x00000001811F8CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001811F8190-0x00000001811F8240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001811F83C0-0x00000001811F8490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldDataNotify other) => default; // 0x00000001811F8240-0x00000001811F83C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001811F8790-0x00000001811F8880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001811F8FB0-0x00000001811F9100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001811F8D10-0x00000001811F8E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001811F8490-0x00000001811F8580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldDataNotify other) {} // 0x00000001811F8030-0x00000001811F8140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001811F7EA0-0x00000001811F7FD0
}

