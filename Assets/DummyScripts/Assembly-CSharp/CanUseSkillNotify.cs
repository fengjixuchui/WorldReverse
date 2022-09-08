/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CanUseSkillNotify : MessageBase, IMessage<CanUseSkillNotify> // TypeDefIndex: 25522
{
	// Fields
	private static readonly MessageParser<CanUseSkillNotify> _parser; // 0x00
	public const int IsCanUseSkillFieldNumber = 1; // Metadata: 0x00B08F5B
	private bool isCanUseSkill_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CanUseSkillNotify> Parser { get => default; } // 0x0000000180DD9F50-0x0000000180DD9FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180DD9CE0-0x0000000180DD9D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180DD99F0-0x0000000180DD9A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180DD9540-0x0000000180DD95A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180DDA340-0x0000000180DDA430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180DDA1B0-0x0000000180DDA210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180DD9D70-0x0000000180DD9E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180DDA2F0-0x0000000180DDA340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180DD9B10-0x0000000180DD9C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsCanUseSkill { get => default; set {} } // 0x0000000180DDA110-0x0000000180DDA1B0 0x0000000180DD93C0-0x0000000180DD9460

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25523
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25524
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1016
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CanUseSkillNotify() {} // 0x0000000180DDA660-0x0000000180DDA6C0
	static CanUseSkillNotify() {} // 0x0000000180DDA5A0-0x0000000180DDA660

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CanUseSkillNotify Clone() => default; // 0x0000000180DD9E60-0x0000000180DD9F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CanUseSkillNotify ShallowCopy() => default; // 0x0000000180DD9A70-0x0000000180DD9B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180DD96B0-0x0000000180DD9700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DDA070-0x0000000180DDA0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180DDA0C0-0x0000000180DDA110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180DD9700-0x0000000180DD9770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180DD9870-0x0000000180DD9940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CanUseSkillNotify other) => default; // 0x0000000180DD9770-0x0000000180DD9870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180DD9C00-0x0000000180DD9CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180DDA430-0x0000000180DDA5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180DDA210-0x0000000180DDA2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180DD9940-0x0000000180DD99F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CanUseSkillNotify other) {} // 0x0000000180DD95A0-0x0000000180DD96B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180DD9460-0x0000000180DD9540
}

