/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetBonusActivityRewardReq : MessageBase, IMessage<GetBonusActivityRewardReq> // TypeDefIndex: 25471
{
	// Fields
	private static readonly MessageParser<GetBonusActivityRewardReq> _parser; // 0x00
	public const int BonusActivityIdFieldNumber = 1; // Metadata: 0x00B08D53
	private uint bonusActivityId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetBonusActivityRewardReq> Parser { get => default; } // 0x0000000184164F10-0x0000000184164FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184164CA0-0x0000000184164D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184164910-0x0000000184164990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184164380-0x00000001841643E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184165260-0x0000000184165350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841650D0-0x0000000184165130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184164D30-0x0000000184164E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184165210-0x0000000184165260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184164A30-0x0000000184164B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BonusActivityId { get => default; set {} } // 0x0000000184164540-0x00000001841645E0 0x0000000184164C00-0x0000000184164CA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25472
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25473
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2515
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBonusActivityRewardReq() {} // 0x0000000184165580-0x00000001841655E0
	static GetBonusActivityRewardReq() {} // 0x00000001841654C0-0x0000000184165580

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBonusActivityRewardReq Clone() => default; // 0x0000000184164E20-0x0000000184164F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetBonusActivityRewardReq ShallowCopy() => default; // 0x0000000184164990-0x0000000184164A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841644F0-0x0000000184164540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184165030-0x0000000184165080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184165080-0x00000001841650D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841645E0-0x0000000184164650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184164650-0x0000000184164720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetBonusActivityRewardReq other) => default; // 0x0000000184164720-0x0000000184164820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184164B20-0x0000000184164C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184165350-0x00000001841654C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184165130-0x0000000184165210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184164820-0x0000000184164910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetBonusActivityRewardReq other) {} // 0x00000001841643E0-0x00000001841644F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841642A0-0x0000000184164380
}

