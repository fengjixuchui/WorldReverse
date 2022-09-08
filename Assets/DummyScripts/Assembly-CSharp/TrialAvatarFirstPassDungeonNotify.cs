/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TrialAvatarFirstPassDungeonNotify : MessageBase, IMessage<TrialAvatarFirstPassDungeonNotify> // TypeDefIndex: 21980
{
	// Fields
	private static readonly MessageParser<TrialAvatarFirstPassDungeonNotify> _parser; // 0x00
	public const int TrialAvatarIndexIdFieldNumber = 1; // Metadata: 0x00B007EB
	private uint trialAvatarIndexId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TrialAvatarFirstPassDungeonNotify> Parser { get => default; } // 0x0000000181BF8180-0x0000000181BF8210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181BF7E70-0x0000000181BF7F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181BF7B80-0x0000000181BF7C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181BF7690-0x0000000181BF76F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181BF8570-0x0000000181BF8660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181BF83E0-0x0000000181BF8440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181BF7FA0-0x0000000181BF8090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181BF8520-0x0000000181BF8570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181BF7CA0-0x0000000181BF7D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TrialAvatarIndexId { get => default; set {} } // 0x0000000181BF7F00-0x0000000181BF7FA0 0x0000000181BF8340-0x0000000181BF83E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21981
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21982
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2047
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarFirstPassDungeonNotify() {} // 0x0000000181BF8890-0x0000000181BF88F0
	static TrialAvatarFirstPassDungeonNotify() {} // 0x0000000181BF87D0-0x0000000181BF8890

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarFirstPassDungeonNotify Clone() => default; // 0x0000000181BF8090-0x0000000181BF8180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarFirstPassDungeonNotify ShallowCopy() => default; // 0x0000000181BF7C00-0x0000000181BF7CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181BF7800-0x0000000181BF7850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BF82A0-0x0000000181BF82F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BF82F0-0x0000000181BF8340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181BF7850-0x0000000181BF78C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181BF78C0-0x0000000181BF7990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TrialAvatarFirstPassDungeonNotify other) => default; // 0x0000000181BF7990-0x0000000181BF7A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181BF7D90-0x0000000181BF7E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181BF8660-0x0000000181BF87D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181BF8440-0x0000000181BF8520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181BF7A90-0x0000000181BF7B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TrialAvatarFirstPassDungeonNotify other) {} // 0x0000000181BF76F0-0x0000000181BF7800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181BF75B0-0x0000000181BF7690
}

