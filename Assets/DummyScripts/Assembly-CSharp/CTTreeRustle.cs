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

public class CTTreeRustle // TypeDefIndex: 11250
{
	// Fields
	private readonly CommandThreadContext _context; // 0x10
	private readonly CTGatherer _gatherer; // 0x18
	private readonly CTRustler _rustler; // 0x20

	// Nested types
	private static class ReusedPositionArrays // TypeDefIndex: 11251
	{
		// Fields
		private static readonly Dictionary<ushort, AudioPositionArray> _cache; // 0x00

		// Constructors
		static ReusedPositionArrays() {} // 0x0000000183CF4990-0x0000000183CF4A20

		// Methods
		// [XID] // 0x0000000189630150-0x0000000189630170
		public static AudioPositionArray Get(ushort count) => default; // 0x0000000183CF47B0-0x0000000183CF4990
	}

	// Constructors
	public CTTreeRustle() {} // Dummy constructor
	public CTTreeRustle(CommandThreadContext context) {} // 0x0000000183CDB600-0x0000000183CDB6B0

	// Methods
	// [XID] // 0x0000000189612290-0x00000001896122B0
	public void Init() {} // 0x0000000183CDB4A0-0x0000000183CDB540
	// [XID] // 0x0000000189619BF0-0x0000000189619C10
	public void Start() {} // 0x0000000183CDB390-0x0000000183CDB4A0
	// [XID] // 0x0000000189621010-0x0000000189621030
	public void Tick(Vector3 listenerPosition) {} // 0x0000000183CDB540-0x0000000183CDB600
	// [XID] // 0x00000001896287E0-0x0000000189628800
	public void Stop() {} // 0x0000000183CDB280-0x0000000183CDB390
}

