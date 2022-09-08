/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class BaseGroupContext // TypeDefIndex: 28438
{
	// Fields
	private List<BasePageContext> _pages; // 0x10

	// Constructors
	protected BaseGroupContext() {} // 0x00000001853A6FF0-0x00000001853A7080

	// Methods
	// [XID] // 0x0000000189B98E20-0x0000000189B98E40
	public bool ShouldDestroy() => default; // 0x00000001853A6E10-0x00000001853A6F40
	// [XID] // 0x0000000189BA0200-0x0000000189BA0220
	public void AddGroupPage(BasePageContext context) {} // 0x00000001853A6AE0-0x00000001853A6BD0
	// [XID] // 0x0000000189BA7A20-0x0000000189BA7A40
	public void RemoveGroupPage(BasePageContext context) {} // 0x00000001853A6BD0-0x00000001853A6CA0
	// [XID] // 0x0000000189BAEE10-0x0000000189BAEE30
	public bool HasPage(BasePageContext context) => default; // 0x00000001853A6A10-0x00000001853A6AE0
	// [XID] // 0x0000000189BB64C0-0x0000000189BB64E0
	public virtual void Destroy() {} // 0x00000001853A6820-0x00000001853A68D0
	// [XID] // 0x0000000189BBDB40-0x0000000189BBDB60
	public virtual void ClearOnDisconnect() {} // 0x00000001853A6D70-0x00000001853A6E10
	// [XID] // 0x0000000189BC5820-0x0000000189BC5840
	protected virtual void OnEnable() {} // 0x00000001853A6970-0x00000001853A6A10
	// [XID] // 0x0000000189BCD280-0x0000000189BCD2A0
	protected virtual void OnDisable() {} // 0x00000001853A68D0-0x00000001853A6970
	// [XID] // 0x0000000189BD4780-0x0000000189BD47A0
	public void SetActive(bool active) {} // 0x00000001853A6CA0-0x00000001853A6D70
	// [XID] // 0x0000000189BDC2F0-0x0000000189BDC310
	public virtual string ReportLog() => default; // 0x00000001853A6F40-0x00000001853A6FF0
}

