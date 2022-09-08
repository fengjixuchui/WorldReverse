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

public class AngleRandomizer // TypeDefIndex: 20512
{
	// Fields
	private static Data _dataShared; // 0x00
	private Data _data; // 0x10

	// Nested types
	private class Data // TypeDefIndex: 20513
	{
		// Fields
		private List<sbyte> _remainingIndices; // 0x10
		private Vector3 _startDir; // 0x18
		private float _arcStep; // 0x24

		// Constructors
		public Data() {} // 0x00000001845C60E0-0x00000001845C6170

		// Methods
		// [XID] // 0x0000000189B9A800-0x0000000189B9A820
		public void Set(Vector3 startDirection, float arc, sbyte size) {} // 0x00000001845C5EC0-0x00000001845C6020
		// [XID] // 0x0000000189BA1FB0-0x0000000189BA1FD0
		public bool HasNext() => default; // 0x00000001845C6020-0x00000001845C60E0
		// [XID] // 0x0000000189BA9380-0x0000000189BA93A0
		public Vector3? TakeNext(bool sync = true /* Metadata: 0x00AFDB93 */) => default; // 0x00000001845C5BD0-0x00000001845C5EC0
	}

	// Constructors
	public AngleRandomizer() {} // 0x00000001845AD900-0x00000001845AD990
	static AngleRandomizer() {} // 0x00000001845AD880-0x00000001845AD900

	// Methods
	// [XID] // 0x0000000189B6E160-0x0000000189B6E180
	public static void SyncReset(Vector3 startDirection, float arc, sbyte size) {} // 0x00000001845AD630-0x00000001845AD770
	// [XID] // 0x0000000189B75970-0x0000000189B75990
	public static bool SyncHasNext() => default; // 0x00000001845AD340-0x00000001845AD420
	// [XID] // 0x0000000189B7CE30-0x0000000189B7CE50
	public static Vector3? SyncTakeNext() => default; // 0x00000001845AD770-0x00000001845AD880
	// [XID] // 0x0000000189B84CB0-0x0000000189B84CD0
	public void AsyncReset(Vector3 startDirection, float arc, sbyte size) {} // 0x00000001845AD420-0x00000001845AD540
	// [XID] // 0x0000000189B8BA60-0x0000000189B8BA80
	public bool AsyncHasNext() => default; // 0x00000001845AD290-0x00000001845AD340
	// [XID] // 0x0000000189B932B0-0x0000000189B932D0
	public Vector3? AsyncTakeNext() => default; // 0x00000001845AD540-0x00000001845AD630
}

