/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerEnterDungeonRsp : MessageBase, IMessage<PlayerEnterDungeonRsp> // TypeDefIndex: 22813
{
	// Fields
	private static readonly MessageParser<PlayerEnterDungeonRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B026FB
	private int retcode_; // 0x18
	public const int PointIdFieldNumber = 2; // Metadata: 0x00B026FF
	private uint pointId_; // 0x1C
	public const int DungeonIdFieldNumber = 3; // Metadata: 0x00B02703
	private uint dungeonId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerEnterDungeonRsp> Parser { get => default; } // 0x0000000183C21660-0x0000000183C216F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C21350-0x0000000183C213E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C20F70-0x0000000183C20FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C20770-0x0000000183C207D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C21AD0-0x0000000183C21BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C21820-0x0000000183C21880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C21480-0x0000000183C21570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C21A80-0x0000000183C21AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C21130-0x0000000183C21220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183C20ED0-0x0000000183C20F70 0x0000000183C20A00-0x0000000183C20AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PointId { get => default; set {} } // 0x0000000183C213E0-0x0000000183C21480 0x0000000183C20AA0-0x0000000183C20B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x0000000183C21090-0x0000000183C21130 0x0000000183C219E0-0x0000000183C21A80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22814
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22815
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 904
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEnterDungeonRsp() {} // 0x0000000183C21F10-0x0000000183C21F70
	static PlayerEnterDungeonRsp() {} // 0x0000000183C21E50-0x0000000183C21F10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEnterDungeonRsp Clone() => default; // 0x0000000183C21570-0x0000000183C21660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEnterDungeonRsp ShallowCopy() => default; // 0x0000000183C20FF0-0x0000000183C21090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C20930-0x0000000183C20980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C21780-0x0000000183C217D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C217D0-0x0000000183C21820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C20980-0x0000000183C20A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C20C80-0x0000000183C20D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerEnterDungeonRsp other) => default; // 0x0000000183C20B40-0x0000000183C20C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C21220-0x0000000183C21350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C21BC0-0x0000000183C21E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C21880-0x0000000183C219E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C20D50-0x0000000183C20ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerEnterDungeonRsp other) {} // 0x0000000183C207D0-0x0000000183C20930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C20660-0x0000000183C20770
}

