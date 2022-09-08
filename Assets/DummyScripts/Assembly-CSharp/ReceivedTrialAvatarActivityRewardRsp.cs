/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReceivedTrialAvatarActivityRewardRsp : MessageBase, IMessage<ReceivedTrialAvatarActivityRewardRsp> // TypeDefIndex: 21977
{
	// Fields
	private static readonly MessageParser<ReceivedTrialAvatarActivityRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B007CF
	private int retcode_; // 0x18
	public const int ActivityIdFieldNumber = 2; // Metadata: 0x00B007D3
	private uint activityId_; // 0x1C
	public const int TrialAvatarIndexIdFieldNumber = 3; // Metadata: 0x00B007D7
	private uint trialAvatarIndexId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReceivedTrialAvatarActivityRewardRsp> Parser { get => default; } // 0x0000000181ED0F60-0x0000000181ED0FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181ED0C50-0x0000000181ED0CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181ED0910-0x0000000181ED0990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181ED0110-0x0000000181ED0170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181ED1470-0x0000000181ED1560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181ED1260-0x0000000181ED12C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181ED0D80-0x0000000181ED0E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181ED1420-0x0000000181ED1470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181ED0A30-0x0000000181ED0B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181ED0870-0x0000000181ED0910 0x0000000181ED0440-0x0000000181ED04E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000181ED1120-0x0000000181ED11C0 0x0000000181ED0170-0x0000000181ED0210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialAvatarIndexId { get => default; set {} } // 0x0000000181ED0CE0-0x0000000181ED0D80 0x0000000181ED11C0-0x0000000181ED1260

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21978
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21979
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2044
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReceivedTrialAvatarActivityRewardRsp() {} // 0x0000000181ED18B0-0x0000000181ED1910
	static ReceivedTrialAvatarActivityRewardRsp() {} // 0x0000000181ED17F0-0x0000000181ED18B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReceivedTrialAvatarActivityRewardRsp Clone() => default; // 0x0000000181ED0E70-0x0000000181ED0F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReceivedTrialAvatarActivityRewardRsp ShallowCopy() => default; // 0x0000000181ED0990-0x0000000181ED0A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181ED0370-0x0000000181ED03C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181ED1080-0x0000000181ED10D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181ED10D0-0x0000000181ED1120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181ED03C0-0x0000000181ED0440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181ED04E0-0x0000000181ED05B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReceivedTrialAvatarActivityRewardRsp other) => default; // 0x0000000181ED05B0-0x0000000181ED06F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181ED0B20-0x0000000181ED0C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181ED1560-0x0000000181ED17F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181ED12C0-0x0000000181ED1420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181ED06F0-0x0000000181ED0870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReceivedTrialAvatarActivityRewardRsp other) {} // 0x0000000181ED0210-0x0000000181ED0370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181ED0000-0x0000000181ED0110
}

