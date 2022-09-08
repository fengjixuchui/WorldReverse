/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TrialAvatarInDungeonIndexNotify : MessageBase, IMessage<TrialAvatarInDungeonIndexNotify> // TypeDefIndex: 21983
{
	// Fields
	private static readonly MessageParser<TrialAvatarInDungeonIndexNotify> _parser; // 0x00
	public const int TrialAvatarIndexIdFieldNumber = 1; // Metadata: 0x00B007FF
	private uint trialAvatarIndexId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TrialAvatarInDungeonIndexNotify> Parser { get => default; } // 0x0000000181DA14E0-0x0000000181DA1570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181DA11D0-0x0000000181DA1260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181DA0EE0-0x0000000181DA0F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181DA09F0-0x0000000181DA0A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181DA18D0-0x0000000181DA19C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181DA1740-0x0000000181DA17A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181DA1300-0x0000000181DA13F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181DA1880-0x0000000181DA18D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181DA1000-0x0000000181DA10F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialAvatarIndexId { get => default; set {} } // 0x0000000181DA1260-0x0000000181DA1300 0x0000000181DA16A0-0x0000000181DA1740

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21984
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21985
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2048
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarInDungeonIndexNotify() {} // 0x0000000181DA1BF0-0x0000000181DA1C50
	static TrialAvatarInDungeonIndexNotify() {} // 0x0000000181DA1B30-0x0000000181DA1BF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarInDungeonIndexNotify Clone() => default; // 0x0000000181DA13F0-0x0000000181DA14E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarInDungeonIndexNotify ShallowCopy() => default; // 0x0000000181DA0F60-0x0000000181DA1000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181DA0B60-0x0000000181DA0BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DA1600-0x0000000181DA1650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181DA1650-0x0000000181DA16A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181DA0BB0-0x0000000181DA0C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181DA0C20-0x0000000181DA0CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TrialAvatarInDungeonIndexNotify other) => default; // 0x0000000181DA0CF0-0x0000000181DA0DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181DA10F0-0x0000000181DA11D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181DA19C0-0x0000000181DA1B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181DA17A0-0x0000000181DA1880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181DA0DF0-0x0000000181DA0EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TrialAvatarInDungeonIndexNotify other) {} // 0x0000000181DA0A50-0x0000000181DA0B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181DA0910-0x0000000181DA09F0
}

