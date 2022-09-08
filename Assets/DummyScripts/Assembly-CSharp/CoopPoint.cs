/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CoopPoint : MessageBase, IMessage<CoopPoint> // TypeDefIndex: 22695
{
	// Fields
	private static readonly MessageParser<CoopPoint> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B022B7
	private uint id_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B022BB
	private Types.State state_; // 0x1C
	public const int SelfConfidenceFieldNumber = 3; // Metadata: 0x00B022BF
	private uint selfConfidence_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CoopPoint> Parser { get => default; } // 0x000000018231CDC0-0x000000018231CE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018231CAB0-0x000000018231CB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018231C730-0x000000018231C7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018231BE90-0x000000018231BEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018231D230-0x000000018231D320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018231D020-0x000000018231D080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018231CBE0-0x000000018231CCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018231D1E0-0x000000018231D230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018231C850-0x000000018231C940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x000000018231C690-0x000000018231C730 0x000000018231CE50-0x000000018231CEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.State State { get => default; set {} } // 0x000000018231C550-0x000000018231C5F0 0x000000018231C5F0-0x000000018231C690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SelfConfidence { get => default; set {} } // 0x000000018231C120-0x000000018231C1C0 0x000000018231CB40-0x000000018231CBE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22696
	{
		// Nested types
		public enum State // TypeDefIndex: 22697
		{
			Unstarted = 0,
			Started = 1,
			Finished = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopPoint() {} // 0x000000018231D670-0x000000018231D6E0
	static CoopPoint() {} // 0x000000018231D5B0-0x000000018231D670

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopPoint Clone() => default; // 0x000000018231CCD0-0x000000018231CDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CoopPoint ShallowCopy() => default; // 0x000000018231C7B0-0x000000018231C850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018231C050-0x000000018231C0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018231CF80-0x000000018231CFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018231CFD0-0x000000018231D020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018231C0A0-0x000000018231C120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018231C1C0-0x000000018231C290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CoopPoint other) => default; // 0x000000018231C290-0x000000018231C3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018231C940-0x000000018231CAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018231D320-0x000000018231D5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018231D080-0x000000018231D1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018231C3D0-0x000000018231C550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CoopPoint other) {} // 0x000000018231BEF0-0x000000018231C050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018231BD80-0x000000018231BE90
}

