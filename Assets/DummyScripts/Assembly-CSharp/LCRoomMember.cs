/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class LCRoomMember : LCBase // TypeDefIndex: 11760
{
	// Fields
	private Vector3 lastPos; // 0x134

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189BBBCD0-0x0000000189BBBCF0 */ get => default; } // 0x0000000182CCD900-0x0000000182CCD9A0 
	public uint roomID { /* [XID] */ /* 0x0000000189BCE260-0x0000000189BCE2A0 */ get; /* [XID] */ /* 0x0000000189BC3B70-0x0000000189BC3BB0 */ private set; } // 0x0000000182CCC0E0-0x0000000182CCC140 0x0000000182CCC360-0x0000000182CCC3D0

	// Constructors
	public LCRoomMember() {} // Dummy constructor
	public LCRoomMember(uint roomID) {} // 0x0000000182CCD810-0x0000000182CCD900

	// Methods
	// [XID] // 0x000000018968F280-0x000000018968F2A0
	public override void Init() {} // 0x0000000182CCC4B0-0x0000000182CCC720
	// [XID] // 0x0000000189696C70-0x0000000189696C90
	public override void Destroy() {} // 0x0000000182CCC140-0x0000000182CCC260
	// [XID] // 0x00000001895ECC60-0x00000001895ECC80
	public override void OnEntityReady() {} // 0x0000000182CCD190-0x0000000182CCD370
	// [XID] // 0x00000001895F42B0-0x00000001895F42D0
	private static new EventID[] GetSelfListenEventIDsExcludingBase() => default; // 0x0000000182CCC3D0-0x0000000182CCC4B0
	// [XID] // 0x00000001895FBAC0-0x00000001895FBAE0
	protected override bool ListenEvent(BaseEvent evt) => default; // 0x0000000182CCC780-0x0000000182CCC8F0
	// [XID] // 0x000000018982B6D0-0x000000018982B6F0
	private uint CheckRoomID() => default; // 0x0000000182CCC8F0-0x0000000182CCD0C0
	// [XID] // 0x000000018960AC20-0x000000018960AC40
	public void SetRoomID(uint roomID) {} // 0x0000000182CCD370-0x0000000182CCD610
	// [XID] // 0x00000001896E5EC0-0x00000001896E5EE0
	protected override void Tick(float inDeltaTime) {} // 0x0000000182CCD610-0x0000000182CCD810
}

