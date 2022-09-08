/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MechanicusCandidateTeamCreateReq : MessageBase, IMessage<MechanicusCandidateTeamCreateReq> // TypeDefIndex: 23913
{
	// Fields
	private static readonly MessageParser<MechanicusCandidateTeamCreateReq> _parser; // 0x00
	public const int DifficultLevelFieldNumber = 1; // Metadata: 0x00B051E3
	private uint difficultLevel_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MechanicusCandidateTeamCreateReq> Parser { get => default; } // 0x0000000184764060-0x00000001847640F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184763D50-0x0000000184763DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184763A60-0x0000000184763AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001847634D0-0x0000000184763530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001847643B0-0x00000001847644A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184764220-0x0000000184764280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184763E80-0x0000000184763F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184764360-0x00000001847643B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184763B80-0x0000000184763C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultLevel { get => default; set {} } // 0x0000000184763DE0-0x0000000184763E80 0x00000001847639C0-0x0000000184763A60

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23914
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23915
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3915
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusCandidateTeamCreateReq() {} // 0x00000001847646D0-0x0000000184764730
	static MechanicusCandidateTeamCreateReq() {} // 0x0000000184764610-0x00000001847646D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusCandidateTeamCreateReq Clone() => default; // 0x0000000184763F70-0x0000000184764060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MechanicusCandidateTeamCreateReq ShallowCopy() => default; // 0x0000000184763AE0-0x0000000184763B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184763640-0x0000000184763690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184764180-0x00000001847641D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001847641D0-0x0000000184764220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184763690-0x0000000184763700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184763800-0x00000001847638D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MechanicusCandidateTeamCreateReq other) => default; // 0x0000000184763700-0x0000000184763800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184763C70-0x0000000184763D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001847644A0-0x0000000184764610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184764280-0x0000000184764360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001847638D0-0x00000001847639C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MechanicusCandidateTeamCreateReq other) {} // 0x0000000184763530-0x0000000184763640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001847633F0-0x00000001847634D0
}

