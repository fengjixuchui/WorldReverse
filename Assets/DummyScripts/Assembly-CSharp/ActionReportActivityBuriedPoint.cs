/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct ActionReportActivityBuriedPoint : IContextAction // TypeDefIndex: 29457
{
	// Fields
	public uint activityId; // 0x00
	public uint scheduleId; // 0x04
	public uint buttonId; // 0x08
	public uint additionalInfo; // 0x0C
	public NewActivityType activityType; // 0x10
	public CallType callType; // 0x14

	// Nested types
	public enum CallType // TypeDefIndex: 29458
	{
		UseScheduleId = 0,
		UseType = 1,
		UseEmptyAdditionalInfo = 2,
		None = 3
	}

	// Constructors
	public ActionReportActivityBuriedPoint(uint activityId, uint scheduleId, uint buttonId, uint additionalInfo) {
		this.activityId = default;
		this.scheduleId = default;
		this.buttonId = default;
		this.additionalInfo = default;
		activityType = default;
		callType = default;
	} // 0x0000000183330960-0x0000000183330A00
	public ActionReportActivityBuriedPoint(NewActivityType activityType, uint buttonId, uint additionalInfo) {
		activityId = default;
		scheduleId = default;
		this.buttonId = default;
		this.additionalInfo = default;
		this.activityType = default;
		callType = default;
	} // 0x0000000183330A00-0x0000000183330A90
	public ActionReportActivityBuriedPoint(NewActivityType activityType, uint buttonId) {
		activityId = default;
		scheduleId = default;
		this.buttonId = default;
		additionalInfo = default;
		this.activityType = default;
		callType = default;
	} // 0x0000000183330A90-0x0000000183330AA0

	// Methods
	// [XID] // 0x0000000189A186C0-0x0000000189A186E0
	public void Execute() {} // 0x00000001833308C0-0x0000000183330960
}

