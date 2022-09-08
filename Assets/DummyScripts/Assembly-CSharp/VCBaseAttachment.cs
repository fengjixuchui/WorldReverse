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

public class VCBaseAttachment : VCBase // TypeDefIndex: 11803
{
	// Fields
	protected GameObject _view; // 0x108
	protected string _viewPath; // 0x110
	protected uint _resHandle; // 0x118
	protected BaseEntity _attachEntity; // 0x120
	protected VCAttachAnimatorPlugin _vcAttachAnimatorPlugin; // 0x128

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189859010-0x0000000189859030 */ get => default; } // 0x000000018171ADD0-0x000000018171AE70 
	public GameObject view { /* [XID] */ /* 0x00000001898601F0-0x0000000189860210 */ get => default; } // 0x000000018171A750-0x000000018171A800 
	public virtual string viewPath { /* [XID] */ /* 0x00000001898678D0-0x00000001898678F0 */ get => default; } // 0x000000018171A2D0-0x000000018171A380 
	public virtual bool IsAniamtorValid { /* [XID] */ /* 0x000000018986EFE0-0x000000018986F000 */ get => default; } // 0x000000018171A870-0x000000018171A910 

	// Constructors
	public VCBaseAttachment() {} // 0x000000018171AD40-0x000000018171ADD0

	// Methods
	// [IDTag] // 0x00000001898764D0-0x0000000189876510
	// [XID] // 0x00000001898764D0-0x0000000189876510
	public void SetAnimInt(int paramNameHash, int param) {} // 0x000000018171A9C0-0x000000018171AAA0
	// [IDTag] // 0x0000000189880CD0-0x0000000189880D10
	// [XID] // 0x0000000189880CD0-0x0000000189880D10
	public void SetAnimInt(string paramName, int param) {} // 0x000000018171AAA0-0x000000018171AB80
	// [IDTag] // 0x000000018988AEB0-0x000000018988AEF0
	// [XID] // 0x000000018988AEB0-0x000000018988AEF0
	public int GetAnimInt(int paramNameHash) => default; // 0x000000018171A380-0x000000018171A450
	// [IDTag] // 0x0000000189895280-0x00000001898952C0
	// [XID] // 0x0000000189895280-0x00000001898952C0
	public int GetAnimInt(string paramName) => default; // 0x000000018171A450-0x000000018171A520
	// [IDTag] // 0x000000018989F460-0x000000018989F4A0
	// [XID] // 0x000000018989F460-0x000000018989F4A0
	public void SetAnimFloat(int paramNameHash, float value) {} // 0x000000018171A030-0x000000018171A110
	// [IDTag] // 0x00000001898A9D40-0x00000001898A9D80
	// [XID] // 0x00000001898A9D40-0x00000001898A9D80
	public float GetAnimFloat(int paramNameHash) => default; // 0x0000000181719E90-0x0000000181719F60
	// [IDTag] // 0x0000000189A7C400-0x0000000189A7C440
	// [XID] // 0x0000000189A7C400-0x0000000189A7C440
	public void SetAnimFloat(string paramName, float value) {} // 0x000000018171A110-0x000000018171A1F0
	// [IDTag] // 0x00000001898BEC60-0x00000001898BECA0
	// [XID] // 0x00000001898BEC60-0x00000001898BECA0
	public float GetAnimFloat(string paramName) => default; // 0x0000000181719F60-0x000000018171A030
	// [XID] // 0x0000000189AA31C0-0x0000000189AA31E0
	public void ForceJumpToState(string paramName) {} // 0x0000000181719DD0-0x0000000181719E90
	// [XID] // 0x0000000189AB2530-0x0000000189AB2550
	public override void PreInit() {} // 0x000000018171AB80-0x000000018171AD40
	// [XID] // 0x0000000189AC15D0-0x0000000189AC15F0
	public override void Init() {} // 0x000000018171A520-0x000000018171A5F0
	// [XID] // 0x0000000189AC8DE0-0x0000000189AC8E00
	protected virtual void AddAttachmentPlugins() {} // 0x000000018171A6B0-0x000000018171A750
	// [XID] // 0x0000000189AD8310-0x0000000189AD8330
	public override void Destroy() {} // 0x000000018171A1F0-0x000000018171A2D0
	// [XID] // 0x0000000189AD0560-0x0000000189AD0580
	protected virtual void SetupAttachmentPlugins() {} // 0x000000018171A910-0x000000018171A9C0
}

