/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SetOpenStateReq : MessageBase, IMessage<SetOpenStateReq> // TypeDefIndex: 24363
{
	// Fields
	private static readonly MessageParser<SetOpenStateReq> _parser; // 0x00
	public const int KeyFieldNumber = 1; // Metadata: 0x00B0646B
	private uint key_; // 0x18
	public const int ValueFieldNumber = 2; // Metadata: 0x00B0646F
	private uint value_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SetOpenStateReq> Parser { get => default; } // 0x000000018412F750-0x000000018412F7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018412F440-0x000000018412F4D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018412F130-0x000000018412F1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018412EB20-0x000000018412EB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018412FB80-0x000000018412FC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018412F9B0-0x000000018412FA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018412F570-0x000000018412F660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018412FB30-0x000000018412FB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018412F250-0x000000018412F340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Key { get => default; set {} } // 0x000000018412FC70-0x000000018412FD10 0x000000018412EB80-0x000000018412EC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Value { get => default; set {} } // 0x000000018412F4D0-0x000000018412F570 0x000000018412F8C0-0x000000018412F960

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24364
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24365
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 122
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetOpenStateReq() {} // 0x000000018412FFD0-0x0000000184130030
	static SetOpenStateReq() {} // 0x000000018412FF10-0x000000018412FFD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetOpenStateReq Clone() => default; // 0x000000018412F660-0x000000018412F750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SetOpenStateReq ShallowCopy() => default; // 0x000000018412F1B0-0x000000018412F250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018412ED50-0x000000018412EDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018412F870-0x000000018412F8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018412F960-0x000000018412F9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018412EDA0-0x000000018412EE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018412EF30-0x000000018412F000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SetOpenStateReq other) => default; // 0x000000018412EE10-0x000000018412EF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018412F340-0x000000018412F440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018412FD10-0x000000018412FF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018412FA10-0x000000018412FB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018412F000-0x000000018412F130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SetOpenStateReq other) {} // 0x000000018412EC20-0x000000018412ED50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018412EA20-0x000000018412EB20
}

