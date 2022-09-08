/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole.Config;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CSharpCallLua] // 0x00000001895E7550-0x00000001895E7560
	public interface ILuaShapeData // TypeDefIndex: 21060
	{
		// Properties
		string shapeName { get; }
		Vector3 shapePosOffset { get; }
		Vector3 shapeEulerOffset { get; }
		float shapeHeight { get; }
		int campID { get; }
		TargetType targetType { get; }
		TimerLimitType liftType { get; }
		float lifeTime { get; }
		TimerLimitType triggerType { get; }
		float checkCD { get; }
	}
}
