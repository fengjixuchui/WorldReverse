/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopPointUpdateNotify : MessageBase, IMessage<CoopPointUpdateNotify> // TypeDefIndex: 22723
{
	// Fields
	private static readonly MessageParser<CoopPointUpdateNotify> _parser; // 0x00
	public const int CoopPointFieldNumber = 1; // Metadata: 0x00B023AF
	private CoopPoint coopPoint_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CoopPointUpdateNotify> Parser { get => default; } // 0x0000000181E2B410-0x0000000181E2B4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E2B100-0x0000000181E2B190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E2ADA0-0x0000000181E2AE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E2A710-0x0000000181E2A770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E2B860-0x0000000181E2B950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E2B6D0-0x0000000181E2B730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E2B190-0x0000000181E2B280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E2B810-0x0000000181E2B860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E2AEC0-0x0000000181E2AFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopPoint CoopPoint { get => default; set {} } // 0x0000000181E2B630-0x0000000181E2B6D0 0x0000000181E2B370-0x0000000181E2B410

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22724
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22725
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1963
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopPointUpdateNotify() {} // 0x0000000181E2BB60-0x0000000181E2BBC0
	static CoopPointUpdateNotify() {} // 0x0000000181E2BAA0-0x0000000181E2BB60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopPointUpdateNotify Clone() => default; // 0x0000000181E2B280-0x0000000181E2B370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopPointUpdateNotify ShallowCopy() => default; // 0x0000000181E2AE20-0x0000000181E2AEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E2A8D0-0x0000000181E2A950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E2B530-0x0000000181E2B5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E2B5B0-0x0000000181E2B630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E2A950-0x0000000181E2AA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E2AB80-0x0000000181E2AC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CoopPointUpdateNotify other) => default; // 0x0000000181E2AA70-0x0000000181E2AB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E2AFB0-0x0000000181E2B100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E2B950-0x0000000181E2BAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E2B730-0x0000000181E2B810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E2AC50-0x0000000181E2ADA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CoopPointUpdateNotify other) {} // 0x0000000181E2A770-0x0000000181E2A8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E2A600-0x0000000181E2A710
}

