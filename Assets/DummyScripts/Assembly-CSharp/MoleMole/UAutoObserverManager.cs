/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.UAuto;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class UAutoObserverManager : MonoBehaviour // TypeDefIndex: 28019
	{
		// Fields
		public AutoTestDriver driver; // 0x18
		private List<IObserver> observers; // 0x20
	
		// Constructors
		public UAutoObserverManager() {} // 0x00000001821A07A0-0x00000001821A0830
	
		// Methods
		// [XID] // 0x0000000189B45D50-0x0000000189B45D70
		public void OnNotify(GameObject sender) {} // 0x00000001821A0520-0x00000001821A06D0
		// [XID] // 0x0000000189B4D1B0-0x0000000189B4D1D0
		public void AddObserver(IObserver observer) {} // 0x00000001821A0450-0x00000001821A0520
		// [XID] // 0x0000000189B54A00-0x0000000189B54A20
		public void RemoveObserver(IObserver observer) {} // 0x00000001821A06D0-0x00000001821A07A0
	}
}
