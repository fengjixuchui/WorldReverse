/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public class CurtainTask // TypeDefIndex: 28557
	{
		// Fields
		protected bool _isStarted; // 0x10
		protected bool _isFinished; // 0x11
	
		// Properties
		public bool isStarted { /* [XID] */ /* 0x0000000189901E60-0x0000000189901E80 */ get => default; } // 0x0000000184D79850-0x0000000184D798F0 
		public bool isFinished { /* [XID] */ /* 0x00000001899096F0-0x0000000189909710 */ get => default; } // 0x0000000184D797B0-0x0000000184D79850 
	
		// Constructors
		public CurtainTask() {} // 0x0000000184D79740-0x0000000184D797B0
	
		// Methods
		// [XID] // 0x0000000189910BC0-0x0000000189910BE0
		public virtual void Start() {} // 0x0000000184D79600-0x0000000184D796A0
		// [XID] // 0x0000000189918740-0x0000000189918760
		public virtual void Tick() {} // 0x0000000184D796A0-0x0000000184D79740
		// [XID] // 0x000000018991FF20-0x000000018991FF40
		public virtual void Finish() {} // 0x0000000184D79560-0x0000000184D79600
	}
}
