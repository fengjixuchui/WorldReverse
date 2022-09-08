/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class CoopBaseNodeTask // TypeDefIndex: 20785
{
	// Fields
	protected ConfigCoopBaseNode _nodeConfig; // 0x10
	protected CoopNodeType _nodeType; // 0x18
	protected uint _mainCoopId; // 0x1C

	// Constructors
	public CoopBaseNodeTask() {} // 0x0000000183928820-0x0000000183928890

	// Methods
	// [XID] // 0x0000000189B4A6D0-0x0000000189B4A6F0
	public virtual void Init(ConfigCoopBaseNode nodeConfig) {} // 0x0000000183928520-0x00000001839285F0
	// [XID] // 0x0000000189A57F40-0x0000000189A57F60
	public void AttachToMainCoop(uint mainCoopId) {} // 0x0000000183928310-0x00000001839283C0
	// [XID] // 0x0000000189B59660-0x0000000189B59680
	public void Start() {} // 0x00000001839283C0-0x0000000183928470
	// [XID] // 0x0000000189B60EB0-0x0000000189B60ED0
	protected virtual void StartInternal() {} // 0x00000001839286E0-0x0000000183928780
	// [XID] // 0x0000000189B68670-0x0000000189B68690
	public void End() {} // 0x00000001839285F0-0x00000001839286E0
	// [XID] // 0x0000000189B6F9E0-0x0000000189B6FA00
	protected virtual void EndInternal() {} // 0x0000000183928780-0x0000000183928820
	// [XID] // 0x0000000189B76F70-0x0000000189B76F90
	public virtual void OnCoopEvent(CoopEvent evt) {} // 0x0000000183928470-0x0000000183928520
}

