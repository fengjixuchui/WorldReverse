/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class NormalTimer // TypeDefIndex: 31799
{
	// Fields
	public Action timeupAction; // 0x20
	public bool fromCache; // 0x28

	// Properties
	public float timer { /* [XID] */ /* 0x00000001899FD9B0-0x00000001899FD9F0 */ get; /* [XID] */ /* 0x0000000189A08080-0x0000000189A080C0 */ protected set; } // 0x0000000183225D00-0x0000000183225D70 0x0000000183225C90-0x0000000183225D00
	public float timespan { /* [XID] */ /* 0x0000000189A128A0-0x0000000189A128E0 */ get; /* [XID] */ /* 0x0000000189A1CBE0-0x0000000189A1CC20 */ set; } // 0x0000000183226C10-0x0000000183226C80 0x0000000183225C20-0x0000000183225C90
	public bool isTimeUp { /* [XID] */ /* 0x0000000189A26D90-0x0000000189A26DD0 */ get; /* [XID] */ /* 0x0000000189A31380-0x0000000189A313C0 */ protected set; } // 0x0000000183226E30-0x0000000183226E90 0x0000000183226E90-0x0000000183226EF0
	public bool isActive { /* [XID] */ /* 0x0000000189A3BA70-0x0000000189A3BAB0 */ get; /* [XID] */ /* 0x0000000189A46490-0x0000000189A464D0 */ protected set; } // 0x0000000183226FD0-0x0000000183227030 0x0000000183226220-0x0000000183226280

	// Constructors
	public NormalTimer() {} // 0x00000001832270E0-0x0000000183227150

	// Methods
	// [IDTag] // 0x0000000189A50CA0-0x0000000189A50CE0
	// [XID] // 0x0000000189A50CA0-0x0000000189A50CE0
	public virtual void Init() {} // 0x00000001832264A0-0x00000001832265D0
	// [IDTag] // 0x0000000189A5B5C0-0x0000000189A5B600
	// [XID] // 0x0000000189A5B5C0-0x0000000189A5B600
	public virtual void Init(float timespan) {} // 0x0000000183226280-0x0000000183226340
	// [IDTag] // 0x0000000189A65E80-0x0000000189A65EC0
	// [XID] // 0x0000000189A65E80-0x0000000189A65EC0
	public virtual void Init(float timespan, bool active) {} // 0x0000000183226340-0x00000001832264A0
	// [XID] // 0x0000000189A70620-0x0000000189A70640
	public virtual void Clear() {} // 0x0000000183226850-0x0000000183226A00
	// [IDTag] // 0x0000000189A77E90-0x0000000189A77ED0
	// [XID] // 0x0000000189A77E90-0x0000000189A77ED0
	public void Reset(float? presetTime = default) {} // 0x0000000183225EA0-0x0000000183226010
	// [IDTag] // 0x0000000189A827B0-0x0000000189A827F0
	// [XID] // 0x0000000189A827B0-0x0000000189A827F0
	public void Reset(bool active, float? presetTime = default) {} // 0x0000000183226140-0x0000000183226220
	// [IDTag] // 0x0000000189A8D0F0-0x0000000189A8D130
	// [XID] // 0x0000000189A8D0F0-0x0000000189A8D130
	public void Reset(float timespan, bool active, float? presetTime = default) {} // 0x0000000183226010-0x0000000183226140
	// [XID] // 0x00000001896302D0-0x00000001896302F0
	public void SetActive(bool active) {} // 0x0000000183226EF0-0x0000000183226FD0
	// [XID] // 0x0000000189A9ED40-0x0000000189A9ED60
	public void Restart(float time) {} // 0x0000000183226C80-0x0000000183226E30
	// [XID] // 0x0000000189AA6650-0x0000000189AA6670
	public float GetTimingRatio() => default; // 0x0000000183226AB0-0x0000000183226C10
	// [XID] // 0x0000000189AADD00-0x0000000189AADD20
	public float GetRemainingTime() => default; // 0x0000000183225D70-0x0000000183225EA0
	// [XID] // 0x000000018960AFC0-0x000000018960AFE0
	public virtual float GetInitTime() => default; // 0x0000000183227030-0x00000001832270E0
	// [XID] // 0x000000018967B560-0x000000018967B580
	protected virtual float GetCurrentDeltaTime(float deltaTime) => default; // 0x0000000183226A00-0x0000000183226AB0
	// [XID] // 0x000000018965D340-0x000000018965D360
	public virtual float Tick(float deltaTime) => default; // 0x00000001832265D0-0x0000000183226850
}

