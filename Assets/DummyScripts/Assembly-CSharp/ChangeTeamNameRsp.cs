/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChangeTeamNameRsp : MessageBase, IMessage<ChangeTeamNameRsp> // TypeDefIndex: 22489
{
	// Fields
	private static readonly MessageParser<ChangeTeamNameRsp> _parser; // 0x00
	public const int TeamIdFieldNumber = 1; // Metadata: 0x00B01AF7
	private int teamId_; // 0x18
	public const int TeamNameFieldNumber = 2; // Metadata: 0x00B01AFB
	private string teamName_; // 0x20
	public const int RetcodeFieldNumber = 3; // Metadata: 0x00B01AFF
	private int retcode_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChangeTeamNameRsp> Parser { get => default; } // 0x00000001848DBD10-0x00000001848DBDA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001848DBA00-0x00000001848DBA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001848DB5F0-0x00000001848DB670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001848DAE10-0x00000001848DAE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001848DC250-0x00000001848DC340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001848DC020-0x00000001848DC080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001848DBB30-0x00000001848DBC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001848DC200-0x00000001848DC250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001848DB710-0x00000001848DB800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int TeamId { get => default; set {} } // 0x00000001848DB960-0x00000001848DBA00 0x00000001848DBF80-0x00000001848DC020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TeamName { get => default; set {} } // 0x00000001848DBA90-0x00000001848DBB30 0x00000001848DBED0-0x00000001848DBF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001848DB550-0x00000001848DB5F0 0x00000001848DB0D0-0x00000001848DB170

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22490
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22491
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1737
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeTeamNameRsp() {} // 0x00000001848DC670-0x00000001848DC6E0
	static ChangeTeamNameRsp() {} // 0x00000001848DC5B0-0x00000001848DC670

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeTeamNameRsp Clone() => default; // 0x00000001848DBC20-0x00000001848DBD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeTeamNameRsp ShallowCopy() => default; // 0x00000001848DB670-0x00000001848DB710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001848DAFF0-0x00000001848DB040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848DBE30-0x00000001848DBE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848DBE80-0x00000001848DBED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001848DB040-0x00000001848DB0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001848DB2E0-0x00000001848DB3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChangeTeamNameRsp other) => default; // 0x00000001848DB170-0x00000001848DB2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001848DB800-0x00000001848DB960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001848DC340-0x00000001848DC5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001848DC080-0x00000001848DC200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001848DB3B0-0x00000001848DB550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChangeTeamNameRsp other) {} // 0x00000001848DAE70-0x00000001848DAFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001848DAD00-0x00000001848DAE10
}

