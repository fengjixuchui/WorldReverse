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

public class CTDynamicRegistration // TypeDefIndex: 11240
{
	// Fields
	private readonly CommandThreadContext _context; // 0x10
	private readonly AmbientSpawns _ambientSpawns; // 0x18

	// Constructors
	public CTDynamicRegistration() {} // Dummy constructor
	static CTDynamicRegistration() {} // 0x0000000183A0E0B0-0x0000000183A0E100
	public CTDynamicRegistration(CommandThreadContext context) {} // 0x0000000183A0E100-0x0000000183A0E190

	// Methods
	// [XID] // 0x0000000189A8E670-0x0000000189A8E690
	public void Start() {} // 0x0000000183A0DC50-0x0000000183A0DD00
	// [XID] // 0x0000000189A95AF0-0x0000000189A95B10
	public void AddDynamicObject(int id, Vector3 position, Quaternion rotation, Vector3 scale, ulong prefabHash) {} // 0x0000000183A0DE00-0x0000000183A0DF90
	// [XID] // 0x000000018987F710-0x000000018987F730
	public void RemoveDynamicObject(int id) {} // 0x0000000183A0DA60-0x0000000183A0DB30
	// [XID] // 0x0000000189A35D00-0x0000000189A35D20
	public void Clear() {} // 0x0000000183A0DD00-0x0000000183A0DE00
	// [XID] // 0x0000000189AAC0D0-0x0000000189AAC0F0
	public void InstantiateDynamicObject(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000183A0DF90-0x0000000183A0E0B0
	// [XID] // 0x0000000189AB3A50-0x0000000189AB3A70
	public void AdjustDynamicObject(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000183A0DB30-0x0000000183A0DC50
	// [XID] // 0x0000000189ABB750-0x0000000189ABB770
	public void RecycleDynamicObject(AudioDynamicAmbientObject dynamicObject) {} // 0x0000000183A0D940-0x0000000183A0DA60
}

