/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MpPlayOwnerInviteNotify : MessageBase, IMessage<MpPlayOwnerInviteNotify> // TypeDefIndex: 24078
{
	// Fields
	private static readonly MessageParser<MpPlayOwnerInviteNotify> _parser; // 0x00
	public const int MpPlayIdFieldNumber = 1; // Metadata: 0x00B0581F
	private uint mpPlayId_; // 0x18
	public const int CdFieldNumber = 2; // Metadata: 0x00B05823
	private uint cd_; // 0x1C
	public const int IsRemainRewardFieldNumber = 3; // Metadata: 0x00B05827
	private bool isRemainReward_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MpPlayOwnerInviteNotify> Parser { get => default; } // 0x000000018303DF20-0x000000018303DFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018303DC10-0x000000018303DCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018303D830-0x000000018303D8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018303CFC0-0x000000018303D020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018303E2F0-0x000000018303E3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018303E0E0-0x000000018303E140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018303DD40-0x000000018303DE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018303E2A0-0x000000018303E2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018303D950-0x000000018303DA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x000000018303DB70-0x000000018303DC10 0x000000018303D2F0-0x000000018303D390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Cd { get => default; set {} } // 0x000000018303D390-0x000000018303D430 0x000000018303D180-0x000000018303D220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRemainReward { get => default; set {} } // 0x000000018303D790-0x000000018303D830 0x000000018303DCA0-0x000000018303DD40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24079
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24080
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1819
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerInviteNotify() {} // 0x000000018303E730-0x000000018303E790
	static MpPlayOwnerInviteNotify() {} // 0x000000018303E670-0x000000018303E730

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerInviteNotify Clone() => default; // 0x000000018303DE30-0x000000018303DF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayOwnerInviteNotify ShallowCopy() => default; // 0x000000018303D8B0-0x000000018303D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018303D220-0x000000018303D270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018303E040-0x000000018303E090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018303E090-0x000000018303E0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018303D270-0x000000018303D2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018303D570-0x000000018303D640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MpPlayOwnerInviteNotify other) => default; // 0x000000018303D430-0x000000018303D570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018303DA40-0x000000018303DB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018303E3E0-0x000000018303E670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018303E140-0x000000018303E2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018303D640-0x000000018303D790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MpPlayOwnerInviteNotify other) {} // 0x000000018303D020-0x000000018303D180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018303CEB0-0x000000018303CFC0
}

