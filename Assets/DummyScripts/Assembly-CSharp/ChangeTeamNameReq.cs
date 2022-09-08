/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChangeTeamNameReq : MessageBase, IMessage<ChangeTeamNameReq> // TypeDefIndex: 22486
{
	// Fields
	private static readonly MessageParser<ChangeTeamNameReq> _parser; // 0x00
	public const int TeamIdFieldNumber = 1; // Metadata: 0x00B01ADB
	private int teamId_; // 0x18
	public const int TeamNameFieldNumber = 2; // Metadata: 0x00B01ADF
	private string teamName_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChangeTeamNameReq> Parser { get => default; } // 0x00000001819E9BB0-0x00000001819E9C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001819E98A0-0x00000001819E9930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001819E94C0-0x00000001819E9540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001819E8ED0-0x00000001819E8F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001819EA0B0-0x00000001819EA1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001819E9EC0-0x00000001819E9F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001819E99D0-0x00000001819E9AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001819EA060-0x00000001819EA0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001819E95E0-0x00000001819E96D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int TeamId { get => default; set {} } // 0x00000001819E9800-0x00000001819E98A0 0x00000001819E9E20-0x00000001819E9EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TeamName { get => default; set {} } // 0x00000001819E9930-0x00000001819E99D0 0x00000001819E9D70-0x00000001819E9E20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22487
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22488
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1736
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeTeamNameReq() {} // 0x00000001819EA440-0x00000001819EA4B0
	static ChangeTeamNameReq() {} // 0x00000001819EA380-0x00000001819EA440

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeTeamNameReq Clone() => default; // 0x00000001819E9AC0-0x00000001819E9BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeTeamNameReq ShallowCopy() => default; // 0x00000001819E9540-0x00000001819E95E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001819E9080-0x00000001819E90D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819E9CD0-0x00000001819E9D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819E9D20-0x00000001819E9D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001819E90D0-0x00000001819E9150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001819E9150-0x00000001819E9220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChangeTeamNameReq other) => default; // 0x00000001819E9220-0x00000001819E9370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001819E96D0-0x00000001819E9800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001819EA1A0-0x00000001819EA380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001819E9F20-0x00000001819EA060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001819E9370-0x00000001819E94C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChangeTeamNameReq other) {} // 0x00000001819E8F30-0x00000001819E9080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001819E8DD0-0x00000001819E8ED0
}

