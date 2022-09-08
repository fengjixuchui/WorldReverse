/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct AudioPositionArray : IDisposable // TypeDefIndex: 11490
{
	// Fields
	private const int FLOAT_SIZE = 4; // Metadata: 0x00AE98F7
	private const long FLOAT_SIZE_L = 4; // Metadata: 0x00AE98FB
	private IntPtr _buffer; // 0x00
	private ushort _capacity; // 0x08
	private IntPtr _current; // 0x10

	// Properties
	public ushort count { /* [XID] */ /* 0x0000000189BCCAC0-0x0000000189BCCB00 */ get; /* [XID] */ /* 0x0000000189BD6D60-0x0000000189BD6DA0 */ private set; } // 0x0000000182CF4F50-0x0000000182CF5130 0x0000000182CF49A0-0x0000000182CF4C10

	// Constructors
	public AudioPositionArray(ushort count) : this() {
		_buffer = default;
		_capacity = default;
		_current = default;
	} // 0x0000000182CF5420-0x0000000182CF5430

	// Methods
	// [XID] // 0x00000001897CE820-0x00000001897CE840
	public void Add(Vector3 position, Vector3 forward, Vector3 up) {} // 0x0000000182CF4E80-0x0000000182CF4F50
	// [XID] // 0x00000001895EE510-0x00000001895EE530
	public bool TryGet(int index, out Vector3 position, out Vector3 forward, out Vector3 up) {
		position = default;
		forward = default;
		up = default;
		return default;
	} // 0x0000000182CF4C10-0x0000000182CF4E80
	// [XID] // 0x0000000189869460-0x0000000189869480
	public bool TryGetPosition(int index, out Vector3 position) {
		position = default;
		return default;
	} // 0x0000000182CF5130-0x0000000182CF5340
	// [XID] // 0x00000001895FD1D0-0x00000001895FD1F0
	public void Reset() {} // 0x0000000182CF4830-0x0000000182CF4930
	// [XID] // 0x0000000189604B70-0x0000000189604B90
	public void Dispose() {} // 0x0000000182CF4930-0x0000000182CF49A0
	// [XID] // 0x0000000189870610-0x0000000189870630
	private Vector3 ReadVector3(int offset) => default; // 0x0000000182CF5340-0x0000000182CF5420
	// [XID] // 0x0000000189757720-0x0000000189757740
	public static implicit operator IntPtr(AudioPositionArray array) => default; // 0x0000000182CF46A0-0x0000000182CF4830
}

