/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerDataNotify : MessageBase, IMessage<PlayerDataNotify> // TypeDefIndex: 24321
{
	// Fields
	private static readonly MessageParser<PlayerDataNotify> _parser; // 0x00
	public const int NickNameFieldNumber = 1; // Metadata: 0x00B06313
	private string nickName_; // 0x18
	public const int ServerTimeFieldNumber = 2; // Metadata: 0x00B06317
	private ulong serverTime_; // 0x20
	public const int IsFirstLoginTodayFieldNumber = 3; // Metadata: 0x00B0631B
	private bool isFirstLoginToday_; // 0x28
	public const int RegionIdFieldNumber = 4; // Metadata: 0x00B0631F
	private uint regionId_; // 0x2C
	public const int PropMapFieldNumber = 6; // Metadata: 0x00B06323
	private static readonly MapField<uint, PropValue> _map_propMap_codec; // 0x08
	private readonly MapField<uint, PropValue> propMap_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerDataNotify> Parser { get => default; } // 0x0000000183A20040-0x0000000183A200D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A1FD30-0x0000000183A1FDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A1F890-0x0000000183A1F910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A1EDF0-0x0000000183A1EE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A20600-0x0000000183A206F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A202A0-0x0000000183A20300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A1FE60-0x0000000183A1FF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A205B0-0x0000000183A20600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A1F9B0-0x0000000183A1FAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string NickName { get => default; set {} } // 0x0000000183A1EFA0-0x0000000183A1F040 0x0000000183A1EEF0-0x0000000183A1EFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong ServerTime { get => default; set {} } // 0x0000000183A1F7F0-0x0000000183A1F890 0x0000000183A1FDC0-0x0000000183A1FE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFirstLoginToday { get => default; set {} } // 0x0000000183A1EE50-0x0000000183A1EEF0 0x0000000183A201B0-0x0000000183A20250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionId { get => default; set {} } // 0x0000000183A20510-0x0000000183A205B0 0x0000000183A1FC90-0x0000000183A1FD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, PropValue> PropMap { get => default; } // 0x0000000183A206F0-0x0000000183A20750 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24322
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24323
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 108
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerDataNotify() {} // 0x0000000183A20C20-0x0000000183A20CC0
	static PlayerDataNotify() {} // 0x0000000183A20AC0-0x0000000183A20C20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerDataNotify Clone() => default; // 0x0000000183A1FF50-0x0000000183A20040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerDataNotify ShallowCopy() => default; // 0x0000000183A1F910-0x0000000183A1F9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A1F200-0x0000000183A1F250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A20160-0x0000000183A201B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A20250-0x0000000183A202A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A1F250-0x0000000183A1F340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A1F510-0x0000000183A1F5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerDataNotify other) => default; // 0x0000000183A1F340-0x0000000183A1F510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A1FAA0-0x0000000183A1FC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A20750-0x0000000183A20AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A20300-0x0000000183A20510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A1F5E0-0x0000000183A1F7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerDataNotify other) {} // 0x0000000183A1F040-0x0000000183A1F200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A1EC30-0x0000000183A1EDF0
}

