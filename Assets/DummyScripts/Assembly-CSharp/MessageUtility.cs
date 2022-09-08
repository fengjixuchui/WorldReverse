/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MessageUtility // TypeDefIndex: 26350
{
	// Fields
	private static HashSet<System.Type> ignorePoolByCmdID; // 0x00

	// Constructors
	static MessageUtility() {} // 0x0000000181515BE0-0x0000000181517700

	// Methods
	// [XID] // 0x00000001899C0CA0-0x00000001899C0CC0
	public static bool IsReadOnly(MessageBase message) => default; // 0x0000000181515450-0x00000001815157C0
	public static void RecycleRepeatMessage<T>(RepeatedMessageField<T> messageList, MessageBase parentMessage)
		where T : MessageBase, IMessage<T> {}
	public static void CopyFromRepeatedMessage<T>(RepeatedMessageField<T> messageList, RepeatedMessageField<T> other, MessageBase parentMessage)
		where T : MessageBase, IMessage<T> {}
	// [XID] // 0x00000001896E92E0-0x00000001896E9300
	public static void WriteMessageInPoolError(MessageBase message) {} // 0x00000001815158A0-0x0000000181515BE0
	// [XID] // 0x00000001899CFD60-0x00000001899CFD80
	public static void MessageDestructor(MessageBase message) {} // 0x00000001815157C0-0x00000001815158A0
	public static T Allocate<T>()
		where T : MessageBase, new() => default;
	// [XID] // 0x00000001899D7170-0x00000001899D7190
	public static void Deallocate(MessageBase message) {} // 0x0000000181515350-0x0000000181515450
}

