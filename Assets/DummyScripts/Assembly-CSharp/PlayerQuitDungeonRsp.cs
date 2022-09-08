/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerQuitDungeonRsp : MessageBase, IMessage<PlayerQuitDungeonRsp> // TypeDefIndex: 22819
{
	// Fields
	private static readonly MessageParser<PlayerQuitDungeonRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02733
	private int retcode_; // 0x18
	public const int PointIdFieldNumber = 2; // Metadata: 0x00B02737
	private uint pointId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerQuitDungeonRsp> Parser { get => default; } // 0x00000001823D1DA0-0x00000001823D1E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823D1A90-0x00000001823D1B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823D1780-0x00000001823D1800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823D1030-0x00000001823D1090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823D2130-0x00000001823D2220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823D1F60-0x00000001823D1FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823D1BC0-0x00000001823D1CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823D20E0-0x00000001823D2130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823D18A0-0x00000001823D1990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001823D16E0-0x00000001823D1780 0x00000001823D1280-0x00000001823D1320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x00000001823D1B20-0x00000001823D1BC0 0x00000001823D1320-0x00000001823D13C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22820
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22821
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 906
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitDungeonRsp() {} // 0x00000001823D24E0-0x00000001823D2540
	static PlayerQuitDungeonRsp() {} // 0x00000001823D2420-0x00000001823D24E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitDungeonRsp Clone() => default; // 0x00000001823D1CB0-0x00000001823D1DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerQuitDungeonRsp ShallowCopy() => default; // 0x00000001823D1800-0x00000001823D18A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823D11C0-0x00000001823D1210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823D1EC0-0x00000001823D1F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823D1F10-0x00000001823D1F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823D1210-0x00000001823D1280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823D14E0-0x00000001823D15B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerQuitDungeonRsp other) => default; // 0x00000001823D13C0-0x00000001823D14E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823D1990-0x00000001823D1A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823D2220-0x00000001823D2420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823D1FC0-0x00000001823D20E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823D15B0-0x00000001823D16E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerQuitDungeonRsp other) {} // 0x00000001823D1090-0x00000001823D11C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823D0F30-0x00000001823D1030
}

