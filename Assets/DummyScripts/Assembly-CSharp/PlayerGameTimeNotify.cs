/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerGameTimeNotify : MessageBase, IMessage<PlayerGameTimeNotify> // TypeDefIndex: 24330
{
	// Fields
	private static readonly MessageParser<PlayerGameTimeNotify> _parser; // 0x00
	public const int GameTimeFieldNumber = 1; // Metadata: 0x00B0636B
	private uint gameTime_; // 0x18
	public const int UidFieldNumber = 2; // Metadata: 0x00B0636F
	private uint uid_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerGameTimeNotify> Parser { get => default; } // 0x000000018311CBE0-0x000000018311CC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018311C8D0-0x000000018311C960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018311C5C0-0x000000018311C640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018311BE70-0x000000018311BED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018311CF70-0x000000018311D060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018311CDA0-0x000000018311CE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018311CA00-0x000000018311CAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018311CF20-0x000000018311CF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018311C6E0-0x000000018311C7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GameTime { get => default; set {} } // 0x000000018311C3E0-0x000000018311C480 0x000000018311C480-0x000000018311C520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x000000018311C520-0x000000018311C5C0 0x000000018311C960-0x000000018311CA00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24331
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24332
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 111
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGameTimeNotify() {} // 0x000000018311D320-0x000000018311D380
	static PlayerGameTimeNotify() {} // 0x000000018311D260-0x000000018311D320

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGameTimeNotify Clone() => default; // 0x000000018311CAF0-0x000000018311CBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerGameTimeNotify ShallowCopy() => default; // 0x000000018311C640-0x000000018311C6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018311C000-0x000000018311C050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018311CD00-0x000000018311CD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018311CD50-0x000000018311CDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018311C050-0x000000018311C0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018311C0C0-0x000000018311C190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerGameTimeNotify other) => default; // 0x000000018311C190-0x000000018311C2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018311C7D0-0x000000018311C8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018311D060-0x000000018311D260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018311CE00-0x000000018311CF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018311C2B0-0x000000018311C3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerGameTimeNotify other) {} // 0x000000018311BED0-0x000000018311C000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018311BD70-0x000000018311BE70
}

