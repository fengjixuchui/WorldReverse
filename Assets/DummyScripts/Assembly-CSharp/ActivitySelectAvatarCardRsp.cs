/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivitySelectAvatarCardRsp : MessageBase, IMessage<ActivitySelectAvatarCardRsp> // TypeDefIndex: 21886
{
	// Fields
	private static readonly MessageParser<ActivitySelectAvatarCardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00443
	private int retcode_; // 0x18
	public const int ActivityIdFieldNumber = 2; // Metadata: 0x00B00447
	private uint activityId_; // 0x1C
	public const int RewardIdFieldNumber = 3; // Metadata: 0x00B0044B
	private uint rewardId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivitySelectAvatarCardRsp> Parser { get => default; } // 0x0000000184BDDAC0-0x0000000184BDDB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184BDD7B0-0x0000000184BDD840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184BDD470-0x0000000184BDD4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184BDCC70-0x0000000184BDCCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184BDDFD0-0x0000000184BDE0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184BDDDC0-0x0000000184BDDE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184BDD840-0x0000000184BDD930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184BDDF80-0x0000000184BDDFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184BDD590-0x0000000184BDD680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184BDD3D0-0x0000000184BDD470 0x0000000184BDCFA0-0x0000000184BDD040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x0000000184BDDD20-0x0000000184BDDDC0 0x0000000184BDCCD0-0x0000000184BDCD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x0000000184BDDC80-0x0000000184BDDD20 0x0000000184BDDA20-0x0000000184BDDAC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21887
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21888
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2012
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivitySelectAvatarCardRsp() {} // 0x0000000184BDE410-0x0000000184BDE470
	static ActivitySelectAvatarCardRsp() {} // 0x0000000184BDE350-0x0000000184BDE410

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivitySelectAvatarCardRsp Clone() => default; // 0x0000000184BDD930-0x0000000184BDDA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivitySelectAvatarCardRsp ShallowCopy() => default; // 0x0000000184BDD4F0-0x0000000184BDD590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184BDCED0-0x0000000184BDCF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BDDBE0-0x0000000184BDDC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BDDC30-0x0000000184BDDC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184BDCF20-0x0000000184BDCFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184BDD040-0x0000000184BDD110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivitySelectAvatarCardRsp other) => default; // 0x0000000184BDD110-0x0000000184BDD250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184BDD680-0x0000000184BDD7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184BDE0C0-0x0000000184BDE350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184BDDE20-0x0000000184BDDF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184BDD250-0x0000000184BDD3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivitySelectAvatarCardRsp other) {} // 0x0000000184BDCD70-0x0000000184BDCED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184BDCB60-0x0000000184BDCC70
}

