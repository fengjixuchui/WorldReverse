/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class PeriodicMultiPositionEventSpotCollection // TypeDefIndex: 11493
{
	// Fields
	private const int SPOT_COUNT_LIMIT = 160; // Metadata: 0x00AE9903
	private static readonly SpotOffsetComparer _spotOffsetComparer; // 0x00
	private readonly Dictionary<int, PeriodicMultiPositionEventSpotItem> _idIndex; // 0x10
	private readonly BinaryHeap<SpotOffset> _nearestSpots; // 0x18
	private int _autoInc; // 0x20
	private PeriodicMultiPositionEventSpotItem _head; // 0x28

	// Properties
	public int count { /* [XID] */ /* 0x00000001896CFF30-0x00000001896CFF50 */ get => default; } // 0x0000000181A049F0-0x0000000181A04AB0 

	// Nested types
	private struct SpotOffset // TypeDefIndex: 11494
	{
		// Properties
		public Vector3 position { /* [XID] */ /* 0x0000000189711470-0x00000001897114B0 */ get; /* [XID] */ /* 0x000000018971BAD0-0x000000018971BB10 */ set; } // 0x0000000181A18130-0x0000000181A181B0 0x0000000181A180B0-0x0000000181A18130
		public float distance { /* [XID] */ /* 0x0000000189725F80-0x0000000189725FC0 */ get; /* [XID] */ /* 0x00000001897306B0-0x00000001897306F0 */ set; } // 0x0000000181A18040-0x0000000181A180B0 0x0000000181A181B0-0x0000000181A18220
	}

	private class SpotOffsetComparer : IComparer<SpotOffset> // TypeDefIndex: 11495
	{
		// Constructors
		public SpotOffsetComparer() {} // 0x0000000181A18F80-0x0000000181A18FE0

		// Methods
		// [XID] // 0x000000018973AC10-0x000000018973AC30
		public int Compare(SpotOffset x, SpotOffset y) => default; // 0x0000000181A18DF0-0x0000000181A18F80
	}

	// Constructors
	static PeriodicMultiPositionEventSpotCollection() {} // 0x0000000181A050D0-0x0000000181A05190
	public PeriodicMultiPositionEventSpotCollection() {} // 0x0000000181A05190-0x0000000181A052A0

	// Methods
	// [XID] // 0x00000001896D7300-0x00000001896D7320
	public void AddSpot(PeriodicMultiPositionEventSpot spot) {} // 0x0000000181A04810-0x0000000181A049F0
	// [XID] // 0x00000001896DEBD0-0x00000001896DEBF0
	public void RemoveSpot(int id) {} // 0x0000000181A04360-0x0000000181A045B0
	// [XID] // 0x00000001896E5DE0-0x00000001896E5E00
	public AudioPositionArray GetPositionArray(Vector3 listenerPosition) => default; // 0x0000000181A04AB0-0x0000000181A050D0
	// [XID] // 0x00000001896ED430-0x00000001896ED450
	public void Clear() {} // 0x0000000181A046D0-0x0000000181A04810
	// [XID] // 0x00000001896F4D60-0x00000001896F4D80
	private void Recycle(PeriodicMultiPositionEventSpotItem node) {} // 0x0000000181A045B0-0x0000000181A046D0
}

