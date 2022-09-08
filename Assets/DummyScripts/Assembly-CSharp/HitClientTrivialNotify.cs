/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HitClientTrivialNotify : MessageBase, IMessage<HitClientTrivialNotify> // TypeDefIndex: 25121
{
	// Fields
	private static readonly MessageParser<HitClientTrivialNotify> _parser; // 0x00
	public const int PositionFieldNumber = 1; // Metadata: 0x00B08093
	private Vector position_; // 0x18
	public const int OwnerEntityIdFieldNumber = 2; // Metadata: 0x00B08097
	private uint ownerEntityId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HitClientTrivialNotify> Parser { get => default; } // 0x0000000183332640-0x00000001833326D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183332290-0x0000000183332320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183331E60-0x0000000183331EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183331680-0x00000001833316E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183332A30-0x0000000183332B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183332860-0x00000001833328C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833323C0-0x00000001833324B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833329E0-0x0000000183332A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183332020-0x0000000183332110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Position { get => default; set {} } // 0x0000000183331F80-0x0000000183332020 0x00000001833325A0-0x0000000183332640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OwnerEntityId { get => default; set {} } // 0x00000001833316E0-0x0000000183331780 0x0000000183332320-0x00000001833323C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25122
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25123
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 274
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitClientTrivialNotify() {} // 0x0000000183332DC0-0x0000000183332E20
	static HitClientTrivialNotify() {} // 0x0000000183332D00-0x0000000183332DC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitClientTrivialNotify Clone() => default; // 0x00000001833324B0-0x00000001833325A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HitClientTrivialNotify ShallowCopy() => default; // 0x0000000183331EE0-0x0000000183331F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183331910-0x0000000183331990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183332760-0x00000001833327E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833327E0-0x0000000183332860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183331990-0x0000000183331AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183331AC0-0x0000000183331B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HitClientTrivialNotify other) => default; // 0x0000000183331B90-0x0000000183331CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183332110-0x0000000183332290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183332B20-0x0000000183332D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833328C0-0x00000001833329E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183331CC0-0x0000000183331E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HitClientTrivialNotify other) {} // 0x0000000183331780-0x0000000183331910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183331550-0x0000000183331680
}

