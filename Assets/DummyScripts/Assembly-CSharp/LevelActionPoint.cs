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

public class LevelActionPoint // TypeDefIndex: 19511
{
	// Fields
	public uint localID; // 0x10
	public ActionPointType type; // 0x14
	public Vector3 pos; // 0x18
	public Vector3 rot; // 0x24
	public int capacity; // 0x30
	public float actZoneInnerRadius; // 0x34
	public float actZoneOuterRadius; // 0x38
	public int freestyle; // 0x3C
	public bool faceCenter; // 0x40
	private Dictionary<uint, BaseEntityHandle> _tokenHolders; // 0x48
	private List<uint> _invalidatedHolders; // 0x50

	// Constructors
	public LevelActionPoint() {} // Dummy constructor
	public LevelActionPoint(uint pLocalID, ActionPointType pType, Vector3 pPos, Vector3 pRot, int pCapacity, float pInnerRadius, float pOuterRadius, int pFreestyle, bool pFaceCenter) {} // 0x0000000184643A00-0x0000000184643B30

	// Methods
	// [XID] // 0x000000018982EDA0-0x000000018982EDC0
	public void AcquireToken(BaseEntity applicant) {} // 0x0000000184643540-0x00000001846436C0
	// [IDTag] // 0x00000001898366D0-0x0000000189836710
	// [XID] // 0x00000001898366D0-0x0000000189836710
	public void ReleaseToken(BaseEntity applicant) {} // 0x0000000184643850-0x0000000184643930
	// [IDTag] // 0x0000000189840A80-0x0000000189840AC0
	// [XID] // 0x0000000189840A80-0x0000000189840AC0
	public void ReleaseToken(uint runtimeID) {} // 0x0000000184643930-0x0000000184643A00
	// [XID] // 0x000000018984AFD0-0x000000018984AFF0
	public bool HasAvailableToken() => default; // 0x0000000184643480-0x0000000184643540
	// [XID] // 0x0000000189852260-0x0000000189852280
	public bool IsTokenHolder(BaseEntity applicant) => default; // 0x0000000184643770-0x0000000184643850
	// [XID] // 0x000000018974FEB0-0x000000018974FED0
	public bool IsConvsationPoint() => default; // 0x00000001846436C0-0x0000000184643770
	// [XID] // 0x00000001899526A0-0x00000001899526C0
	public void RefreshTokenHolders() {} // 0x00000001846430F0-0x0000000184643480
	// [XID] // 0x0000000189868550-0x0000000189868570
	public void Destroy() {} // 0x0000000184642EB0-0x00000001846430F0
}

