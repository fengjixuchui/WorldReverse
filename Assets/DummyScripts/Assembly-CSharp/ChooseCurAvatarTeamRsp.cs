/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChooseCurAvatarTeamRsp : MessageBase, IMessage<ChooseCurAvatarTeamRsp> // TypeDefIndex: 22399
{
	// Fields
	private static readonly MessageParser<ChooseCurAvatarTeamRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B017D7
	private int retcode_; // 0x18
	public const int CurTeamIdFieldNumber = 2; // Metadata: 0x00B017DB
	private uint curTeamId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChooseCurAvatarTeamRsp> Parser { get => default; } // 0x00000001819E8590-0x00000001819E8620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001819E8280-0x00000001819E8310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001819E7F70-0x00000001819E7FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001819E78C0-0x00000001819E7920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001819E89C0-0x00000001819E8AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001819E87F0-0x00000001819E8850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001819E83B0-0x00000001819E84A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001819E8970-0x00000001819E89C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001819E8090-0x00000001819E8180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001819E7ED0-0x00000001819E7F70 0x00000001819E7B10-0x00000001819E7BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurTeamId { get => default; set {} } // 0x00000001819E8750-0x00000001819E87F0 0x00000001819E8310-0x00000001819E83B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22400
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22401
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1706
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChooseCurAvatarTeamRsp() {} // 0x00000001819E8D70-0x00000001819E8DD0
	static ChooseCurAvatarTeamRsp() {} // 0x00000001819E8CB0-0x00000001819E8D70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChooseCurAvatarTeamRsp Clone() => default; // 0x00000001819E84A0-0x00000001819E8590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChooseCurAvatarTeamRsp ShallowCopy() => default; // 0x00000001819E7FF0-0x00000001819E8090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001819E7A50-0x00000001819E7AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819E86B0-0x00000001819E8700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819E8700-0x00000001819E8750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001819E7AA0-0x00000001819E7B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001819E7BB0-0x00000001819E7C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChooseCurAvatarTeamRsp other) => default; // 0x00000001819E7C80-0x00000001819E7DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001819E8180-0x00000001819E8280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001819E8AB0-0x00000001819E8CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001819E8850-0x00000001819E8970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001819E7DA0-0x00000001819E7ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChooseCurAvatarTeamRsp other) {} // 0x00000001819E7920-0x00000001819E7A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001819E77C0-0x00000001819E78C0
}

